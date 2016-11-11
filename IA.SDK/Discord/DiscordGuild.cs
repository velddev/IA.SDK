using IA.SDK.Interfaces;

namespace IA.SDK
{
    public class DiscordGuild : IDiscordGuild
    {
        public ulong Id
        {
            get
            {
                return 0;
            }
        }

        public virtual DiscordChannel GetDefaultChannel()
        {
            return null;
        }
    }
}