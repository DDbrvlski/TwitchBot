using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchBot.Enums;

namespace TwitchBot.ViewModels
{
    public static class ShortcutsViewModel
    {
       
        public static void SetShortcut(ShortcutsEnum shortcut, Keys key)
        {
            var shortcuts = Data.Shortcuts.Default;

            string shortcutString = key.ToString();
            switch(shortcut)
            {
                case ShortcutsEnum.StartCounter:
                    shortcuts.StartCounter = shortcutString;
                    break;
                case ShortcutsEnum.StopCounter:
                    shortcuts.StopCounter = shortcutString;
                    break;
                case ShortcutsEnum.AddDeath:
                    shortcuts.AddDeath = shortcutString;
                    break;
                case ShortcutsEnum.RemoveDeath:
                    shortcuts.RemoveDeath = shortcutString;
                    break;
                case ShortcutsEnum.PauseBoss:
                    shortcuts.PauseBoss = shortcutString;
                    break;
                case ShortcutsEnum.ResumeBoss:
                    shortcuts.ResumeBoss = shortcutString;
                    break;
                case ShortcutsEnum.StopBoss:
                    shortcuts.StopBoss = shortcutString;
                    break;
                default:
                    
                    break;
            }

            Data.Shortcuts.Default.Save();
        }
        public static Dictionary<ShortcutsEnum, Keys> GetAllShortcuts()
        {
            var savedShortcuts = Data.Shortcuts.Default;
            var shortcuts = new Dictionary<ShortcutsEnum, Keys>();

            if (Enum.TryParse(savedShortcuts.StartCounter, out Keys startCounterKey))
            {
                shortcuts.Add(ShortcutsEnum.StartCounter, startCounterKey);
            }

            if (Enum.TryParse(savedShortcuts.StopCounter, out Keys stopCounterKey))
            {
                shortcuts.Add(ShortcutsEnum.StopCounter, stopCounterKey);
            }

            if (Enum.TryParse(savedShortcuts.AddDeath, out Keys addDeathKey))
            {
                shortcuts.Add(ShortcutsEnum.AddDeath, addDeathKey);
            }

            if (Enum.TryParse(savedShortcuts.RemoveDeath, out Keys removeDeathKey))
            {
                shortcuts.Add(ShortcutsEnum.RemoveDeath, removeDeathKey);
            }

            if (Enum.TryParse(savedShortcuts.PauseBoss, out Keys pauseBossKey))
            {
                shortcuts.Add(ShortcutsEnum.PauseBoss, pauseBossKey);
            }

            if (Enum.TryParse(savedShortcuts.ResumeBoss, out Keys resumeBossKey))
            {
                shortcuts.Add(ShortcutsEnum.ResumeBoss, resumeBossKey);
            }

            if (Enum.TryParse(savedShortcuts.StopBoss, out Keys stopBossKey))
            {
                shortcuts.Add(ShortcutsEnum.StopBoss, stopBossKey);
            }

            return shortcuts;
        }

    }
}
