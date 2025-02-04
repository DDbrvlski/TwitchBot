namespace TwitchBot.Services.TwitchAPI.Interfaces
{
    public interface ITwitchSettingsService
    {
        List<string> CounterPermissionUsers();
        string TwitchAccountName();
        void TwitchAccountName(string name);
        string TwitchBotClientID();
        void TwitchBotClientID(string id);
        string TwitchBotToken();
        void TwitchBotToken(string token);
    }
}