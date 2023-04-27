using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// OneBedRoom
    /// This is a specific type of room that contains one bed
    /// </summary>
    class OneBedRoom:RoomAC
    {
        public OneBedRoom(string hotelName, string address, string phoneNumber) :base(hotelName, address, phoneNumber)
        {
            setCost(85.00);
        }

        public override double calculateCost(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).TotalDays * getCost();
        }

        public override string ToString()
        {
            string nm = "1 Bed Room";
            string availability = (isReserved()) ? "Reserved": "Open";
            return string.Format("{0,-10}{1,-15}{2,10}{3,13}", getName(), nm, availability, ("$" + getCost()));
        }
    }
}
