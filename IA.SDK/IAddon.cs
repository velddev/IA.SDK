using System.Threading.Tasks;

namespace IA.SDK
{
    public interface IAddon
    {
        Task<AddonInstance> Create(AddonInstance instance);

        AddonInstance GetAddon();
    }
}