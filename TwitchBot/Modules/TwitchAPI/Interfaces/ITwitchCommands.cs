using TwitchBot.ViewModels;
using TwitchLib.Client.Events;

namespace TwitchBot.Modules.TwitchAPI.Interfaces
{
    public interface ITwitchCommands
    {
        List<SettingViewModel> GetAllPossibleCommands();
        List<UserPermissions> GetAllUsersWithCounterPermissions();
        void ProcessCommand(string commandText, OnMessageReceivedArgs e);
    }
}