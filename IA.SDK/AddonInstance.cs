using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class AddonInstance : IAddonInstance
    {
        public string name = "unnamed-addon";
        public List<ModuleInstance> modules;

        public AddonInstance()
        {
            modules = new List<ModuleInstance>();
        }

        public void AddCommandEventTo(ModuleInstance selectedModule, Action<CommandEvent> command)
        {
            selectedModule.AddCommand(command);
        }

        public void CreateModule(Action<ModuleData> x)
        {
            modules.Add(new ModuleInstance(x));
        }

        public virtual async Task QueryAsync(string text, QueryOutput output, params object[] parameters)
        {
            throw new Exception("Addon cannot run on it's own");
        }
    }
}