using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// InternalIF
    /// This is the interface for hotels and floors
    /// </summary>
    interface InternalIF:HotelIF1
    {
        List<HotelIF3> getRooms();
    }
}
