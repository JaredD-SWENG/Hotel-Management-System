using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ObservableIF
    /// This is the interface for observable objects
    /// </summary>
    public interface ObservableIF
    {
        void addObserver(ObserverIF obif);
        void removeObserver(ObserverIF obif);
    }
}
