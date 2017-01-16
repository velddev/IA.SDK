using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordMessageChannel : IDiscordChannel
    {
        Task SendFileAsync(string path);
        Task SendFileAsync(MemoryStream stream, string extension);

        Task<IDiscordMessageChannel> SendMessage(string message);
        Task<IDiscordMessageChannel> SendMessage(IDiscordEmbed embed);
    }
}
