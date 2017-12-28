namespace SLWModLoader
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Active Mods", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Inactive Mods", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.modsList = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainPnl = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.modPage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.openModsDirLbl = new System.Windows.Forms.LinkLabel();
            this.noModsFoundLbl = new System.Windows.Forms.Label();
            this.moveDownAll = new System.Windows.Forms.Button();
            this.moveUpAll = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.modsDirBtn = new System.Windows.Forms.Button();
            this.modsDirTxtbx = new System.Windows.Forms.TextBox();
            this.modsDirLbl = new System.Windows.Forms.Label();
            this.settingsBottomPnl = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.reportLbl = new System.Windows.Forms.LinkLabel();
            this.saveAndPlayBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.descLbl = new System.Windows.Forms.LinkLabel();
            this.addModBtn = new System.Windows.Forms.Button();
            this.removeModBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mainPnl.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.modPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.settingsBottomPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // modsList
            // 
            this.modsList.AllowDrop = true;
            this.modsList.CheckBoxes = true;
            this.modsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.versionColumn,
            this.authorColumn});
            this.modsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modsList.FullRowSelect = true;
            listViewGroup1.Header = "Active Mods";
            listViewGroup1.Name = "activeGroup";
            listViewGroup2.Header = "Inactive Mods";
            listViewGroup2.Name = "inactiveGroup";
            this.modsList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.modsList.Location = new System.Drawing.Point(0, 0);
            this.modsList.MultiSelect = false;
            this.modsList.Name = "modsList";
            this.modsList.Size = new System.Drawing.Size(490, 406);
            this.modsList.TabIndex = 0;
            this.modsList.UseCompatibleStateImageBehavior = false;
            this.modsList.View = System.Windows.Forms.View.Details;
            this.modsList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ModsList_ItemChecked);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 175;
            // 
            // versionColumn
            // 
            this.versionColumn.Text = "V";
            this.versionColumn.Width = 31;
            // 
            // authorColumn
            // 
            this.authorColumn.Text = "Author(s)";
            this.authorColumn.Width = 119;
            // 
            // mainPnl
            // 
            this.mainPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPnl.Controls.Add(this.mainTabControl);
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(537, 445);
            this.mainPnl.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.modPage);
            this.mainTabControl.Controls.Add(this.settingsPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(537, 445);
            this.mainTabControl.TabIndex = 0;
            // 
            // modPage
            // 
            this.modPage.BackColor = System.Drawing.Color.White;
            this.modPage.Controls.Add(this.splitContainer);
            this.modPage.Location = new System.Drawing.Point(4, 29);
            this.modPage.Name = "modPage";
            this.modPage.Padding = new System.Windows.Forms.Padding(3);
            this.modPage.Size = new System.Drawing.Size(529, 412);
            this.modPage.TabIndex = 0;
            this.modPage.Text = "Mods";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.openModsDirLbl);
            this.splitContainer.Panel1.Controls.Add(this.noModsFoundLbl);
            this.splitContainer.Panel1.Controls.Add(this.modsList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.moveDownAll);
            this.splitContainer.Panel2.Controls.Add(this.moveUpAll);
            this.splitContainer.Panel2.Controls.Add(this.moveDownButton);
            this.splitContainer.Panel2.Controls.Add(this.moveUpButton);
            this.splitContainer.Size = new System.Drawing.Size(523, 406);
            this.splitContainer.SplitterDistance = 490;
            this.splitContainer.TabIndex = 5;
            // 
            // openModsDirLbl
            // 
            this.openModsDirLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.openModsDirLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openModsDirLbl.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openModsDirLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.openModsDirLbl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.openModsDirLbl.Location = new System.Drawing.Point(0, 243);
            this.openModsDirLbl.Name = "openModsDirLbl";
            this.openModsDirLbl.Size = new System.Drawing.Size(518, 28);
            this.openModsDirLbl.TabIndex = 5;
            this.openModsDirLbl.TabStop = true;
            this.openModsDirLbl.Text = "Open Mods Folder";
            this.openModsDirLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openModsDirLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenModsDirLbl_LinkClicked);
            // 
            // noModsFoundLbl
            // 
            this.noModsFoundLbl.BackColor = System.Drawing.Color.Transparent;
            this.noModsFoundLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noModsFoundLbl.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noModsFoundLbl.ForeColor = System.Drawing.Color.Maroon;
            this.noModsFoundLbl.Location = new System.Drawing.Point(0, 0);
            this.noModsFoundLbl.Name = "noModsFoundLbl";
            this.noModsFoundLbl.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.noModsFoundLbl.Size = new System.Drawing.Size(490, 406);
            this.noModsFoundLbl.TabIndex = 4;
            this.noModsFoundLbl.Text = "No mods were found!\r\nPlease check your mods folder.";
            this.noModsFoundLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moveDownAll
            // 
            this.moveDownAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownAll.Enabled = false;
            this.moveDownAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveDownAll.Location = new System.Drawing.Point(5, 302);
            this.moveDownAll.Name = "moveDownAll";
            this.moveDownAll.Size = new System.Drawing.Size(19, 100);
            this.moveDownAll.TabIndex = 3;
            this.moveDownAll.Text = "↓";
            this.moveDownAll.UseVisualStyleBackColor = true;
            // 
            // moveUpAll
            // 
            this.moveUpAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpAll.Enabled = false;
            this.moveUpAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveUpAll.Location = new System.Drawing.Point(5, 2);
            this.moveUpAll.Name = "moveUpAll";
            this.moveUpAll.Size = new System.Drawing.Size(19, 100);
            this.moveUpAll.TabIndex = 2;
            this.moveUpAll.Text = "↑";
            this.moveUpAll.UseVisualStyleBackColor = true;
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownButton.Enabled = false;
            this.moveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveDownButton.Location = new System.Drawing.Point(5, 202);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(19, 100);
            this.moveDownButton.TabIndex = 1;
            this.moveDownButton.Text = "▼";
            this.moveDownButton.UseVisualStyleBackColor = true;
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpButton.Enabled = false;
            this.moveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.moveUpButton.Location = new System.Drawing.Point(5, 102);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(19, 100);
            this.moveUpButton.TabIndex = 0;
            this.moveUpButton.Text = "▲";
            this.moveUpButton.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.modsDirBtn);
            this.settingsPage.Controls.Add(this.modsDirTxtbx);
            this.settingsPage.Controls.Add(this.modsDirLbl);
            this.settingsPage.Controls.Add(this.settingsBottomPnl);
            this.settingsPage.Location = new System.Drawing.Point(4, 29);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(529, 412);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // modsDirBtn
            // 
            this.modsDirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modsDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modsDirBtn.Location = new System.Drawing.Point(479, 192);
            this.modsDirBtn.Name = "modsDirBtn";
            this.modsDirBtn.Size = new System.Drawing.Size(42, 22);
            this.modsDirBtn.TabIndex = 15;
            this.modsDirBtn.Text = "...";
            this.modsDirBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.modsDirBtn.UseVisualStyleBackColor = true;
            this.modsDirBtn.Click += new System.EventHandler(this.ModsDirBtn_Click);
            // 
            // modsDirTxtbx
            // 
            this.modsDirTxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modsDirTxtbx.Location = new System.Drawing.Point(10, 193);
            this.modsDirTxtbx.Name = "modsDirTxtbx";
            this.modsDirTxtbx.Size = new System.Drawing.Size(463, 26);
            this.modsDirTxtbx.TabIndex = 14;
            this.modsDirTxtbx.Leave += new System.EventHandler(this.ModsDirTxtbx_Leave);
            // 
            // modsDirLbl
            // 
            this.modsDirLbl.AutoSize = true;
            this.modsDirLbl.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modsDirLbl.Location = new System.Drawing.Point(3, 152);
            this.modsDirLbl.Name = "modsDirLbl";
            this.modsDirLbl.Size = new System.Drawing.Size(204, 38);
            this.modsDirLbl.TabIndex = 13;
            this.modsDirLbl.Text = "Mods Directory:";
            // 
            // settingsBottomPnl
            // 
            this.settingsBottomPnl.Controls.Add(this.aboutBtn);
            this.settingsBottomPnl.Controls.Add(this.reportLbl);
            this.settingsBottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsBottomPnl.Location = new System.Drawing.Point(3, 309);
            this.settingsBottomPnl.Name = "settingsBottomPnl";
            this.settingsBottomPnl.Size = new System.Drawing.Size(523, 100);
            this.settingsBottomPnl.TabIndex = 12;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboutBtn.Location = new System.Drawing.Point(125, 42);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(276, 33);
            this.aboutBtn.TabIndex = 8;
            this.aboutBtn.Text = "&About SLW Mod Loader";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // reportLbl
            // 
            this.reportLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.reportLbl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.reportLbl.Location = new System.Drawing.Point(0, 0);
            this.reportLbl.Name = "reportLbl";
            this.reportLbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.reportLbl.Size = new System.Drawing.Size(523, 100);
            this.reportLbl.TabIndex = 11;
            this.reportLbl.TabStop = true;
            this.reportLbl.Text = "Report a problem/request a feature";
            this.reportLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReportLbl_LinkClicked);
            // 
            // saveAndPlayBtn
            // 
            this.saveAndPlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAndPlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveAndPlayBtn.Location = new System.Drawing.Point(112, 530);
            this.saveAndPlayBtn.Name = "saveAndPlayBtn";
            this.saveAndPlayBtn.Size = new System.Drawing.Size(316, 43);
            this.saveAndPlayBtn.TabIndex = 2;
            this.saveAndPlayBtn.Text = "Save &and Play";
            this.saveAndPlayBtn.UseVisualStyleBackColor = true;
            this.saveAndPlayBtn.Click += new System.EventHandler(this.SaveAndPlayBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshBtn.Location = new System.Drawing.Point(112, 491);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(316, 33);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "&Refresh Mod List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // descLbl
            // 
            this.descLbl.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.descLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.descLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.descLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.descLbl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.descLbl.Location = new System.Drawing.Point(0, 448);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(537, 35);
            this.descLbl.TabIndex = 7;
            this.descLbl.TabStop = true;
            this.descLbl.Text = "Description";
            this.descLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.descLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DescLbl_LinkClicked);
            // 
            // addModBtn
            // 
            this.addModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addModBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addModBtn.Location = new System.Drawing.Point(434, 491);
            this.addModBtn.Name = "addModBtn";
            this.addModBtn.Size = new System.Drawing.Size(99, 33);
            this.addModBtn.TabIndex = 7;
            this.addModBtn.Text = "+";
            this.addModBtn.UseVisualStyleBackColor = true;
            this.addModBtn.Click += new System.EventHandler(this.AddModBtn_Click);
            // 
            // removeModBtn
            // 
            this.removeModBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeModBtn.Enabled = false;
            this.removeModBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeModBtn.Location = new System.Drawing.Point(7, 491);
            this.removeModBtn.Name = "removeModBtn";
            this.removeModBtn.Size = new System.Drawing.Size(99, 33);
            this.removeModBtn.TabIndex = 5;
            this.removeModBtn.Text = "-";
            this.removeModBtn.UseVisualStyleBackColor = true;
            this.removeModBtn.Click += new System.EventHandler(this.RemoveModBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playBtn.Location = new System.Drawing.Point(434, 530);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(99, 43);
            this.playBtn.TabIndex = 4;
            this.playBtn.Text = "&Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.saveBtn.Location = new System.Drawing.Point(7, 530);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(99, 43);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainFrm
            // 
            this.AcceptButton = this.saveAndPlayBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 594);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.removeModBtn);
            this.Controls.Add(this.addModBtn);
            this.Controls.Add(this.saveAndPlayBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.descLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(559, 620);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SLW Mod Loader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.mainPnl.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.modPage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.settingsBottomPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView modsList;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader versionColumn;
        private System.Windows.Forms.ColumnHeader authorColumn;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Button saveAndPlayBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownAll;
        private System.Windows.Forms.Button moveUpAll;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage modPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.LinkLabel descLbl;
        private System.Windows.Forms.LinkLabel reportLbl;
        private System.Windows.Forms.Panel settingsBottomPnl;
        private System.Windows.Forms.Button addModBtn;
        private System.Windows.Forms.Button removeModBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.LinkLabel openModsDirLbl;
        private System.Windows.Forms.Label noModsFoundLbl;
        private System.Windows.Forms.Button modsDirBtn;
        private System.Windows.Forms.TextBox modsDirTxtbx;
        private System.Windows.Forms.Label modsDirLbl;
    }
}

