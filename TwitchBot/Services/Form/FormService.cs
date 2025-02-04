
namespace TwitchBot.Services.Form
{
    public class FormService
    {
        // Zdarzenie, które informuje o zmianie w TextBoxie
        public event Action<string> UpdateLogTextBox;

        // Metoda do wywołania zdarzenia
        public void UpdateLog(string log)
        {
            UpdateLogTextBox?.Invoke(log);
        }
    }
}
