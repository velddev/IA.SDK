using IA.SDK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Events
{
    public interface IProcessable
    {
        Dictionary<ulong, DateTime> LastUsed { get; set; }

        string ErrorMessage { get; set; }

        int SecondsCooldown { get; set; }
        int TimesProcessed { get; set; }

        Task Process(IDiscordMessage e);
    }
}
