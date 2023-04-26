using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class DeluxeReservation : ReservationAC 
    {
        public DeluxeReservation() : base(110.00) { }

        public override double calculateCost()
        {
            return (getCost() + (getRoom()).calculateCost(getStartDate(), getEndDate()));
        }
        public override string ToString()
        {
            return "Deluxe Reservation";
        }
    }
}
