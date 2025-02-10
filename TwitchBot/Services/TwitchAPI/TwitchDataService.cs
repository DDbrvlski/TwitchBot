using Newtonsoft.Json;
using System.Linq;
using TwitchBot.Models.DTO;
using TwitchBot.Services.FileHandlers;
using TwitchBot.Services.TwitchAPI.Interfaces;
using TwitchBot.ViewModels;

namespace TwitchBot.Services.TwitchAPI
{
    public class TwitchDataService : ITwitchDataService
    {
        private readonly string secretDataFilePath = Files.SecretDataFilePath;
        private AppSecretDataDTO appSecretData;
        public TwitchDataService()
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Odczytanie pliku JSON
                if (File.Exists(secretDataFilePath))
                {
                    var json = File.ReadAllText(secretDataFilePath);

                    // Deserializacja JSON do obiektu AppSecretData
                    appSecretData = JsonConvert.DeserializeObject<AppSecretDataDTO>(json);
                }
                else
                {
                    Console.WriteLine("Plik nie istnieje.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas odczytu pliku JSON: {ex.Message}");
            }
        }
        public string TwitchAccountName
        {
            get => appSecretData?.twitchData?.channelName ?? string.Empty;
            set
            {
                if (appSecretData != null && appSecretData.twitchData != null && !value.Equals(appSecretData.twitchData.channelName))
                {
                    appSecretData.twitchData.channelName = value;

                    SaveData();
                }
            }
        }
        public string BotToken
        {
            get => appSecretData?.botData?.token ?? string.Empty;
            set
            {
                if (appSecretData != null && appSecretData.botData != null && !value.Equals(appSecretData.botData.token))
                {
                    appSecretData.botData.token = value;

                    SaveData();
                }
            }
        }
        public string BotClientID
        {
            get => appSecretData?.botData?.clientID ?? string.Empty;
            set
            {
                if (appSecretData != null && appSecretData.botData != null && !value.Equals(appSecretData.botData.clientID))
                {
                    appSecretData.botData.clientID = value;

                    SaveData();
                }
            }
        }
        private void SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(appSecretData, Formatting.Indented);

                File.WriteAllText(secretDataFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas zapisu pliku JSON: {ex.Message}");
            }
        }

        public List<string> CounterPermissionUsers()
        {
            return Data.DeathCounterUsersPermissions.Default.UsersWithPermission.Split(Environment.NewLine).ToList();
        }
    }
}
