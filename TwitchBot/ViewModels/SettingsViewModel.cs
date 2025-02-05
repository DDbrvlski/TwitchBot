using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Settings.Interfaces;

namespace TwitchBot.ViewModels
{
    public class SettingsViewModel : BotFormViewModel
    {
        private IBotSettings botSettings;
        public SettingsViewModel(IBotSettings botSettings)
        {
            this.botSettings = botSettings;
        }

        public PanelSettingsDTO GetPanelSettings()
        {
            return botSettings.GetPanelData();
        }
        public void SavePanelData(PanelSettingsDTO panelSettings)
        {
            botSettings.SavePanelData(panelSettings);
        }
    }
}
