using DuckyCSGOIntegration.Configuration.Layout.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckyCSGOIntegration.Configuration.Layout.Models
{
    public class LayoutModel
    {
        public Language Language { get; set; }
        public Dictionary<char, Devices.Device> Keys { get; set; }
        public int KeyCount => Keys.Count;
    }
}
