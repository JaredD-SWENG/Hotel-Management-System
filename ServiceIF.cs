using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ServiceIF
    /// This is the interface for all services
    /// </summary>
    public interface ServiceIF
    {
        double calculateCost();
        bool isIncluded();
    }
}
