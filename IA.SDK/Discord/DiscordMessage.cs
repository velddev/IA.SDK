#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    // TODO: Clean
    public class DiscordMessage : IDiscordMessage
    {
        public virtual ulong Id => 0;
        public virtual IDiscordUser Author => throw new NotImplementedException();
        public virtual IDiscordUser Bot => throw new NotImplementedException();
        public virtual IDiscordGuild Guild => throw new NotImplementedException();
        public virtual string Content => throw new NotImplementedException();
        public virtual DateTimeOffset Timestamp => throw new NotImplementedException();
        public virtual IReadOnlyCollection<ulong> MentionedUserIds => throw new NotImplementedException();
        public virtual IReadOnlyCollection<ulong> MentionedRoleIds => throw new NotImplementedException();
        public int ShardId => throw new NotImplementedException();
        public IDiscordClient Discord => throw new NotImplementedException();
        private IDiscordMessageChannel Channel => throw new NotImplementedException();
        public IDiscordAudioChannel VoiceChannel => throw new NotImplementedException();
        IDiscordMessageChannel IDiscordMessage.Channel => throw new NotImplementedException();
        public Dictionary<DiscordEmoji, int> Reactions => throw new NotImplementedException();

        public IReadOnlyCollection<ulong> MentionedChannelIds => throw new NotImplementedException();

        public virtual async Task DeleteAsync() => throw new NotImplementedException();

        public virtual async Task ModifyAsync(string message) => throw new NotImplementedException();

        public virtual async Task PinAsync() => throw new NotImplementedException();

        public virtual async Task UnpinAsync() => throw new NotImplementedException();

        public virtual IDiscordEmbed CreateEmbed() => throw new NotImplementedException();
    }
}