using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    public interface IDiscordRole
    {
        ulong Id { get; }

        int Position { get; }

        Color Color { get; }

        string Mention { get; }
        string Name { get; }
    }
}
