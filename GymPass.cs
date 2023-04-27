using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// GymPass
    /// This is a service to access the gym at the hotel
    /// </summary>
    class GymPass : ServiceAC
    {
        public GymPass(bool included) : base(included) { }
        public override double calculateCost()
        {
            return 6.00;
        }

        public override string ToString()
        {
            return "Gym Pass";
        }
    }
}
