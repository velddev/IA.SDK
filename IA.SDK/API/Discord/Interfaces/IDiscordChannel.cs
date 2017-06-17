using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IDiscordChannel : IDiscordEntity
    {
        string Name { get; }

        IDiscordGuild Guild { get; }

        Task<IEnumerable<IDiscordUser>> GetUsersAsync();
    }
}