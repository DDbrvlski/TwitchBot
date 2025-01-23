using Newtonsoft.Json.Linq;
using TwitchBot.Modules.Commands;
using TwitchBot.Modules.Commands.Interfaces;
using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services;
using TwitchLib.Client.Events;
using TwitchLib.Communication.Interfaces;

namespace TwitchBot.Modules.TwitchAPI
{
    public class TwitchCommands(IDeathCounter deathCounter, ITwitchSettingsService twitchSettingsService) : ITwitchCommands
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
                    //Podzielić tekst i wyciągnąć bossa
                    deathCounter.StartBoss("test");
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
        private bool CheckIfUserHasPermissionToCounter(string username) {
            twitchSettingsService.CounterPermissionUsers();
            //var usersWithPermissions = settingsService5.CounterPermissionUsers();
            //return usersWithPermissions.Contains(username);
            return false;
        }
    }
}
