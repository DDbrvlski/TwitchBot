using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Linq;
using TwitchBot.Modules.Commands;
using TwitchBot.Modules.Commands.Interfaces;
using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services;
using TwitchBot.ViewModels;
using TwitchLib.Client.Events;
using TwitchLib.Communication.Interfaces;

namespace TwitchBot.Modules.TwitchAPI
{
    public class TwitchCommands(IDeathCounter deathCounter, ITwitchSettingsService twitchSettingsService) : ITwitchCommands
    {
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        private readonly string twitchChatCommandsFilePath = Path.Combine(projectDirectory, "Data", "TwitchChatCommands.settings");
        public void ProcessCommand(string commandText, OnMessageReceivedArgs e)
        {
            var username = e.ChatMessage.DisplayName;

            if (commandText.StartsWith(Data.TwitchChatCommands.Default.AddDeath.ToString()))
            {
                if (CheckIfUserHasPermissionToCounter(username))
                {
                    deathCounter.AddNewDeath();
                }
            }
            else if (commandText.StartsWith(Data.TwitchChatCommands.Default.StartBoss.ToString()))
            {
                if (CheckIfUserHasPermissionToCounter(username))
                {
                    int nickStartIndex = commandText.IndexOf(' ') + 1;
                    int nickEndIndex = commandText.IndexOf(' ', nickStartIndex);

                    string boss = commandText.Substring(nickStartIndex, nickEndIndex - nickStartIndex);

                    deathCounter.StartBoss(boss);
                }
            }
            else if (commandText.StartsWith(Data.TwitchChatCommands.Default.EndBoss.ToString()))
            {
                if (CheckIfUserHasPermissionToCounter(username))
                {
                    deathCounter.StopBoss();
                }
            }
            else if (commandText.StartsWith(Data.TwitchChatCommands.Default.PauseBoss.ToString()))
            {
                if (CheckIfUserHasPermissionToCounter(username))
                {
                    deathCounter.PauseBoss();
                }
            }
            else if (commandText.StartsWith(Data.TwitchChatCommands.Default.RemoveDeath.ToString()))
            {
                if (CheckIfUserHasPermissionToCounter(username))
                {
                    deathCounter.RemoveDeath();
                }
            }
        }
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

        private bool CheckIfUserHasPermissionToCounter(string username)
        {
            var usersWithPermissions = twitchSettingsService.CounterPermissionUsers();
            return usersWithPermissions.Contains(username);
        }
    }
}
