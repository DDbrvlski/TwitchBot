using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwitchBot.Services.Commands;
using TwitchBot.Services.Commands.Interfaces;
using TwitchBot.Services.FileHandlers;
using TwitchBot.Services.FileHandlers.Interfaces;
using TwitchBot.Services.Form;
using TwitchBot.Services.Settings;
using TwitchBot.Services.Settings.Interfaces;
using TwitchBot.Services.TwitchAPI;
using TwitchBot.Services.TwitchAPI.Interfaces;
using TwitchBot.ViewModels;

namespace TwitchBot
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Tworzenie hosta i uzyskiwanie kontenera DI
            var host = CreateHostBuilder().Build();


            // SetCompatibleTextRenderingDefault musi być wywołane przed stworzeniem jakiegokolwiek okna
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Uzyskiwanie instancji BotForm z kontenera DI
            var botForm = host.Services.GetRequiredService<BotForm>(); // Ustawienie domyślnego renderowania tekstu
            Application.Run(botForm);  // Uruchomienie aplikacji z formularzem
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Rejestracja usług i zależności
                    services.AddTransient<IDeathCounter, DeathCounter>(); // Rejestracja DeathCounter
                    services.AddTransient<ITwitchCommandsHandler, TwitchCommandsHandler>();
                    services.AddTransient<ITwitchCommands, TwitchCommands>();
                    services.AddTransient<ITwitchConnection, TwitchConnection>();
                    services.AddSingleton<FormService>();
                    services.AddSingleton<CounterViewModel>();
                    services.AddSingleton<SettingsViewModel>();
                    services.AddTransient<IBotForm, BotForm>();
                    services.AddTransient<IDataExport, DataExport>();
                    services.AddTransient<IBotSettings, BotSettings>();
                    services.AddTransient<ITwitchSettingsService, TwitchSettingsService>();

                    // Rejestracja BotForm
                    services.AddTransient<BotForm>(); // Rejestracja samego BotForm
                });
        }
    }
}
