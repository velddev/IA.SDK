using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordAudioClient
    {
        Queue<IAudio> AudioQueue { get; }

        bool IsPlaying { get; }

        Task Connect();

        Task Disconnect();

        Task Play(IAudio audio, bool skipIfPlaying = false);

        Task Pause();

        Task Skip();
    }
}