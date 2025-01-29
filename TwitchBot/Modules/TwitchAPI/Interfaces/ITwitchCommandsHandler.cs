﻿using TwitchBot.ViewModels;
using TwitchLib.Client.Events;

namespace TwitchBot.Modules.TwitchAPI.Interfaces
{
    public interface ITwitchCommandsHandler
    {
        void ProcessCommand(string commandText, OnMessageReceivedArgs e);
    }
}