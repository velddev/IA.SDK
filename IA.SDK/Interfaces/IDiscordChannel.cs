using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordChannel : IDiscordEntity
    {
        IDiscordGuild Guild { get; }

        Task<IEnumerable<IDiscordUser>> GetUsersAsync();

        Task SendFileAsync(string path);
        Task SendFileAsync(MemoryStream stream, string extension);

        Task<DiscordMessage> SendMessage(string message);
        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);
    }
}