using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PremiumTV : ServiceAC
    {
        public PremiumTV(bool included):base(included) { }
        public override double calculateCost()
        {
            return 2.00;
        }

        public override string ToString()
        {
            return "Premium TV";
        }
    }
}
