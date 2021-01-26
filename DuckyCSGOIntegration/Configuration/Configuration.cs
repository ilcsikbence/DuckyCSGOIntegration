using System;
using System.Collections.Generic;
using System.Text;

namespace DuckyCSGOIntegration.Configuration
{
    public class Configuration
    {
        public string Uri { get; }
        public int Port { get; }
        public Configuration()
        {
            Uri = "http://localhost:3000/";
            Port = 3000;
        }
    }
}
