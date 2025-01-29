using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services;
using TwitchBot.ViewModels;

namespace TwitchBot.Modules.TwitchAPI
{
    public class TwitchCommands(ITwitchSettingsService twitchSettingsService) : ITwitchCommands
    {
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        private readonly string twitchChatCommandsFilePath = Path.Combine(projectDirectory, "Data", "TwitchChatCommands.settings");
        public List<SettingViewModel> GetAllPossibleCommands()
        {
            var commandStart = Data.TwitchChatCommands.Default.CommandStart.ToString();

            // Wczytanie pliku XML
            XElement xElement = XElement.Load(twitchChatCommandsFilePath);

            // Przygotowanie słownika na komendy
            var commands = new List<SettingViewModel>();

            // Iteracja po elementach <Setting> i wyciąganie komend i ich wartości
            foreach (var setting in xElement.Descendants("{http://schemas.microsoft.com/VisualStudio/2004/01/settings}Setting"))
            {
                string name = setting.Attribute("Name")?.Value;
                string value = setting.Element("{http://schemas.microsoft.com/VisualStudio/2004/01/settings}Value")?.Value;

                if (name != null && value != null)
                {
                    commands.Add(new SettingViewModel() { Key = name, Value = value });
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
