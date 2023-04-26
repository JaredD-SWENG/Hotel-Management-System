using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DecoratorReservation : ReservationAC
    {
        private ServiceIF servif;
        private ReservationIF resif;

        public DecoratorReservation(ServiceIF servif, ReservationIF resif) : base(0.00)
        {
            this.servif = servif;
            this.resif = resif;
        }

        public override double calculateCost()
        {
            throw new NotImplementedException();
        }

        public ServiceIF GetServiceIF()
        {
            return servif;
        }
        public ReservationIF GetReservationIF()
        {
            return resif;
        }

        public override string ToString()
        {
            return "Reservation " + getStartDate().ToString().Split(' ')[0];
        }
    }
}
