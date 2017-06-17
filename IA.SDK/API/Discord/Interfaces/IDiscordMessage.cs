﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordMessage : IMeruMessage, IDiscordEntity
    {
        IDiscordUser Author { get; }
        IDiscordUser Bot { get; }

        IDiscordClient Discord { get; }

        IDiscordMessageChannel Channel { get; }
        IDiscordAudioChannel VoiceChannel { get; }

        IDiscordGuild Guild { get; }

        Dictionary<DiscordEmoji, DiscordReactionMetadata> Reactions { get; }

        DateTimeOffset Timestamp { get; }

        IReadOnlyCollection<ulong> MentionedUserIds { get; }
        IReadOnlyCollection<ulong> MentionedRoleIds { get; }
        IReadOnlyCollection<ulong> MentionedChannelIds { get; }

        Task DeleteAsync();

        Task ModifyAsync(string message);
        Task ModifyAsync(IDiscordEmbed embed);

        Task PinAsync();

        Task UnpinAsync();

        // TODO: Move to AddonInstance
        IDiscordEmbed CreateEmbed();
    }
}