using Meru.SDK.Events;
using Meru.SDK.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meru.SDK
{
    public delegate Task MessageRecievedEventDelegate(IDiscordMessage msg);
    public delegate Task GuildUserEventDelegate(IDiscordGuild guild, IDiscordUser user);
    public delegate Task GuildEventDelegate(IDiscordGuild guild);
    public delegate Task UserUpdatedEventDelegate(IDiscordUser oldUser, IDiscordUser newUser);
}