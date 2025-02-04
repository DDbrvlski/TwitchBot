using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TwitchBot.Models.DTO;
using TwitchBot.Services.TwitchAPI.Interfaces;

namespace TwitchBot.Services.TwitchAPI
{
    public class TwitchCommands(ITwitchSettingsService twitchSettingsService) : ITwitchCommands
    {
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        private readonly string twitchChatCommandsFilePath = Path.Combine(projectDirectory, "Data", "TwitchChatCommands.settings");
        public List<SettingDTO> GetAllPossibleCommands()
        {
            var commandStart = Data.TwitchChatCommands.Default.CommandStart.ToString();

            // Wczytanie pliku XML
            XElement xElement = XElement.Load(twitchChatCommandsFilePath);

            // Przygotowanie słownika na komendy
            var commands = new List<SettingDTO>();

            // Iteracja po elementach <Setting> i wyciąganie komend i ich wartości
            foreach (var setting in xElement.Descendants("{http://schemas.microsoft.com/VisualStudio/2004/01/settings}Setting"))
            {
                string name = setting.Attribute("Name")?.Value;
                string value = setting.Element("{http://schemas.microsoft.com/VisualStudio/2004/01/settings}Value")?.Value;

                if (name != null && value != null)
                {
                    commands.Add(new SettingDTO() { Key = name, Value = value });
                }
            }

            return commands;
        }

        public List<UserPermissions> GetAllUsersWithCounterPermissions()
        {
            return twitchSettingsService.CounterPermissionUsers().Select(x => new UserPermissions()
            {
                UserName = x
            }).ToList();
        }
    }
}
