using TwitchBot.Enums;
using TwitchBot.Models.DTO;

namespace TwitchBot.Services.Commands.Interfaces
{
    public interface IDeathCounter
    {
        int bossDeathCounter { get; set; }
        string bossName { get; set; }

        event Action<string, LogTypeEnum> UpdateLogTextBoxDebug;

        bool AddNewBossStat(string bossName, int numberOfDeaths, string bossTime);
        bool AddNewDeath();
        BossStatusEnum BossStatus();
        void RemoveBossStat(string bossName);
        int Counter();
        bool CounterStatus();
        List<StatsDTO> GetStats();
        void InitializeTimer();
        bool PauseBoss();
        bool RemoveDeath();
        bool ResetDeaths();
        void ResetStats();
        bool ResumeBossCounter();
        void SaveData();
        void SetBossCounter(int count);
        void SetCounter(int count);
        bool StartBoss(string bossNameT);
        bool StartCounter();
        bool StopBoss();
        bool StopCounter();
        void UpdateOverlayTimer();
    }
}