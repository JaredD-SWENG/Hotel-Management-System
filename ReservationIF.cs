using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// ReservationIF
    /// This is the interface for all reservations
    /// </summary>
    public interface ReservationIF
    {
        double calculateCost();
        RoomAC getRoom();
    }
}
