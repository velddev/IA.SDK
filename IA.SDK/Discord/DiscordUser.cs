﻿using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class DiscordUser : IDiscordUser, IMentionable
    {
        public virtual string AvatarUrl
        {
            get
            {
                return "";
            }
        }

        public virtual string Discriminator
        {
            get
            {
                return "";
            }
        }

        public virtual IDiscordGuild Guild
        {
            get
            {
                return null;
            }
        }

        public virtual ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual bool IsBot
        {
            get
            {
                return false;
            }
        }

        public virtual string Mention
        {
            get
            {
                return "<@!" + Id + ">";
            }
        }

        public virtual List<ulong> RoleIds
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual string Username
        {
            get
            {
                return "";
            }
        }

        public virtual Task AddRoleAsync(IDiscordRole role)
        {
            throw new NotImplementedException();
        }

        public virtual Task Ban(IDiscordGuild guild)
        {
            throw new NotImplementedException();
        }

        public virtual bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions)
        {
            throw new NotImplementedException();
        }

        public virtual Task Kick()
        {
            throw new NotImplementedException();
        }

        public virtual Task RemoveRoleAsync(IDiscordRole role)
        {
            throw new NotImplementedException();
        }

        public virtual Task SendFile(string path)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IDiscordMessage> SendMessage(string text)
        {
            throw new NotImplementedException();
        }
        public virtual Task<IDiscordMessage> SendMessage(IDiscordEmbed embed)
        {
            throw new NotImplementedException();
        }
    }
}
