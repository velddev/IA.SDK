using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordMessage : IDiscordEntity
    {
        IDiscordUser Author { get; }
        IDiscordUser Bot { get; }

        IDiscordClient Discord { get; }

        IDiscordMessageChannel Channel { get; }
        IDiscordAudioChannel VoiceChannel { get; }

        IDiscordGuild Guild { get; }

        string Content { get; }
        DateTimeOffset Timestamp { get; }

        IReadOnlyCollection<ulong> MentionedUserIds { get; }
        IReadOnlyCollection<ulong> MentionedRoleIds { get; }

        Task DeleteAsync();

        Task ModifyAsync(string message);

        Task PinAsync();

        Task UnpinAsync();

        // TODO: Move to AddonInstance
        IDiscordEmbed CreateEmbed();
    }
}