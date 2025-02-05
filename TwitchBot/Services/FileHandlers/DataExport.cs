using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Models.DTO;
using TwitchBot.Services.FileHandlers.Interfaces;

namespace TwitchBot.Services.FileHandlers
{
    public class DataExport : IDataExport
    {
        public void ExportBossStatsToTxt(string filePath, List<StatsDTO> stats)
        {
            try
            {
                
                File.AppendAllText(filePath, "Boss                |  Śmierci  | Czas"+Environment.NewLine);
                foreach (var item in stats)
                {
                    File.AppendAllText(filePath, FormatBossStats(item) + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private string FormatBossStats(StatsDTO stats)
        {
            string text = $"{stats.bossName}";
            int leng = 20 - stats.bossName.Length;
            for(int i = 0; i < leng; i++)
            {
                text += " ";
            }
            leng = 9 - stats.deathCounter.ToString().Length;
            text += $"|  {stats.deathCounter}";
            for(int i = 0; i < leng; i++)
            {
                text += " ";
            }
            text += $"| {stats.timer}";
            return text;
        }

    }
}
