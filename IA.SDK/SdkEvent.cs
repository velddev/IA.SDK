using IA.SDK.Events;
using IA.SDK.Interfaces;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IA.SDK
{
    public enum EventAccessibility
    {
        PUBLIC,
        ADMINONLY,
        DEVELOPERONLY
    }

    public delegate Task ProcessServerCommand(DiscordGuild e);
    public delegate Task ProcessCommand(IDiscordMessage e, string args);
    public delegate bool CheckCommand(IDiscordMessage e, string command, string[] allAliases);

    public class SdkEvent : IEvent, IToggleable
    {
        protected string name = "name not set";
        protected string[] aliases = new string[0];

        protected string description = "description not set for this command!";
        protected string[] usage = new string[] { "usage not set!" };
        protected string errorMessage = "Something went wrong!";

        protected bool canBeOverridenByDefaultPrefix = false;
        protected bool canBeDisabled = true;
        protected bool defaultEnabled = true;

        public Dictionary<ulong, bool> enabled = new Dictionary<ulong, bool>();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string[] Aliases
        {
            get
            {
                return aliases;
            }
            set
            {
                aliases = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string[] Usage
        {
            get
            {
                return usage;
            }
            set
            {
                usage = value;
            }
        }

        public bool CanBeDisabled
        {
            get
            {
                return canBeDisabled;
            }
            set
            {
                canBeDisabled = value;
            }
        }
        public bool DefaultEnabled
        {
            get
            {
                return defaultEnabled;
            }
            set
            {
                defaultEnabled = value;
            }
        }

        public Dictionary<ulong, bool> Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;
            }
        }

        public SdkModule module = new SdkModule("");

        public EventAccessibility accessibility = EventAccessibility.PUBLIC;

        public SdkEvent()
        {

        }
        public SdkEvent(Action<SdkEvent> info)
        {
            info.Invoke(this);
        }
    }
}
