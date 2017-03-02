using System;
using System.Threading.Tasks;

namespace IA.SDK
{
    public interface IAddonInstance
    {
        void CreateModule(Action<ModuleData> x);
        Task QueryAsync(string text, QueryOutput output, params object[] parameters);
    }
}