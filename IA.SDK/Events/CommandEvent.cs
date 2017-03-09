using IA.SDK.Events;
using System;
using System.Collections.Generic;
using IA.SDK.Interfaces;
using System.Threading.Tasks;
using IA.SDK.Exceptions;

namespace IA.SDK
{
    public class CommandEvent : Event, ICommandEvent
    {
        public int Cooldown { get; set; } = 1;

        public List<DiscordGuildPermission> GuildPermissions { get; set; } = new List<DiscordGuildPermission>();

        public CheckCommandDelegate CheckCommand { get; set; } = (e, args, aliases) =>
        {
            return true;
        };
        public ProcessCommandDelegate ProcessCommand { get; set; } = async (e, args) =>
        {
            await e.Channel.SendMessage("This command hasn't been set up correctly!");
        };

        public CommandEvent()
        { }

        public CommandEvent(Action<CommandEvent> info)
        {
            info.Invoke(this);
        }

        public Task Check(IDiscordMessage e, string identifier = "")
        {
            throw new AddonRunException();
        }
    }
}