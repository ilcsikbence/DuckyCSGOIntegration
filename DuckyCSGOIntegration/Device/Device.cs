using System;
using System.Collections.Generic;
using System.Text;

namespace DuckyCSGOIntegration.Device
{
    public interface Device
    {
        public string Name { get; set; }
        bool Initialize();
        bool Shutdown();
    }
}
