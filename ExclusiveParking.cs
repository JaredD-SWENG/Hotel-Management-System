using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class ExclusiveParking : ServiceAC
    {
        public ExclusiveParking(bool included) : base(included) { }

        public override double calculateCost()
        {
            return 8.00;
        }

        public override string ToString()
        {
            return "Exclusive Parking";
        }
    }
}
