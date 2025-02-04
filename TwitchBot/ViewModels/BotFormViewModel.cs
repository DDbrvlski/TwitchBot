using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Enums;
using TwitchBot.Models.DTO;

namespace TwitchBot.ViewModels
{
    public class BotFormViewModel
    {
        public event Action<string, LogTypeEnum> UpdateLogTextBox;
        public event Action<string, Color, LabelTextEnum> UpdateLabel;
       
        protected void UpdateLog(string logMessage, LogTypeEnum logType) =>
            UpdateLogTextBox?.Invoke(logMessage, logType);
        protected void UpdateStatusLabel(string logMessage, Color color, LabelTextEnum label) =>
            UpdateLabel?.Invoke(logMessage, color, label);
    }
}
