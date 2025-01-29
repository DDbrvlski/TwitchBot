using TwitchBot.ViewModels;

namespace TwitchBot.Modules.TwitchAPI.Interfaces
{
    public interface ITwitchCommands
    {
        List<SettingViewModel> GetAllPossibleCommands();
        List<UserPermissions> GetAllUsersWithCounterPermissions();
    }
}