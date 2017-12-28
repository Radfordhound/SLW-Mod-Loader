using System.Collections.Generic;
using System.IO;

namespace SLWModLoader
{
    public class INI
    {
        // Methods
        public static Dictionary<string, object> Load(string filePath)
        {
            using (var fs = File.OpenRead(filePath))
            {
                return Load(fs);
            }
        }

        public static Dictionary<string, object> Load(Stream fileStream)
        {
            Dictionary<string, string> container = null;
            var ini = new Dictionary<string, object>();
            var reader = new StreamReader(fileStream, true);
            string line, name = "", key, value;
            int equalsIndex;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line.Length < 1)
                    continue;

                if (line[0] == '[')
                {
                    AddContainer();
                    name = line.Substring(1, line.LastIndexOf(']')-1);
                    container = new Dictionary<string, string>();
                }
                else
                {
                    equalsIndex = line.IndexOf('=');
                    if (equalsIndex < 0)
                        continue;

                    key = line.Substring(0, equalsIndex);
                    value = line.Substring(equalsIndex + 1);

                    if (container == null)
                        ini.Add(key, value);
                    else
                        container.Add(key, value);
                }
            }

            AddContainer();
            return ini;

            // Sub-Methods
            void AddContainer()
            {
                if (container != null)
                    ini.Add(name, container);
            }
        }
    }
}