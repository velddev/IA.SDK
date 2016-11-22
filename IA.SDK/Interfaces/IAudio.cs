using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK.Interfaces
{
    interface IAudio
    {
        Stream AudioBytes { get; set; }
    }
}
