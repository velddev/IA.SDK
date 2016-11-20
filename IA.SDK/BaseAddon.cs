﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class BaseAddon : IAddon
    {
        protected AddonInstance addon = new AddonInstance();

        public virtual Task Create()
        {
            return Task.CompletedTask;
        }

        public AddonInstance GetAddon()
        {
            return addon;
        }
    }
}
