using DuckyCSGOIntegration.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuckyCSGOIntegration
{
    public partial class Events
    {
        public static void RoundBegin(CSGSI.Events.RoundBeginEventArgs e)
        {
            var config = ConfigurationManager.Configuration;
        }
    }
}
