using IA.SDK.Interfaces;
using System.Threading.Tasks;

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

        public virtual Task<DiscordUser> GetUserAsync(ulong user_id)
        {
            return null;
        }

        public virtual Task<DiscordChannel> GetDefaultChannel()
        {
            return null;
        }
    }
}