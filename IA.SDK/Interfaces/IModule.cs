﻿using IA.SDK.Events;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IA.SDK
{
    public interface IModule
    {
        string Name { get; set; }

        bool Enabled { get; set; }

        MessageRecievedEventDelegate MessageRecieved { get; set; }
        UserUpdatedEventDelegate UserUpdated { get; set; }
        GuildUserEventDelegate UserJoinGuild { get; set; }
        GuildUserEventDelegate UserLeaveGuild { get; set; }

        List<ICommandEvent> Events { get; set; }

        Task<bool> IsEnabled(ulong id);

        Task InstallAsync(object bot);
        Task UninstallAsync(object bot);
    }
}