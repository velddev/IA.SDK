using IA.SDK.Events;
using IA.SDK.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class ModuleInstance : IModule
    {
        public string Name { get; set; }

        public bool Enabled { get; set; }

        public MessageRecievedEventDelegate MessageRecieved { get; set; }
        public UserUpdatedEventDelegate UserUpdated { get; set; }
        public GuildUserEventDelegate UserJoinGuild { get; set; }
        public GuildUserEventDelegate UserLeaveGuild { get; set; }

        public List<ICommandEvent> Events { get; set; }
        private Dictionary<ulong, bool> enabled = new Dictionary<ulong, bool>();

        public ModuleInstance(string name, bool enabled = true)
        {
            Name = name;
            Enabled = enabled;
        }

        public ModuleInstance(Action<IModule> info)
        {
            info.Invoke(this);
        }

        public Task Install()
        {
            return Task.CompletedTask;
        }

        public Task Uninstall()
        {
            return Task.CompletedTask;
        }

        public Task<bool> IsEnabled(ulong id)
        {
            throw new AddonRunException();
        }

        public Task InstallAsync(object bot)
        {
            throw new NotImplementedException();
        }

        public Task UninstallAsync(object bot)
        {
            throw new NotImplementedException();
        }
    }
}