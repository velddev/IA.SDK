using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meru.API
{
    class DiscordMessageAPI : IMessageAPI
    {
        DiscordSocketClient Client;

        public int Latency => Client.Latency;
    }
}
