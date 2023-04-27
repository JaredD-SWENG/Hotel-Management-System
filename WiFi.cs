using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// WiFi
    /// This is service that provides access to WiFi
    /// </summary>
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
