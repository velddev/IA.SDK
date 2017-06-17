using IA.SDK.Interfaces;
using System.Threading.Tasks;

namespace IA.SDK
{
    public enum EventAccessibility
    {
        PUBLIC,
        ADMINONLY,
        DEVELOPERONLY
    }

    public enum EventRange
    {
        USER,
        CHANNEL,
        SERVER
    }

    public delegate Task ProcessServerCommand(IDiscordGuild e);

    public delegate Task ProcessCommandDelegate(IDiscordMessage e, string args);

    public delegate bool CheckCommandDelegate(IDiscordMessage e, string command, string[] allAliases);
}