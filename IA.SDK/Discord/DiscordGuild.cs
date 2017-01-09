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

        public virtual ulong Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual string Name
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

        public virtual List<IDiscordRole> Roles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual Task<IDiscordUser> GetUserAsync(ulong user_id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IDiscordChannel> GetDefaultChannel()
        {
            throw new NotImplementedException();
        }

        public virtual Task<List<IDiscordChannel>> GetChannels()
        {
            throw new NotImplementedException();
        }

        public virtual IDiscordRole GetRole(ulong role_id)
        {
            throw new NotImplementedException();
        }
    }
}