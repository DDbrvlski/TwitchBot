using System.Linq;
using TwitchBot.ViewModels;

namespace TwitchBot.Services
{
    public class TwitchSettingsService : ITwitchSettingsService
    {
        public string TwitchAccountName()
        {
            return Properties.Settings.Default.TwitchAccountName;
        }
        public void TwitchAccountName(string name)
        {
            if (name.Length > 0)
            {
                Properties.Settings.Default.TwitchAccountName = name;
                Properties.Settings.Default.Save();
            }
        }
        public string TwitchBotToken()
        {
            return Properties.Settings.Default.TwitchBotToken;
        }
        public void TwitchBotToken(string token)
        {
            if (token.Length > 0)
            {
                Properties.Settings.Default.TwitchBotToken = token;
                Properties.Settings.Default.Save();
            }
        }
        public string TwitchBotClientID()
        {
            return Properties.Settings.Default.TwitchBotCliendID;
        }
        public void TwitchBotClientID(string id)
        {
            if (id.Length > 0)
            {
                Properties.Settings.Default.TwitchBotCliendID = id;
                Properties.Settings.Default.Save();
            }
        }

        public List<string> CounterPermissionUsers()
        {
            return Data.DeathCounterUsersPermissions.Default.UsersWithPermission.Split(Environment.NewLine).ToList();
        }
    }
}
