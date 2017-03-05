using IA.SDK.Events;
using System;
using System.Collections.Generic;

namespace IA.SDK
{
    public class CommandEvent : EventInstance, ICommandEvent
    {
        public int Cooldown { get; set; }

        public List<DiscordGuildPermission> GuildPermissions { get; set; }

        public CheckCommandDelegate CheckCommand { get; set; }
        public ProcessCommandDelegate ProcessCommand { get; set; }

        public CommandEvent()
        { }

        public CommandEvent(Action<CommandEvent> info)
        {
            info.Invoke(this);
        }
    }
}