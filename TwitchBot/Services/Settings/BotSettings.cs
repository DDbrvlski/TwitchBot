using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Settings.Interfaces;

namespace TwitchBot.Services.Settings
{
    public class BotSettings : IBotSettings
    {
        public void SavePanelData(PanelDataDTO panelSettings)
        {
            Properties.Settings.Default.TwitchAccountName = panelSettings.twitchChannelName;
            Properties.Settings.Default.TwitchBotCliendID = panelSettings.botClientID;
            Properties.Settings.Default.TwitchBotToken = panelSettings.botToken;

            Properties.Settings.Default.Save();
        }

        public PanelDataDTO GetPanelData()
        {
            return new PanelDataDTO
            {
                twitchChannelName = Properties.Settings.Default.TwitchAccountName,
                botClientID = Properties.Settings.Default.TwitchBotCliendID,
                botToken = Properties.Settings.Default.TwitchBotToken
            };
        }
    }
}
