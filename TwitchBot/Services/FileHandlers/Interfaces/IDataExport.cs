using TwitchBot.Models.DTO;

namespace TwitchBot.Services.FileHandlers.Interfaces
{
    public interface IDataExport
    {
        void ExportBossStatsToTxt(string filePath, List<StatsDTO> stats);
    }
}