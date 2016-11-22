using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    interface IDiscordAudioClient
    {
        bool IsPlaying { get; }

        Task Connect();
        Task Disconnect();

        Task Play(IAudio audio);
        Task Pause();
    }
}
