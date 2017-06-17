using Meru.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meru
{
    public interface IMessageAPI
    {
        List<IMeruServer> Servers { get; }

        int Latency { get; }
    }
}
