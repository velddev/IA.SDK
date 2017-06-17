using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordAudioChannel : IDiscordChannel
    {
        Task<IDiscordAudioClient> ConnectAsync();
    }
}