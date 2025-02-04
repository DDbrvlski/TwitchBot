using TwitchBot.Enums;
using TwitchBot.Models.DTO;

namespace TwitchBot
{
    public interface IBotForm
    {
        void GetAllCommands();
        void UpdateLabel(string text, Color color, LabelTextEnum label);
    }
}