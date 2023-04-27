using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// Spa
    /// This is a service that allows access to the hotel's spa
    /// </summary>
    class Spa : ServiceAC
    {
        public Spa(bool included):base(included) { }
        public override double calculateCost()
        {
            return 15.00;
        }

        public override string ToString()
        {
            return "Spa";
        }
    }
}
