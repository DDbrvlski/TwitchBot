using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services.Form.Interfaces;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace TwitchBot.Modules.TwitchAPI
{
    public class TwitchConnection(ITwitchCommands twitchCommands, BotForm botForm, IFormService formService)
    {
        private readonly ConnectionCredentials connectionCredentials = new ConnectionCredentials(Properties.Settings.Default.TwitchAccountName, Properties.Settings.Default.TwitchBotToken);
        private TwitchClient twitchClient;
        private bool isBotConnected;


        public async Task Connection(bool isLogging)
        {
            twitchClient = new TwitchClient();
            twitchClient.Initialize(connectionCredentials, Properties.Settings.Default.TwitchAccountName);

            twitchClient.OnConnected += Client_OnConnected;

            isBotConnected = true;

            botForm.UpdateLog("[Bot]: Connecting...");
            if (isLogging)
                twitchClient.OnLog += Client_OnLog;

            //client.OnChatCommandReceived += Client_OnChatCommandReceived;
            twitchClient.OnMessageReceived += Client_OnMessageReceived;

            twitchClient.Connect();
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            formService.UpdateLog("[Bot]: Connected");
        }
        private void Client_OnLog(object sender, OnLogArgs e)
        {
            string logMessage = e.Data;

            formService.UpdateLog(logMessage);
        }
        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            var message = e.ChatMessage.Message;
            var username = e.ChatMessage.DisplayName;

            formService.UpdateLog($"[Bot]: Message received: {message} from {username}");

            if (message.StartsWith(Data.TwitchChatCommands.Default.CommandStart.ToString()))
            {
                var commandText = message.Substring(1); // Remove CommandStart from text
                formService.UpdateLog($"[Bot]: Command detected: {commandText}");
                twitchCommands.ProcessCommand(commandText.ToLower(), e);
            }
        }
    }
}
