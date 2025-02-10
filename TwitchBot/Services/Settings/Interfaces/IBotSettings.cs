using TwitchBot.Models.DTO;

namespace TwitchBot.Services.Settings.Interfaces
{
    public interface IBotSettings
    {
        void SavePanelData(PanelDataDTO panelSettings);
        PanelDataDTO GetPanelData();
    }
}