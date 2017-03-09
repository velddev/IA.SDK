using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Events
{
    public interface ICommandEvent : IEvent
    {
        int Cooldown { get; set; }

        List<DiscordGuildPermission> GuildPermissions { get; set; }

        CheckCommandDelegate CheckCommand { get; set; }
        ProcessCommandDelegate ProcessCommand { get; set; }

        Task Check(IDiscordMessage e, string identifier = "");
    }
}
