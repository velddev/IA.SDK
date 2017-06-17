using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordGuild : IMeruServer, IDiscordEntity
    {
        string AvatarUrl { get; }

        uint ChannelCount { get; }
        uint VoiceChannelCount { get; }
        uint UserCount { get; }

        IDiscordUser Owner { get; }

        List<IDiscordRole> Roles { get; }

        Task<IDiscordUser> GetUserAsync(ulong user_id);

        Task<List<IDiscordMessageChannel>> GetChannels();

        Task<IDiscordMessageChannel> GetDefaultChannel();

        IDiscordRole GetRole(ulong role_id);
    }
}