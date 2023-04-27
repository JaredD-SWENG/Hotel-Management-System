using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ServiceAC
    /// This is the abstract class for all services
    /// </summary>
    abstract class ServiceAC: ServiceIF
    {
        private bool included;
        public ServiceAC(bool included)
        {
            this.included = included;
        }

        abstract public double calculateCost();
     

        public bool isIncluded()
        {
            return included;
        }
    }
}
