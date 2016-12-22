using IA.SDK.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public delegate Task MessageRecievedEventDelegate(IDiscordMessage msg);
    public delegate Task GuildUserEventDelegate(IDiscordGuild guild, IDiscordUser user);

    public delegate Task UserUpdatedEventDelegate(IDiscordUser oldUser, IDiscordUser newUser);

    public class ModuleData
    {
        public string name = "$no-name";
        public bool enabled = true;

        public List<CommandEvent> events = new List<CommandEvent>();

        public MessageRecievedEventDelegate messageRecieved;

        public GuildUserEventDelegate userJoin;
        public GuildUserEventDelegate userLeave;

        public UserUpdatedEventDelegate userUpdated;
    }
}