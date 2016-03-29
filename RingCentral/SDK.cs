﻿namespace RingCentral
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
        public SDK(string appKey, string appSecret, string server, string appName = "", string appVersion = "")
        {
            AppKey = appKey;
            AppSecret = appSecret;
            Server = server;
            AppName = appName;
            AppVersion = appVersion;

            Platform = new Platform(appKey, appSecret, server, appName, appVersion);
        }

        public Platform GetPlatform()
        {
            return Platform;
        }

    }
}