using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// TwoBedRoom
    /// This is a specific type of room that has two beds
    /// </summary>
    class TwoBedRoom:RoomAC
    {
        public TwoBedRoom(string hotelName, string address, string phoneNumber) : base(hotelName, address, phoneNumber)
        {
            setCost(105.00);
        }

        public override double calculateCost(DateTime startDate, DateTime endDate)
        {
            return ((endDate - startDate).TotalDays * getCost()) + 30;
        }

        public override string ToString()
        {
            string nm = "2 Bed Room";
            string availability = (isReserved()) ? "Reserved" : "Open";
            return string.Format("{0,-10}{1,-15}{2,10}{3,13}", getName(), nm, availability, ("$" + getCost()));
        }
    }
}
