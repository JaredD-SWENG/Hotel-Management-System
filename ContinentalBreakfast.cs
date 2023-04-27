using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ContinentalBreakfast
    /// This is a service that is included for free in all reservations
    /// </summary>
    class ContinentalBreakfast : ServiceAC
    {
        public ContinentalBreakfast(bool included):base(included) { }
        public override double calculateCost()
        {
            return 0.00;
        }

        public override string ToString()
        {
            return "Continental Breakfast";
        }
    }
}
