using TwitchBot.Services.Form;
using TwitchBot.Services.TwitchAPI.Interfaces;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Interfaces;

namespace TwitchBot.Services.TwitchAPI
{
    public class TwitchConnection : ITwitchConnection
    {
        private readonly ConnectionCredentials connectionCredentials;
        private readonly FormService formService;
        private readonly ITwitchCommandsHandler twitchCommands;
        private TwitchClient twitchClient;
        private bool isBotConnected = false;

        public TwitchConnection(ITwitchCommandsHandler twitchCommands, FormService formService)
        {
            var twitchAccountName = Properties.Settings.Default.TwitchAccountName;
            var twitchBotToken = Properties.Settings.Default.TwitchBotToken;
            if (!string.IsNullOrEmpty(twitchAccountName) && !string.IsNullOrEmpty(twitchBotToken))
            {
                connectionCredentials = new ConnectionCredentials(twitchAccountName, twitchBotToken);
            }

            this.formService = formService;
            this.twitchCommands = twitchCommands;
            twitchClient = new TwitchClient();
        }

        public void Connection(bool isLogging)
        {
            try
            {
                if (connectionCredentials != null && !string.IsNullOrEmpty(Properties.Settings.Default.TwitchAccountName))
                {

                    twitchClient.Initialize(connectionCredentials, Properties.Settings.Default.TwitchAccountName);

                    twitchClient.OnConnected += Client_OnConnected;

                    isBotConnected = true;

                    formService.UpdateLog("[Bot]: Connecting...");
                    if (isLogging)
                        twitchClient.OnLog += Client_OnLog;

                    //client.OnChatCommandReceived += Client_OnChatCommandReceived;
                    twitchClient.OnMessageReceived += Client_OnMessageReceived;

                    twitchClient.Connect();
                }
                else
                {
                    formService.UpdateLog("[Bot]: Error occured: possibility of missing data about twitch account and twitch bot.");
                }
            }
            catch (Exception ex)
            {
                formService.UpdateLog("[Bot]: Connecting failed, error occured: " + ex.Message);
            }
        }
        public void Disconnect()
        {
            try
            {
                if (isBotConnected)
                {
                    twitchClient.Disconnect();
                    isBotConnected = false;
                    formService.UpdateLog("[Bot]: Disconnected");
                }
            }
            catch (Exception ex)
            {
                formService.UpdateLog("[Bot]: Connecting failed, error occured: " + ex.Message);
            }
        }
        public bool IsBotConnected()
        {
            return isBotConnected;
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
