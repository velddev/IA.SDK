﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public interface IAddon
    {
        Task Create();
        AddonInstance GetAddon();
    }
}
