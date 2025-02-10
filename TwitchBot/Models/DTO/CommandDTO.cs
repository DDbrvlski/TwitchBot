using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Models.DTO
{
    public class CommandDTO
    {
        public string key { get; set; }
        public string category { get; set; }
        public string description_pl { get; set; }
        public string description_eng { get; set; }
    }
}
