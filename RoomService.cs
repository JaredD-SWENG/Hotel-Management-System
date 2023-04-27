using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// RoomService
    /// THis is the service that provides room service
    /// </summary>
    class RoomService : ServiceAC
    {
        public RoomService(bool included):base(included) { }
        public override double calculateCost()
        {
            return 5.00;
        }

        public override string ToString()
        {
            return "Room Service";
        }
    }
}
