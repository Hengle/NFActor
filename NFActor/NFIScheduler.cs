﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFrame
{
    public abstract class NFIScheduler : NFBehaviour
    {
        public abstract void AddToScheduler(NFIDENTID xID);

    }
}
