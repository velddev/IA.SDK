using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordAudioChannel : IDiscordChannel
    {
        Task<IDiscordAudioClient> ConnectAsync();
    }
}
