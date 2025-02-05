using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Enums;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Commands.Interfaces;
using TwitchBot.Services.FileHandlers.Interfaces;
using TwitchBot.Services.TwitchAPI;
using TwitchBot.Services.TwitchAPI.Interfaces;

namespace TwitchBot.ViewModels
{
    public class CounterViewModel : BotFormViewModel
    {
        private readonly IDeathCounter deathCounter;
        private readonly ITwitchCommands twitchCommands;
        private readonly ITwitchConnection twitchConnection;
        private readonly IDataExport dataExport;

        

        public CounterViewModel(IDeathCounter deathCounter, ITwitchCommands twitchCommands, ITwitchConnection twitchConnection, IDataExport dataExport)
        {
            this.deathCounter = deathCounter ?? throw new ArgumentNullException(nameof(deathCounter), "DeathCounter nie zostało wstrzyknięte.");
            this.twitchCommands = twitchCommands;
            this.twitchConnection = twitchConnection;
            this.dataExport = dataExport;
        }

        #region Counter
        public string CounterStatusText => deathCounter.CounterStatus() ? "Naliczanie AKTYWNE" : "Naliczanie NIEAKTYWNE";
        public string CurrentBossText => deathCounter.BossStatus() == BossStatusEnum.Active ? "Aktualny boss: " + deathCounter.bossName : "Aktualny boss: BRAK";
        public string BossStatusText => deathCounter.BossStatus() switch
        {
            BossStatusEnum.Active => "Status bossa: AKTYWNY",
            BossStatusEnum.Paused => "Status bossa: ZATRZYMANY",
            _ => "Status bossa: NIEAKTYWNY"
        };

        public IEnumerable<SettingDTO> Commands => twitchCommands.GetAllPossibleCommands();
        public IEnumerable<UserPermissions> UserPermissions => twitchCommands.GetAllUsersWithCounterPermissions();
        public IEnumerable<StatsDTO> Stats => deathCounter.GetStats();
        #endregion

        #region Counter Actions
        public void SetCounter(int count)
        {
            deathCounter.SetCounter(count);
        }
        public void SetBossCounter(int count)
        {
            deathCounter.SetBossCounter(count);
        }
        public void StartCounter()
        {
            if (deathCounter.StartCounter())
            {
                UpdateLog("Uruchomiono licznik.", LogTypeEnum.Counter);
                UpdateStatusLabel("Naliczanie AKTYWNE", Color.Green, LabelTextEnum.CounterStatus);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void StopCounter()
        {
            if (deathCounter.StopCounter())
            {
                UpdateLog("Zatrzymano licznik.", LogTypeEnum.Counter);
                UpdateStatusLabel("Naliczanie NIEAKTYWNE", Color.Red, LabelTextEnum.CounterStatus);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void AddNewDeath()
        {
            if (deathCounter.AddNewDeath())
            {
                UpdateLog("Dodano śmierć.", LogTypeEnum.Counter);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
        }

        public void RemoveDeath()
        {
            if (deathCounter.RemoveDeath())
            {
                UpdateLog("Usunięto śmierć.", LogTypeEnum.Counter);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void ResetDeaths()
        {
            if (deathCounter.ResetDeaths())
            {
                UpdateLog("Zresetowano licznik.", LogTypeEnum.Counter);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void StartBoss(string bossName)
        {
            if (deathCounter.StartBoss(bossName))
            {
                UpdateLog($"Rozpoczęto licznik bossa {bossName}.", LogTypeEnum.Counter);
                UpdateStatusLabel($"Aktualny boss: {bossName}", Color.Green, LabelTextEnum.CurrentBoss);
                UpdateStatusLabel($"Status bossa: AKTYWNY", Color.Green, LabelTextEnum.BossStatus);
            }
            else
            {
                UpdateLog($"Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void ResumeBoss()
        {
            if (deathCounter.ResumeBossCounter())
            {
                UpdateLog("Wznowiono licznik bossa.", LogTypeEnum.Counter);
                UpdateStatusLabel($"Aktualny boss: {deathCounter.bossName}", Color.Green, LabelTextEnum.CurrentBoss);
                UpdateStatusLabel($"Status bossa: AKTYWNY", Color.Green, LabelTextEnum.BossStatus);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
        }

        public void PauseBoss()
        {
            if (deathCounter.PauseBoss())
            {
                UpdateLog("Zatrzymano licznik bossa.", LogTypeEnum.Counter);
                UpdateStatusLabel($"Aktualny boss: {deathCounter.bossName}", Color.Orange, LabelTextEnum.CurrentBoss);
                UpdateStatusLabel($"Status bossa: ZATRZYMANY", Color.Orange, LabelTextEnum.BossStatus);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }

        public void EndBoss()
        {
            if (deathCounter.StopBoss())
            {
                UpdateLog("Zakończono licznik bossa.", LogTypeEnum.Counter);
                UpdateStatusLabel("Aktualny boss: BRAK", Color.Red, LabelTextEnum.CurrentBoss);
                UpdateStatusLabel("Status bossa: NIEAKTYWNY", Color.Red, LabelTextEnum.BossStatus);
            }
            else
            {
                UpdateLog("Wystąpił błąd.", LogTypeEnum.Counter);
            }
            
        }
        #endregion

        #region Connection
        public void TurnOnBot()
        {
            twitchConnection.Connection(true);
            if (twitchConnection.IsBotConnected())
            {
                UpdateLog("Bot jest ONLINE", LogTypeEnum.Application);
                UpdateStatusLabel("ONLINE", Color.Green, LabelTextEnum.BotStatus);
            }
        }

        public void TurnOffBot()
        {
            twitchConnection.Disconnect();
            if (!twitchConnection.IsBotConnected())
            {
                UpdateLog("Bot jest OFFLINE", LogTypeEnum.Application);
                UpdateStatusLabel("OFFLINE", Color.Red, LabelTextEnum.BotStatus);
            }
        }
        #endregion

        #region Data
        public void LoadAllData()
        {
            UpdateLog("Załadowano wszystkie dane.", LogTypeEnum.Application);
        }
        #endregion

        public void AddNewBossStat(string bossName, int numberOfDeaths, string bossTime)
        {
            deathCounter.AddNewBossStat(bossName, numberOfDeaths, bossTime);
        }
        public void RemoveBossStat(string bossName)
        {
            deathCounter.RemoveBossStat(bossName);
        }
        public void ExportBossStats(string filePath)
        {
            dataExport.ExportBossStatsToTxt(filePath, deathCounter.GetStats());
        }
    }


}
