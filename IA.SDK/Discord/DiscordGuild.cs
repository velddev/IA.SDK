using IA.SDK.Interfaces;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

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

        public virtual uint ChannelCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual uint UserCount
        {
            get
            {
                throw new NotImplementedException();
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

        public virtual Task<List<IDiscordChannel>> GetChannels()
        {
            throw new NotImplementedException();
        }
    }
}