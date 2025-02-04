using TwitchBot.Models.DTO;

namespace TwitchBot.Services.TwitchAPI.Interfaces
{
    public interface ITwitchCommands
    {
        List<SettingDTO> GetAllPossibleCommands();
        List<UserPermissions> GetAllUsersWithCounterPermissions();
    }
}