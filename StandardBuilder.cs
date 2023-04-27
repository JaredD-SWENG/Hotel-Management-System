using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// StandardBuilder
    /// This is the builder that creates a standard reservation
    /// </summary>
    class StandardBuilder : BuilderAC
    {
        public StandardBuilder() { }

        public override DecoratorReservation build()
        {
            //We have Form3, which will provide us the room, start and end dates.
            ReservationIF rif = new StandardReservation();
            ((StandardReservation)rif).setRoom(rf.getRoom());
            ((StandardReservation)rif).setStartDate(rf.getStartDate());
            ((StandardReservation)rif).setEndDate(rf.getEndDate());

            DecoratorReservation drif = new DecoratorReservation(null, rif);
            drif = new DecoratorReservation(new ContinentalBreakfast(true), drif);

            return drif;
        }

        public override List<string> provideFeatures()
        {
            List<string> retstrs = new List<string>();
            retstrs.Add("Continental Breakfast        FREE");
            return retstrs;
        }
    }
}
