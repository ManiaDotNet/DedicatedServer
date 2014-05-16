using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer
{
    public class ServerControllerConfig
    {
        public string Login { get; private set; }

        public string Password { get; private set; }

        public ServerControllerConfig(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}