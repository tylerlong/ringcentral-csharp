namespace RingCentral
{
    public class SDK
    {
        private string AppKey { get; set; }
        private string AppSecret { get; set; }
        private string Server { get; set; }
        private string AppName { get; set; }
        private string AppVersion { get; set; }

        public const string VERSION = "1.0.0";

        protected Platform Platform;

        /// <summary>
        ///     Constructor that sets up RingCentralClient
        /// </summary>
        /// <param name="appKey">RingCentral Application Key</param>
        /// <param name="appSecret">RingCentral Application Secret</param>
        /// <param name="server">RingCentral Server</param>
        public SDK(string server, string appKey, string appSecret, string appName = "", string appVersion = "")
        {
            Server = server;
            AppKey = appKey;
            AppSecret = appSecret;
            AppName = appName;
            AppVersion = appVersion;

            Platform = new Platform(server, appKey, appSecret, appName, appVersion);
        }

        public Platform GetPlatform()
        {
            return Platform;
        }

    }
}