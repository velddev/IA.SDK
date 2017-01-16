using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordChannel : IDiscordEntity
    {
        string Name { get; }

        IDiscordGuild Guild { get; }

        Task<IEnumerable<IDiscordUser>> GetUsersAsync();
<<<<<<< HEAD

        Task SendFileAsync(string path);
        Task SendFileAsync(MemoryStream stream, string extension);

        Task<IDiscordMessage> SendMessage(string message);
        Task<IDiscordMessage> SendMessage(IDiscordEmbed embed);
=======
>>>>>>> 09af6848c130440ed3f367a93deed4821e87e497
    }
}