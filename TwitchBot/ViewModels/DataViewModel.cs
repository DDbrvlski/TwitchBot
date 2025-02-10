using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Settings.Interfaces;
using TwitchBot.Services.TwitchAPI.Interfaces;

namespace TwitchBot.ViewModels
{
    public class DataViewModel : BotFormViewModel
    {
        private ITwitchDataService twitchDataService;
        public DataViewModel(ITwitchDataService twitchDataService)
        {
            this.twitchDataService = twitchDataService;
        }

        public PanelDataDTO GetPanelSettings()
        {
            PanelDataDTO panelData = new PanelDataDTO()
            {
                twitchChannelName = twitchDataService.TwitchAccountName,
                botClientID = twitchDataService.BotClientID,
                botToken = twitchDataService.BotToken
            };

            return panelData;
        }
        public void SavePanelData(PanelDataDTO panelSettings)
        {
            twitchDataService.TwitchAccountName = panelSettings.twitchChannelName;
            twitchDataService.BotClientID = panelSettings.botClientID;
            twitchDataService.BotToken = panelSettings.botToken;
        }
    }
}
