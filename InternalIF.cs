using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    interface InternalIF:HotelIF1
    {
        List<HotelIF3> getRooms();
    }
}
