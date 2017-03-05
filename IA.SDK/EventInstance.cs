using IA.SDK.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK.Events
{
    public class EventInstance : IEvent
    {
        public string Name { get; set; } = "$command-not-named";
        public string[] Aliases { get; set; }

        public EventAccessibility Accessibility { get; set; } = EventAccessibility.PUBLIC;
        public EventMetadata Metadata { get; set; } = new EventMetadata();

        public bool OverridableByDefaultPrefix { get; set; } = false;
        public bool CanBeDisabled { get; set; } = false;
        public bool DefaultEnabled { get; set; } = true;

        public IModule Module { get; set; }

        public int TimesUsed { get; set; } = 0;

        public EventInstance()
        {
        }

        public EventInstance(Action<EventInstance> info)
        {
            info.Invoke(this);
        }

        public virtual async Task<bool> IsEnabled(ulong id)
        {
            throw new AddonRunException();
        }
    }

    public class EventMetadata
    {
        public string description = "description not set for this command!";
        public string errorMessage = "Something went wrong!";

        public List<string> usage = new List<string>();

        public EventMetadata()
        {
        }

        public EventMetadata(string description, string error, params string[] usage)
        {
            this.description = description;
            errorMessage = error;
            this.usage.AddRange(usage);
        }
    }
}