using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordGuild : IDiscordEntity
    {
        string AvatarUrl { get; }
        string Name { get; }

        uint ChannelCount { get; }
        uint UserCount { get; }

        IDiscordUser Owner { get; }

        List<IDiscordRole> Roles { get; }

        Task<IDiscordUser> GetUserAsync(ulong user_id);

        Task<List<IDiscordChannel>> GetChannels();
        Task<IDiscordChannel> GetDefaultChannel();
        Task<IDiscordRole> GetRole(ulong role_id);
    }
}
