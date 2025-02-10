using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Models.DTO
{
    public class UserPermissionsDTO
    {
        public Dictionary<string, List<string>> Categories { get; set; }
    }
}
