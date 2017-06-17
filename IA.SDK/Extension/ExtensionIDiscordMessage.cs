using Meru.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meru.SDK.Extension
{
    public static class ExtensionIDiscordMessage
    {
        public static string RemoveMentions(this IDiscordMessage message, string content = "")
        {
            if (content == "")
            {
                content = message.Content;
            }

            foreach (ulong id in message.MentionedUserIds)
            {
                content = content.Replace($"<@{id.ToString()}>", message.Guild.GetUserAsync(id).GetAwaiter().GetResult().Username);
                content = content.Replace($"<@!{id.ToString()}>", message.Guild.GetUserAsync(id).GetAwaiter().GetResult().Nickname);
            }
            foreach (ulong id in message.MentionedRoleIds)
            {
                content = content.Replace($"<@&{id.ToString()}>", message.Guild.GetRole(id).Name);
            }
            foreach (ulong id in message.MentionedChannelIds)
            {
                content = content.Replace($"<#{id.ToString()}>", message.Guild.GetChannels().GetAwaiter().GetResult().Find(c => { return c.Id == id; }).Name);
            }
            return content;
        }
    }
}
