using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class WiFi : ServiceAC
    {
        public WiFi(bool included):base(included) { }
        public override double calculateCost()
        {
            return 1.00;
        }

        public override string ToString()
        {
            return "WiFi";
        }
    }
}
