﻿using Earlens.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.PhysicalDevice
{
    public interface IModule
    {
       
        bool Initialize();

        void Submit();

        void Acquire();
    }
}
