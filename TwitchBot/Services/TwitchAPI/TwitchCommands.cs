using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TwitchBot.Models.DTO;
using TwitchBot.Services.FileHandlers;
using TwitchBot.Services.TwitchAPI.Interfaces;

namespace TwitchBot.Services.TwitchAPI
{
    public class TwitchCommands(ITwitchDataService twitchSettingsService) : ITwitchCommands
    {
        private readonly string twitchChatCommandsFilePath = Files.CommandsFilePath;
        private readonly string twitchCommandUserPermissionsFilePath = Files.CommandUserPermissionsFilePath;
        public List<CommandDTO> GetAllPossibleCommands()
        {
            try
            {
                // Odczytanie pliku JSON
                if (File.Exists(twitchChatCommandsFilePath))
                {
                    var json = File.ReadAllText(twitchChatCommandsFilePath);
                    var commandDict = JsonConvert.DeserializeObject<Dictionary<string, CommandDTO>>(json);

                    // Jeśli chcesz uzyskać listę obiektów CommandDTO
                    List<CommandDTO> commandList = new List<CommandDTO>(commandDict.Values);

                    return commandList;
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
            return new List<CommandDTO>();
        }

        public UserPermissionsDTO GetAllUsersWithCounterPermissions()
        {
            try
            {
                // Odczytanie pliku JSON
                if (File.Exists(twitchCommandUserPermissionsFilePath))
                {
                    var json = File.ReadAllText(twitchCommandUserPermissionsFilePath);
                    var userPermissions = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<string>>>>(json);

                    // Mapping categories to the custom structure
                    var result = new UserPermissionsDTO
                    {
                        Categories = userPermissions["categories"]
                    };
                    return result;
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
            return new UserPermissionsDTO();
        }
    }
}
