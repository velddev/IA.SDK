using IA.SDK.Interfaces;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace IA.SDK
{
    public class DiscordGuild : IDiscordGuild
    {
        public virtual string AvatarUrl
        {
            get
            {
                return "";
            }
        }

        public virtual ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual string Name
        {
            get
            {
                throw new NotImplementedException();
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

        public virtual IDiscordUser Owner
        {
            get
            {
                return null;
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