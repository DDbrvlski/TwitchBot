namespace TwitchBot.Services.TwitchAPI.Interfaces
{
    public interface ITwitchDataService
    {
        string BotClientID { get; set; }
        string BotToken { get; set; }
        string TwitchAccountName { get; set; }

        List<string> CounterPermissionUsers();
    }
}