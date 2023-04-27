using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// DeluxeBuilder
    /// This is builder creates deluxe level reservations
    /// </summary>
    class DeluxeBuilder : BuilderAC
    {
        public DeluxeBuilder() { }

        public override DecoratorReservation build()
        {
            ReservationIF rif = new DeluxeReservation();
            ((DeluxeReservation)rif).setRoom(rf.getRoom());
            ((DeluxeReservation)rif).setStartDate(rf.getStartDate());
            ((DeluxeReservation)rif).setEndDate(rf.getEndDate());

            DecoratorReservation drif = new DecoratorReservation(null, rif);
            drif = new DecoratorReservation(new ContinentalBreakfast(true), drif);
            drif = new DecoratorReservation(new PremiumTV(true), drif);
            drif = new DecoratorReservation(new WiFi(true), drif);
            drif = new DecoratorReservation(new GymPass(true), drif);

            return drif;
        }

        public override List<string> provideFeatures()
        {
            List<string> retstrs = new List<string>();
            retstrs.Add("Continental Breakfast        FREE");
            retstrs.Add("WiFi                          $10");
            retstrs.Add("Premium TV                    $25");
            retstrs.Add("Gym Pass                      $10");
            return retstrs;
        }
    }
}
