using TwitchBot.Enums;
using TwitchBot.ViewModels;

namespace TwitchBot.Modules.Commands.Interfaces
{
    public interface IDeathCounter
    {
        int bossDeathCounter { get; set; }
        string bossName { get; set; }

        void AddNewDeath();
        BossStatusEnum BossStatus();
        int Counter();
        bool CounterStatus();
        List<StatsViewModel> GetStats();
        void InitializeTimer();
        void PauseBoss();
        void RemoveDeath();
        void ResetDeaths();
        void ResetStats();
        void ResumeBossCounter();
        void SaveData();
        void StartBoss(string bossNameT);
        void StartCounter();
        void StopBoss();
        void StopCounter();
        void UpdateOverlayTimer();
    }
}