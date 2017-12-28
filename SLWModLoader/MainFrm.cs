using System;
using System.IO;
using System.Windows.Forms;
using SLWModLoader.Properties;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace SLWModLoader
{
    public partial class MainFrm : Form
    {
        // Variables/Constants
        private string modsDirOldTxt = "";
        private bool doSave = true, isUpdatingList = false;

        // Constructors
        public MainFrm()
        {
            InitializeComponent();
            Text = $"{Program.Name} (v {Program.Version:N1})";
        }

        // Methods
        private void RefreshList()
        {
            var watch = Stopwatch.StartNew(); // TODO: REMOVE THIS LINE
            string modsDBPath = Program.ModsDBPath;
            var modsDB = INI.Load(modsDBPath);
            string[] activeMods = null;

            // Refresh mods list
            isUpdatingList = true;
            modsList.BeginUpdate();
            modsList.Items.Clear();

            if (modsDB.ContainsKey("Main"))
            {
                // Get active mods, if any
                var mainCategory = (Dictionary<string, string>)modsDB["Main"];
                if (mainCategory.ContainsKey("ActiveModCount") &&
                    uint.TryParse(mainCategory["ActiveModCount"], out uint activeModCount))
                {
                    activeMods = new string[activeModCount];
                    for (uint i = 0; i < activeModCount; ++i)
                    {
                        activeMods[i] = (mainCategory.ContainsKey($"ActiveMod{i}")) ?
                            mainCategory[$"ActiveMod{i}"] : "";
                    }
                }
            }

            if (modsDB.ContainsKey("Mods"))
            {
                var modsCategory = (Dictionary<string, string>)modsDB["Mods"];
                string modsDBFolder = Path.GetDirectoryName(modsDBPath);

                // Load all mod information
                foreach (var mod in modsCategory)
                {
                    string modPth = (File.Exists(mod.Value))?
                        mod.Value : Path.Combine(modsDBFolder, mod.Value);

                    if (File.Exists(modPth))
                    {
                        var lvi = modsList.Items.Add(LoadModData(modPth));
                        if (activeMods != null)
                        {
                            lvi.Checked = activeMods.Contains(mod.Key);
                        }

                        lvi.Group = modsList.Groups[(lvi.Checked) ? 0 : 1];
                    }
                }
            }

            modsList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            modsList.EndUpdate();
            isUpdatingList = false;

            noModsFoundLbl.Visible =
                openModsDirLbl.Visible = (modsList.Items.Count <= 0);

            // TODO: Remove this debug stuff
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        private ListViewItem LoadModData(string filePath)
        {
            var mod = INI.Load(filePath);
            var lvi = new ListViewItem();
            var modInfo = new ModInfo();
            Dictionary<string, string> category = null;

            // Main category
            if (mod.ContainsKey("Main"))
            {
                category = (Dictionary<string, string>)mod["Main"];
                // TODO: Check update server for updates
            }

            // Desc category
            if (mod.ContainsKey("Desc"))
                category = (Dictionary<string, string>)mod["Desc"];

            modInfo.Title = GetProperty("Title",
                new FileInfo(filePath).Directory.Name);

            modInfo.Description = GetProperty("Description",
                "This mod doesn't have any description.");

            modInfo.Version = GetProperty("Version", "1.0");
            modInfo.Date = GetProperty("Date", "");
            modInfo.Author = GetProperty("Author", "");
            modInfo.AuthorURL = GetProperty("AuthorURL", "");
            modInfo.URL = GetProperty("URL", "");

            // TODO

            // Set ListViewItem elements
            lvi.Text = modInfo.Title;
            lvi.SubItems.Add(modInfo.Version);
            lvi.SubItems.Add(modInfo.Author);

            lvi.Tag = modInfo;
            return lvi;

            // Sub-Methods
            string GetProperty(string propertyName, string defaultValue)
            {
                return (category != null && category.ContainsKey(propertyName)) ?
                    category[propertyName].Replace("\"", "") : defaultValue;
            }
        }

        private bool AutodetectModsDir()
        {
            // Attempt to automatically find the game's install directory
            // using a Steam install path which can be found in the registry
            string steamPth = Reg.GetValue(Reg.SteamKey, Reg.SteamPath);
            string slwDir = GetSLWDir(steamPth);

            if (!Directory.Exists(slwDir))
            {
                // If the user isn't using the default games library folder, iterate through
                // each item in the Steam libraryfolders.vdf file and try to find it there.
                string vdfPth = (steamPth == null) ? null :
                    Path.Combine(steamPth, "steamapps", "libraryfolders.vdf");

                if (!string.IsNullOrEmpty(vdfPth) && File.Exists(vdfPth))
                {
                    var vdf = SteamConfig.Load(vdfPth);
                    bool slwPathFound = false;
                    var libraryFolders = SteamConfig.GetContainer(vdf, "LibraryFolders");

                    if (libraryFolders == null)
                        return false;

                    foreach (var folder in libraryFolders)
                    {
                        if (int.TryParse(folder.Key, out int id))
                        {
                            // Remove double-slashes in the path (replace them with single slashes)
                            slwDir = GetSLWDir(((string)folder.Value).Replace(@"\\", @"\"));
                            if (Directory.Exists(slwDir))
                            {
                                slwPathFound = true;
                                break;
                            }
                        }
                    }

                    if (!slwPathFound)
                        return false;
                }
            }

            string modsDir = Path.Combine(slwDir, "mods").Replace('/', '\\');
            Directory.CreateDirectory(modsDir);
            Settings.Default.ModsDirectory = modsDir;
            return true;

            // Sub-Methods
            string GetSLWDir(string libraryFolder)
            {
                // TODO: Get game name from the ACF instead based on game ID
                return Path.Combine(libraryFolder, "steamapps",
                    "common", "Sonic Lost World");
            }
        }

        private FolderBrowserDialog GetModsDirDialog()
        {
            return new FolderBrowserDialog()
            {
                Description =
                    "The directory which contains (or will contain) your installed mods"
            };
        }

        private void Error(Exception ex)
        {
            MessageBox.Show($"ERROR: {ex.Message}", Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Error(string errorText)
        {
            MessageBox.Show($"ERROR: {errorText}", Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenURL(string url)
        {
            // Get the default browser's path from the registry if available
            // and open the given URL in it (Process.Start(url) is quite insecure)
            string defBrowser = Reg.GetValue(Reg.DefBrowser, "ProgId");
            if (!string.IsNullOrEmpty(defBrowser))
            {
                string application = Reg.GetValue(Path.Combine(Reg.Classes,
                    defBrowser, "shell", "open", "command"), null);

                if (!string.IsNullOrEmpty(application))
                {
                    // Remove any quotes/arguments from the value - we just want the EXE's path
                    application = application.Replace("\"", "");
                    if (!application.EndsWith(".exe"))
                        application = application.Substring(0, application.LastIndexOf(".exe")+4);

                    if (File.Exists(application))
                    {
                        Process.Start(application, url);
                        return;
                    }
                }
            }

            // If we can't get the default browser for whatever
            // reason, just open the URL in IE
            Process.Start("iexplore.exe", url);
        }

        // GUI Events
        private void MainFrm_Load(object sender, EventArgs e)
        {
            // If necessary, perform first-time setup
            if (string.IsNullOrEmpty(Settings.Default.ModsDirectory))
            {
                // If it's not possible to auto-detect the mods
                // directory, prompt the user to input one instead
                if (!AutodetectModsDir())
                {
                    MessageBox.Show(string.Format("Your game's install directory {0} {1}",
                        "could not be detected.\nPlease manually specify",
                        "where you'd like to install your mods."),
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var fbd = GetModsDirDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        Settings.Default.ModsDirectory = fbd.SelectedPath;
                        Activate();
                    }
                    else
                    {
                        doSave = false;
                        Close();
                        return;
                    }
                }
            }

            // Update GUI
            modsDirOldTxt = modsDirTxtbx.Text = Settings.Default.ModsDirectory;
            RefreshList();

            // TODO: Check for updates
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO

            // Save settings
            if (doSave)
            {
                if (Directory.Exists(modsDirTxtbx.Text))
                    Settings.Default.ModsDirectory = modsDirTxtbx.Text;

                Settings.Default.Save();
            }
        }

        private void ModsList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (isUpdatingList)
                return;

            e.Item.Group = modsList.Groups[(e.Item.Checked) ? 0 : 1];
        }

        private void OpenModsDirLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", Settings.Default.ModsDirectory);
        }

        private void DescLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO
        }

        private void RemoveModBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void AddModBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void SaveAndPlayBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void ModsDirTxtbx_Leave(object sender, EventArgs e)
        {
            if (!Directory.Exists(modsDirTxtbx.Text))
            {
                Error("The given directory is invalid or does not exist!");
                modsDirTxtbx.Text = modsDirOldTxt;
                return;
            }

            modsDirOldTxt = modsDirTxtbx.Text;
        }

        private void ModsDirBtn_Click(object sender, EventArgs e)
        {
            var fbd = GetModsDirDialog();
            fbd.SelectedPath = (Directory.Exists(modsDirTxtbx.Text)) ?
                modsDirTxtbx.Text : "";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                modsDirOldTxt = modsDirTxtbx.Text = fbd.SelectedPath;
            }
        }

        private void ReportLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL("https://github.com/Radfordhound/SLW-Mod-Loader/issues/new");
        }
    }
}