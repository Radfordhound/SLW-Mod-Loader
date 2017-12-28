using System.Collections.Generic;
using System.IO;

namespace SLWModLoader
{
    public class SteamConfig
    {
        // Methods
        public static string GetProperty(
            Dictionary<string, object> containers, string name)
        {
            foreach (var value in containers)
            {
                if (value.Key == name)
                {
                    return value.Value as string;
                }
            }

            return null;
        }

        public static Dictionary<string, object> GetContainer(
            Dictionary<string, object> containers, string name)
        {
            foreach (var value in containers)
            {
                if (value.Key == name)
                {
                    return value.Value as Dictionary<string, object>;
                }
            }

            return null;
        }

        public static Dictionary<string, object> Load(string filePath)
        {
            using (var fs = File.OpenRead(filePath))
            {
                return Load(fs);
            }
        }

        public static Dictionary<string, object> Load(Stream fileStream)
        {
            var defs = new Dictionary<string, object>();
            var reader = new StreamReader(fileStream, true);

            string line, str = "", nm = "";
            bool doReadString = false;
            char c;

            ReadContainers(defs);
            return defs;

            // Sub-Methods
            void ReadContainers(Dictionary<string, object> parent)
            {
                Dictionary<string, object> container = null;
                string name = "";
                nm = str = "";

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    doReadString = false;

                    for (int i = 0; i < line.Length; ++i)
                    {
                        c = line[i];
                        if (c == '"')
                        {
                            doReadString = !doReadString;

                            if (doReadString)
                            {
                                continue;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(nm))
                                {
                                    nm = str;
                                    str = "";
                                }
                                else
                                {
                                    if (container != null)
                                        container.Add(nm, str);
                                    else
                                        parent.Add(nm, str);

                                    nm = str = "";
                                }
                            }
                        }
                        else if (c == '{')
                        {
                            if (container == null)
                            {
                                container = new Dictionary<string, object>();
                                name = nm;
                            }
                            else
                            {
                                var subContainer = new Dictionary<string, object>();
                                ReadContainers(subContainer);
                                container.Add(nm, subContainer);
                            }

                            nm = "";
                        }
                        else if (c == '}')
                        {
                            if (container != null)
                            {
                                parent.Add(name, container);
                                container = null;
                            }
                        }
                        else if (doReadString)
                        {
                            str += c;
                        }
                    }
                }
            }
        }
    }
}