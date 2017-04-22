using IA.SDK.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IA.SDK.Interfaces;
using IA.SDK.Events;

namespace IA.SDK
{
    public class AddonInstance : IAddonInstance
    {
        public string Name { get; set; }
        public List<IModule> Modules { get; set; } = new List<IModule>();

        public AddonInstance()
        {
            Modules = new List<IModule>();
        }

        public void CreateModule(Action<IModule> x)
        {
            Modules.Add(new Module(x));
        }

        public virtual async Task QueryAsync(string text, QueryOutput output, params object[] parameters)
        {
            throw new AddonRunException();
        }

        public virtual ICommandEvent GetCommandEvent(string args)
        {
            throw new AddonRunException();
        }

        public virtual Task<string> ListCommands(IDiscordMessage e)
        {
            throw new AddonRunException();
        }
        public virtual Task<IDiscordEmbed> ListCommandsInEmbed(IDiscordMessage e)
        {
            throw new AddonRunException();
        }

        public virtual EventAccessibility GetUserAccessibility(IDiscordMessage e)
        {
            throw new AddonRunException();
        }

        public virtual IEnumerable<Module> GetModules()
        {
            throw new AddonRunException();
        }

        public virtual Task<string> GetIdentifierAsync(ulong id)
        {
            throw new AddonRunException();
        }

        public virtual Task SetIdentifierAsync(IDiscordGuild guild, string args)
        {
            throw new AddonRunException();
        }

        public virtual string GetBotVersion()
        {
            throw new AddonRunException();
        }

        List<IModule> IAddonInstance.GetModules()
        {
            throw new NotImplementedException();
        }

        public int GetGuildCount()
        {
            throw new NotImplementedException();
        }

        public ulong GetBotId()
        {
            throw new NotImplementedException();
        }
    }
}