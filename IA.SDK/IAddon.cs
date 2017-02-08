using System.Threading.Tasks;

namespace IA.SDK
{
    public interface IAddon
    {
        Task Create();

        AddonInstance GetAddon();
    }
}