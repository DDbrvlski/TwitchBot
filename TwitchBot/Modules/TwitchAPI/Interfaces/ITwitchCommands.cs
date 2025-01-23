using TwitchLib.Client.Events;

namespace TwitchBot.Modules.TwitchAPI.Interfaces
{
    public interface ITwitchCommands
    {
        void ProcessCommand(string commandText, OnMessageReceivedArgs e);
    }
}