using IA.SDK.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public delegate Task MessageRecievedEventDelegate(IDiscordMessage msg);
    public delegate Task UserUpdatedEventDelegate(IDiscordUser oldUser, IDiscordUser newUser);

    public class ModuleData
    {
        public string name;
        public bool enabled;

        public List<CommandEvent> events = new List<CommandEvent>();

        public MessageRecievedEventDelegate messageRecieved;
        public UserUpdatedEventDelegate userUpdated;
    }
}