using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    interface IDiscordReaction
    {
        DiscordEmoji Emoji { get; }
    }
}
