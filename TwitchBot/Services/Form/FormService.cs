using TwitchBot.Services.Form.Interfaces;
using TwitchBot.Views;

namespace TwitchBot.Services.Form
{
    public class FormService(IBotForm botForm) : IFormService
    {
        public void UpdateLog(string log)
        {
            botForm.UpdateLog(log);
        }
    }
}
