using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TwitchBot.Modules.Commands;
using TwitchBot.Modules.Commands.Interfaces;
using TwitchBot.Modules.TwitchAPI;
using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services;
using TwitchBot.Services.Form;
using TwitchBot.Services.Form.Interfaces;

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
                    services.AddTransient<ITwitchCommands, TwitchCommands>();
                    services.AddTransient<IFormService, FormService>();
                    services.AddTransient<ITwitchSettingsService, TwitchSettingsService>();

                    // Rejestracja BotForm
                    services.AddTransient<BotForm>(); // Rejestracja samego BotForm
                });
        }
    }
}
