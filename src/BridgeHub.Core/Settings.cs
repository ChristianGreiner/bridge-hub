using IniParser;
using IniParser.Model;
using System.IO;

namespace BridgeHub.Core
{
    public sealed class Settings
    {
        public const string FileName = "Settings.ini";

        public string BridgeServer { get; set; } = "localhost/api/devies";

        public int UpdateInterval { get; set; } = 300;

        private FileIniDataParser parser;
        private static Settings instance = null;
        private static readonly object padlock = new object();

        private Settings()
        {
            this.parser = new FileIniDataParser();
        }

        public static Settings Instance
        {
            get
            {
                lock (padlock)
                {
                    return instance ?? (instance = new Settings());
                }
            }
        }

        public void Load()
        {
            if (File.Exists(Settings.FileName))
            {
                IniData data = this.parser.ReadFile(Settings.FileName);

                if (data["General"]["BridgeServer"] != null)
                    this.BridgeServer = data["General"]["BridgeServer"];

                if (data["General"]["UpdateInterval"] != null)
                    this.UpdateInterval = int.Parse(data["General"]["UpdateInterval"]);
            }
            else
            {
                File.Create(Settings.FileName).Dispose();
                Save();
            }
        }

        public void Save()
        {
            IniData data = this.parser.ReadFile(Settings.FileName);

            data["General"]["BridgeServer"] = this.BridgeServer;
            data["General"]["UpdateInterval"] = this.UpdateInterval.ToString();

            parser.WriteFile(FileName, data);
        }
    }
}