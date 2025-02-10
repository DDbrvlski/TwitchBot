using TwitchBot.Models.DTO;

namespace TwitchBot.Services.TwitchAPI.Interfaces
{
    public interface ITwitchCommands
    {
        List<CommandDTO> GetAllPossibleCommands();
        UserPermissionsDTO GetAllUsersWithCounterPermissions();
    }
}