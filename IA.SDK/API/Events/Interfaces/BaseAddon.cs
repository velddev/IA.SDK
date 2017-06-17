using System.Threading.Tasks;

namespace Meru.SDK
{
    public interface IAddon
    {
        Task<IAddonInstance> Create(IAddonInstance i);
    }
}