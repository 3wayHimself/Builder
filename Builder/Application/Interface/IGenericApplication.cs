﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IGenericApplication
    {
        void RunLoop(int UpdateCount, int SleepTime);

        void Add(GenericWindow window);

        void Remove(GenericWindow window);

        void Destory();

        bool IsVailed { get; }
    }
}
