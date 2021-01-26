using DuckyCSGOIntegration.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckyCSGOIntegration
{
    public partial class Events
    {
        public static void RoundEnd(CSGSI.Events.RoundEndEventArgs e)
        {
            var config = ConfigurationManager.Configuration;
        }
    }
}
