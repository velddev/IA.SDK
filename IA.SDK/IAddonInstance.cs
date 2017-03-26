using IA.SDK.Events;
using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    // TODO: restructure this
    // TODO: stop adding TODO's and just do it
    // TODO: Listen to my old TODO's

    public interface IAddonInstance
    {
        string Name { get; set; }
        List<IModule> Modules { get; set; }

        void CreateModule(Action<IModule> module);

        ICommandEvent GetCommandEvent(string commandName);

        string GetBotVersion();
        Task<string> GetIdentifierAsync(ulong serverid);
        List<IModule> GetModules();
        EventAccessibility GetUserAccessibility(IDiscordMessage message);
        Task<string> ListCommands(IDiscordMessage e);
        Task<IDiscordEmbed> ListCommandsInEmbed(IDiscordMessage e);

        Task SetIdentifierAsync(IDiscordGuild guild, string identifier);

        Task QueryAsync(string text, QueryOutput output, params object[] parameters);
    }
}