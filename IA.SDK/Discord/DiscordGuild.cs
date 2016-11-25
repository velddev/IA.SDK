using IA.SDK.Interfaces;
using System.Threading.Tasks;
using System;

namespace IA.SDK
{
    public class DiscordGuild : IDiscordGuild
    {
        public virtual ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual Task<IDiscordUser> GetUserAsync(ulong user_id)
        {
            return null;
        }

        public virtual Task<IDiscordChannel> GetDefaultChannel()
        {
            return null;
        }
    }
}