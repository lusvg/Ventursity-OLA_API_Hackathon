using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.Utility
{
    public class Settings
    {
        private static AppSettings currentSettings = Production;
        public static AppSettings CurrentSettings
        {
            get
            {
                return currentSettings;
            }
        }

        private static AppSettings QAServer
        {
            get
            {
                return new AppSettings
                {
                    Server = new ServerSettings()
                    {
                        DefaultServerIP = "http://sandbox-­t.olacabs.com",
                        DefaultHeaders = DefaultHeaders
                    },
                    Version = "1.0.0.1",
                    AppName = "OlaAPIHackathon",
                    Map = new MapSettings()
                    {
                        EnableMapRegistration = true,
                        //ApplicationId = "0681cd7d-c824-4e1d-b099-35234a6235b4",
                        AuthenticationKey = "Aqn7OafrH3LDlnZMJfV4vyyUGBEM_NO93OtUq3m4Ebtkzgkyzz1G5j8YAi5UT0_j",
                    }
                };
            }
        }



        private static AppSettings Production
        {
            get
            {
                return new AppSettings
                {
                    Server = new ServerSettings()
                    {
                        DefaultServerIP = "http://sandbox-t.olacabs.com",
                        DefaultHeaders = DefaultHeaders
                    },
                    Version = "1.0.0.1",
                    AppName = "OlaAPIHackathon",
                    Map = new MapSettings()
                    {
                        EnableMapRegistration = true,
                        //ApplicationId = "0681cd7d-c824-4e1d-b099-35234a6235b4",
                        AuthenticationKey = "Aqn7OafrH3LDlnZMJfV4vyyUGBEM_NO93OtUq3m4Ebtkzgkyzz1G5j8YAi5UT0_j",
                    }
                };
            }
        }

        public static string GetAPIUri(string servicePath)
        {
            Uri apiUri;
            apiUri = new Uri(new Uri(currentSettings.Server.DefaultServerIP), servicePath);
            return apiUri.AbsoluteUri;
        }

        public class AppSettings
        {
            public AppSettings()
            {
                Server = new ServerSettings();
                Map = new MapSettings();
            }
            public ServerSettings Server { get; internal set; }
            public string Version { get; set; }
            public MapSettings Map { get; set; }
            public string AppName { get; set; }

        }

        public class ServerSettings
        {
            public string ServerIP { get; internal set; }
            public string DefaultServerIP { get; internal set; }
            public Dictionary<string, string> DefaultHeaders { get; internal set; }
        }

        public class MapSettings
        {
            public bool EnableMapRegistration { get; set; }
            public string ApplicationId { get; set; }
            public string AuthenticationKey { get; set; }
        }

        private static Dictionary<string, string> DefaultHeaders
        {
            get
            {
                Dictionary<string, string> customHeaders = new Dictionary<string, string>();
                customHeaders.Add("Authorization", "Bearer d2fcdb3a3f674fad8fe6c0016416e218");
                customHeaders.Add("X-APP-Token", GeneralConstants.XAPPToken);
                return customHeaders;
            }
        }
    }
}
