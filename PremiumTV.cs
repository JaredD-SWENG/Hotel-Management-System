using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// PremiumTV
    /// This is a service that provides access to premium tv
    /// </summary>
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
