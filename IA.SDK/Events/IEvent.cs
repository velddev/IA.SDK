using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Events
{
    public interface IEvent
    {
        string Name { get; }
        string[] Aliases { get; }

        string Description { get; }
        string[] Usage { get; }
    }
}
