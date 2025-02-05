using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Models.DTO
{
    public class PanelSettingsDTO
    {
        public string twitchChannelName { get; set; }
        public string botClientID { get; set; }
        public string botToken { get; set; }
    }
}
