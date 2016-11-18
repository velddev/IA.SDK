using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class SdkModule
    {
        public ModuleData data = new ModuleData();

        Dictionary<ulong, bool> enabled = new Dictionary<ulong, bool>();

        public SdkModule()
        {
            
        }
        public SdkModule(string name, bool enabled = true)
        {
            data = new ModuleData();
            data.name = name;
            data.enabled = enabled;
        }       
        public SdkModule(Action<ModuleData> info)
        {
            info.Invoke(data);
        }

        public Task AddCommand(Action<SdkCommandEvent> x)
        {
            SdkCommandEvent y = new SdkCommandEvent(x);
            data.events.Add(y);
            return Task.CompletedTask;
        }

        public virtual string GetState()
        {
            return data.name + ": " + "ACTIVE";
        }

        public virtual Task Initialize()
        {
            return Task.CompletedTask;
        }

        public virtual Task Install()
        {
            return Task.CompletedTask;
        }

        public virtual Task Uninstall()
        {
            return Task.CompletedTask;
        }
    }
}
