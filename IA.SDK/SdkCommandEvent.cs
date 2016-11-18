using IA.SDK.Events;
using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class SdkCommandEvent : SdkEvent, IProcessable
    {
        public Dictionary<ulong, DateTime> lastUsed = new Dictionary<ulong, DateTime>();

        protected int cooldown = 1;
        protected int timesProcessed = 0;

        public DiscordGuildPermission[] requiresPermissions = new DiscordGuildPermission[0];

        public CheckCommand checkCommand = (a, b, c) =>
        {
            return true;
        };

        public ProcessCommand processCommand = null;

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
            }
        }

        public int SecondsCooldown
        {
            get
            {
                return cooldown;
            }
            set
            {
                cooldown = value;
            }
        }
        public int TimesProcessed
        {
            get
            {
                return timesProcessed;
            }
            set
            {
                timesProcessed = value;
            }
        }

        public Dictionary<ulong, DateTime> LastUsed
        {
            get
            {
                return lastUsed;   
            }

            set
            {
                lastUsed = value;
            }
        }

        public SdkCommandEvent()
        {

        }
        public SdkCommandEvent(Action<SdkCommandEvent> info) { 
            info.Invoke(this);
        }

        public virtual Task Process(IDiscordMessage msg)
        {
            return Task.CompletedTask;
        }
    }
}
