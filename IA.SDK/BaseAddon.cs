using System.Threading.Tasks;

namespace IA.SDK
{
    public class BaseAddon : IAddon
    {
        protected AddonInstance addon = new AddonInstance();

        public virtual Task<AddonInstance> Create(AddonInstance i)
        {
            return null;
        }

        public AddonInstance GetAddon()
        {
            return addon;
        }


    }
}