using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordUser : IMeruUser, IDiscordEntity, IMentionable
    {
        string AvatarUrl { get; }

        bool IsBot { get; }

        string Discriminator { get; }

        IDiscordAudioChannel VoiceChannel { get; }

        IDiscordGuild Guild { get; }
        
        DateTimeOffset CreatedAt { get; }
        DateTimeOffset? JoinedAt { get; }

        List<ulong> RoleIds { get; }

        string Nickname { get; }

        bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions);

        Task AddRoleAsync(IDiscordRole role);

        Task AddRolesAsync(List<IDiscordRole> roles);

        Task Ban(IDiscordGuild guild);

        Task Kick();

        string GetAvatarUrl(DiscordAvatarType type = DiscordAvatarType.PNG, ushort size = 128);

        Task RemoveRoleAsync(IDiscordRole role);

        Task RemoveRolesAsync(List<IDiscordRole> roles);

        Task SendFile(string path);

        Task<IDiscordMessage> SendMessage(string text);

        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);

        Task SetNickname(string text);

        Task Unban(IDiscordGuild guild);
    }

    public enum DiscordAvatarType
    {
        PNG, GIF
    };
}