using TwitchBot.Models.DTO;

namespace TwitchBot.Services.Settings.Interfaces
{
    public interface IBotSettings
    {
        void SavePanelData(PanelSettingsDTO panelSettings);
        PanelSettingsDTO GetPanelData();
    }
}