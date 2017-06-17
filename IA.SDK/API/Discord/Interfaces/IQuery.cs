﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meru.SDK.Interfaces
{
    public interface IQuery<T>
    {
        T Query(string query);
    }
}