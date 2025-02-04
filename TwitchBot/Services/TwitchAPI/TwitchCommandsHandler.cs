using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Linq;
using TwitchBot.Services.Commands.Interfaces;
using TwitchBot.Services.TwitchAPI.Interfaces;
using TwitchBot.ViewModels;
using TwitchLib.Client.Events;
using TwitchLib.Communication.Interfaces;

namespace TwitchBot.Services.TwitchAPI
{
    public class TwitchCommandsHandler(IDeathCounter deathCounter, ITwitchSettingsService twitchSettingsService) : ITwitchCommandsHandler
    {

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


        private bool CheckIfUserHasPermissionToCounter(string username)
        {
            var usersWithPermissions = twitchSettingsService.CounterPermissionUsers();
            return usersWithPermissions.Contains(username);
        }
    }
}
