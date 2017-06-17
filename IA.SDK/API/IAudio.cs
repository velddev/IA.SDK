using System.IO;

namespace Meru.SDK.Interfaces
{
    public interface IAudio
    {
        Stream AudioBytes { get; set; }
    }
}