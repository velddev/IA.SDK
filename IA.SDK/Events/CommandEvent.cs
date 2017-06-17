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
        public Dictionary<string, ProcessCommandDelegate> CommandPool { get; set; } = new Dictionary<string, ProcessCommandDelegate>();

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

        public ICommandEvent SetCooldown(int seconds)
        {
            throw new NotImplementedException();
        }

        public ICommandEvent SetPermissions(params DiscordGuildPermission[] permissions)
        {
            throw new NotImplementedException();
        }

        public ICommandEvent On(string args, ProcessCommandDelegate command)
        {
            throw new NotImplementedException();
        }

        public ICommandEvent Default(ProcessCommandDelegate command)
        {
            throw new NotImplementedException();
        }

        ICommandEvent ICommandEvent.SetName(string name)
        {
            throw new NotImplementedException();
        }

        ICommandEvent ICommandEvent.SetAccessibility(EventAccessibility accessibility)
        {
            throw new NotImplementedException();
        }

        public ICommandEvent SetAliases(params string[] aliases)
        {
            throw new NotImplementedException();
        }
    }
}