﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PoolPass : ServiceAC
    {
        public PoolPass(bool included):base(included) { }
        public override double calculateCost()
        {
            return 4.00;
        }

        public override string ToString()
        {
            return "Pool Pass";
        }
    }
}
