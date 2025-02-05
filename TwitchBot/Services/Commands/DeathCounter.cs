using System.Timers;
using TwitchBot.Enums;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Commands.Interfaces;

namespace TwitchBot.Services.Commands
{
    public class DeathCounter : IDeathCounter
    {
        private System.Timers.Timer timer;
        private int seconds;
        private int counter;
        public string bossName { get; set; }
        public int bossDeathCounter { get; set; }
        private BossStatusEnum bossStatus = BossStatusEnum.Nonactive;
        private bool isCounterStarted = false;
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        private readonly string deathCounterFilePath = Path.Combine(projectDirectory, "Files", "death_counter.txt");
        private readonly string overlayFilePath = Path.Combine(projectDirectory, "Files", "overlay.txt");
        private readonly string statsFilePath = Path.Combine(projectDirectory, "Files", "stats.txt");

        #region Regular Counter
        /// <summary>
        /// Returns number of deaths.
        /// </summary>
        /// <returns>int</returns>
        public int Counter()
        {
            return counter;
        }
        public void SetCounter(int count)
        {
            counter = count;
            SaveState();
        }
        public void SetBossCounter(int count)
        {
            if(bossStatus != BossStatusEnum.Nonactive)
            {
                bossDeathCounter = count;
                SaveState();
            }
        }
        /// <summary>
        /// Returns a bool value that represents counter status.
        /// </summary>
        /// <returns>bool</returns>
        public bool CounterStatus()
        {
            return isCounterStarted;
        }
        /// <summary>
        /// Starts a counter.
        /// </summary>
        public bool StartCounter()
        {
            try
            {
                isCounterStarted = true;
                CreateFileIfNotExists();
                LoadState();
                if (bossStatus == BossStatusEnum.Active)
                {
                    timer = new System.Timers.Timer(1000);
                    timer.Start();
                    InitializeTimer();
                }
                return true;
            }
            catch
            {
                isCounterStarted = false;
            }
            return false;
        }
        /// <summary>
        /// Stops counter.
        /// </summary>
        public bool StopCounter()
        {
            try
            {
                SaveState();
                StopTimer();
                isCounterStarted = false;
                return true;
            }
            catch
            {

            }
            return false;
        }
        /// <summary>
        /// Adds new death to the counter.
        /// </summary>
        public bool AddNewDeath()
        {
            try
            {
                if (isCounterStarted)
                {
                    counter++;
                    if (bossStatus == BossStatusEnum.Active)
                    {
                        bossDeathCounter++;
                    }
                    SaveState();
                    return true;
                }
            }
            catch { }
            return false;
        }
        /// <summary>
        /// Remove death from counter and boss counter if active.
        /// </summary>
        public bool RemoveDeath()
        {
            try
            {
                if (isCounterStarted && counter > 0)
                {
                    counter--;
                    if (bossStatus == BossStatusEnum.Active && bossDeathCounter > 0)
                    {
                        bossDeathCounter--;
                    }
                    SaveState();
                    return true;
                }
            }
            catch { }
            return false;
        }
        /// <summary>
        /// Resets all deaths.
        /// </summary>
        public bool ResetDeaths()
        {
            try
            {
                if (isCounterStarted)
                {
                    counter = 0;
                    bossName = "";
                    seconds = 0;
                    bossDeathCounter = 0;
                    SaveState();
                    StopTimer();
                    return true;
                }
            }
            catch { }
            return false;
        }
        /// <summary>
        /// Updates overlay file.
        /// </summary>
        private void UpdateOverlay()
        {
            string bossNameText = "";
            string bossDeathsText = "";
            string bossTimerText = "";
            if (bossName != null && bossName.Length > 0)
            {
                try
                {
                    bossNameText = $"Boss: {bossName}";
                    bossDeathsText = $"Śmierci: {bossDeathCounter}";
                    TimeSpan time = TimeSpan.FromSeconds(seconds);
                    string sTime = $"{(int)time.TotalHours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
                    bossTimerText = $"Czas: {sTime}";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            File.WriteAllLines(overlayFilePath, new[] { $"Śmierci: {counter}", "", bossNameText, bossDeathsText, bossTimerText });
        }
        /// <summary>
        /// Updates overlay file if boss counter is active.
        /// </summary>
        public void UpdateOverlayTimer()
        {
            if (bossStatus == BossStatusEnum.Active)
            {

                string bossNameText = "";
                string bossDeathsText = "";
                string bossTimerText = "";
                if (bossName != null && bossName.Length > 0)
                {
                    bossNameText = $"Boss: {bossName}";
                    bossDeathsText = $"Śmierci: {bossDeathCounter}";
                    TimeSpan time = TimeSpan.FromSeconds(seconds);
                    string sTime = $"{(int)time.TotalHours:D2}:{time.Minutes:D2}:{time.Seconds:D2}";
                    bossTimerText = $"Czas: {sTime}";
                }
                File.WriteAllLines(overlayFilePath, new[] { $"Śmierci: {counter}", "", bossNameText, bossDeathsText, bossTimerText });
            }
        }
        #endregion
        #region Boss Counter
        /// <summary>
        /// Returns boss status.
        /// </summary>
        /// <returns>BossStatusEnum</returns>
        public BossStatusEnum BossStatus()
        {
            return bossStatus;
        }
        /// <summary>
        /// Resume boss counter.
        /// </summary>
        public bool ResumeBossCounter()
        {
            try
            {
                if (bossStatus == BossStatusEnum.Paused)
                {
                    bossStatus = BossStatusEnum.Active;
                    timer = new System.Timers.Timer(1000);
                    timer.Start();
                    InitializeTimer();
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        /// <summary>
        /// Starts a boss counter.
        /// </summary>
        /// <param name="bossNameT">string</param>
        public bool StartBoss(string bossNameT)
        {
            if (isCounterStarted && bossStatus == BossStatusEnum.Nonactive)
            {
                bossStatus = BossStatusEnum.Active;
                bossName = bossNameT;
                bossDeathCounter = 0;
                timer = new System.Timers.Timer(1000);
                timer.Start();
                InitializeTimer();
                SaveState();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Pause boss counter.
        /// </summary>
        public bool PauseBoss()
        {
            if (isCounterStarted)
            {
                if (bossStatus == BossStatusEnum.Active)
                {
                    bossStatus = BossStatusEnum.Paused;
                    try
                    {
                        timer.Stop();
                        timer.Close();
                        return true;
                    }
                    catch
                    {

                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Stops boss counter.
        /// </summary>
        public bool StopBoss()
        {
            if (isCounterStarted && bossStatus == BossStatusEnum.Active)
            {
                SaveStats();
                bossStatus = BossStatusEnum.Nonactive;
                bossName = "";
                bossDeathCounter = 0;
                seconds = 0;
                SaveState();
                StopTimer();
                return true;
            }
            return false;
        }
        private bool StopTimer()
        {
            if (bossStatus == BossStatusEnum.Active)
            {
                try
                {
                    timer.Stop();
                    timer.Close();
                    return true;
                }
                catch
                {

                }
            }
            return false;
        }
        #endregion
        #region Stats
        public List<StatsDTO> GetStats()
        {
            var statList = new List<StatsDTO>();

            foreach (var line in File.ReadLines(statsFilePath))
            {
                var stats = line.Split('|');

                statList.Add(new StatsDTO
                {
                    bossName = stats[0],
                    deathCounter = int.Parse(stats[1]),
                    timer = TimeSpan.FromSeconds(int.Parse(stats[2])).TotalHours.ToString("00") + ":" + TimeSpan.FromSeconds(int.Parse(stats[2])).Minutes.ToString("00") + ":" + TimeSpan.FromSeconds(int.Parse(stats[2])).Seconds.ToString("00")
                });

            }

            return statList;
        }
        public bool AddNewBossStat(string bossName, int numberOfDeaths, string bossTime)
        {
            var time = bossTime.Split(':');

            int hours = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);
            int seconds = int.Parse(time[2]);

            
            if (minutes > 60 || seconds > 60 || time[1].Length > 2 || time[2].Length > 2)
            {
                return false;
            }

            //Konwersja godzin na sekundy
            if (hours > 0)
            {
                seconds += hours * 3600;
            }
            //Konwersja minut na sekundy
            if (minutes > 0)
            {
                seconds += minutes * 60;
            }

            SaveStats(bossName, numberOfDeaths, seconds);

            return true;
        }

        public void ResetStats()
        {
            File.WriteAllLines(deathCounterFilePath, new[] { "" });
        }

        public void RemoveBossStat(string bossName)
        {
            string[] lines = File.ReadAllLines(statsFilePath); // Wczytaj wszystkie linie z pliku
            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                if (!line.StartsWith(bossName))
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines(statsFilePath, updatedLines);
        }
        #endregion
        #region Functions
        /// <summary>
        /// Initialize a timer.
        /// </summary>
        public void InitializeTimer()
        {
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
        }
        /// <summary>
        /// Loads last saved counter.
        /// </summary>
        private void LoadState()
        {
            if (File.Exists(deathCounterFilePath))
            {
                string[] fileContent = File.ReadAllLines(deathCounterFilePath);
                int.TryParse(fileContent[0], out counter);
                bossName = fileContent.Length > 1 ? fileContent[1] : "";
                if (bossName.Length > 0)
                {
                    bossStatus = BossStatusEnum.Paused;
                    bossDeathCounter = fileContent.Length > 2 ? int.Parse(fileContent[2]) : 0;
                    seconds = int.Parse(fileContent[3]);

                }
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (bossStatus == BossStatusEnum.Active)
                seconds++;

            UpdateOverlayTimer();
        }

        /// <summary>
        /// Saves data.
        /// </summary>
        public void SaveData()
        {
            SaveState();
        }

        /// <summary>
        /// Saves state to the file and updates overlay.
        /// </summary>
        private void SaveState()
        {
            if (isCounterStarted)
            {
                try
                {
                    File.WriteAllLines(deathCounterFilePath, new[] { counter.ToString(), bossName, bossDeathCounter.ToString(), seconds.ToString() });
                    UpdateOverlay();
                }
                catch
                {
                    Console.WriteLine();
                }
            }

        }
        /// <summary>
        /// Saves stats to the file.
        /// </summary>
        private void SaveStats()
        {
            try
            {
                File.AppendAllText(statsFilePath, $"{bossName}|{bossDeathCounter.ToString()}|{seconds.ToString()}|" + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine();
            }
        }
        private void SaveStats(string bossName, int bossDeathCounter, int seconds)
        {
            try
            {
                File.AppendAllText(statsFilePath, $"{bossName}|{bossDeathCounter.ToString()}|{seconds.ToString()}|" + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Creates a file if not exists.
        /// </summary>
        private void CreateFileIfNotExists()
        {
            if (!File.Exists(deathCounterFilePath) || !File.Exists(overlayFilePath))
            {
                counter = 0;
                SaveState();
            }
        }
        /// <summary>
        /// Returns a file path to the files folder.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetFilePath(string fileName)
        {
            string rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files", fileName);
            return rootPath;
        }
        #endregion

    }
}
