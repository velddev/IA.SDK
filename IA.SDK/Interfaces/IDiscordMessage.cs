using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordMessage : IDiscordEntity
    {
        IDiscordUser Author { get; }
        IDiscordUser Bot { get; }

        int ShardId { get; }

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

        IDiscordEmbed CreateEmbed();
    }
}
