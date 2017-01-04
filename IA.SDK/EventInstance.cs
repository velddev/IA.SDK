using System;
using System.Collections.Generic;

namespace IA.SDK
{
    public class EventInstance
    {
        public string name = "name not set";
        public string[] aliases = new string[0];

        public bool canBeOverridenByDefaultPrefix = false;
        public bool canBeDisabled = true;
        public bool defaultEnabled = true;

        public ModuleInstance module = new ModuleInstance("");

        public EventAccessibility accessibility = EventAccessibility.PUBLIC;
        public EventMetadata metadata = new EventMetadata();

        public EventInstance()
        {

        }
        public EventInstance(Action<EventInstance> info)
        {
            info.Invoke(this);
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
