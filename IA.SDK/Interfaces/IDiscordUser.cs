using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordUser : IDiscordEntity, IMentionable
    {
        string AvatarUrl { get; }

        bool IsBot { get; }

        string Username { get; }
        string Discriminator { get; }

        IDiscordGuild Guild { get; }

        bool HasPermissions(IDiscordChannel channel, params DiscordGuildPermission[] permissions);

        Task AddRoleAsync(IDiscordRole role);

        Task Ban(IDiscordGuild guild);
        Task Kick();

        Task RemoveRoleAsync(IDiscordRole role);

        Task<IDiscordMessage> SendMessage(string text);
        Task SendFile(string path);
    }
}