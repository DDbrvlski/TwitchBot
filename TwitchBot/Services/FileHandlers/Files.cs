using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.Services.FileHandlers
{
    public static class Files
    {
        private static string projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        public static string SecretDataFilePath => Path.Combine(projectDirectory, "Data", "AppSecretData.json");
        public static string CommandsFilePath => Path.Combine(projectDirectory, "Data", "AppCommands.json");
        public static string CommandUserPermissionsFilePath => Path.Combine(projectDirectory, "Data", "AppCommandUserPermissions.json");
        public static string DeathCounterFilePath => Path.Combine(projectDirectory, "Files", "death_counter.txt");
        public static string OverlayFilePath => Path.Combine(projectDirectory, "Files", "overlay.txt");
        public static string StatsFilePath => Path.Combine(projectDirectory, "Files", "stats.txt");

    }
}
