using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Models.DTO
{
    public class AppSecretDataDTO
    {
        public TwitchDataDTO twitchData { get; set; }
        public BotDataDTO botData { get; set; }
    }
}
