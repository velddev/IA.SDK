using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class DiscordRole : IDiscordEntity, IDiscordRole
    {
        public virtual ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual int Position
        {
            get
            {
                return 0;
            }
        }

        public virtual string Mention
        {
            get
            {
                return "";
            }
        }
    }
}
