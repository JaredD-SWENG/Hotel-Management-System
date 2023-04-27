using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// PoolPass
    /// This is a service that gives access to the hotel's pool
    /// </summary>
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
