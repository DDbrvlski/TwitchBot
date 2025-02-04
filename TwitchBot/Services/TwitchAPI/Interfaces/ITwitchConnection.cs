namespace TwitchBot.Services.TwitchAPI.Interfaces
{
    public interface ITwitchConnection
    {
        void Connection(bool isLogging);
        void Disconnect();
        bool IsBotConnected();
    }
}