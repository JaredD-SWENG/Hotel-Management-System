using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// LuxuryBuilder
    /// This is the builder for the luxury level reservation
    /// </summary>
    class LuxuryBuilder : BuilderAC
    {
        public override DecoratorReservation build()
        {
            ReservationIF rif = new LuxuryReservation();
            ((LuxuryReservation)rif).setRoom(rf.getRoom());
            ((LuxuryReservation)rif).setStartDate(rf.getStartDate());
            ((LuxuryReservation)rif).setEndDate(rf.getEndDate());

            DecoratorReservation drif = new DecoratorReservation(null, rif);
            drif = new DecoratorReservation(new ContinentalBreakfast(true), drif);
            drif = new DecoratorReservation(new PremiumTV(true), drif);
            drif = new DecoratorReservation(new ExclusiveParking(true), drif);
            drif = new DecoratorReservation(new RoomService(true), drif);
            drif = new DecoratorReservation(new WiFi(true), drif);
            drif = new DecoratorReservation(new GymPass(true), drif);
            drif = new DecoratorReservation(new PoolPass(true), drif);
            drif = new DecoratorReservation(new Spa(true), drif);

            return drif;
        }


        public override List<string> provideFeatures()
        {
            List<string> retstrs = new List<string>();
            retstrs.Add("Continental Breakfast        FREE");
            retstrs.Add("WiFi                          $10");
            retstrs.Add("Premium TV                    $25");
            retstrs.Add("Gym Pass                      $10");
            retstrs.Add("Pool Pass                     $15");
            retstrs.Add("Spa                           $30");
            retstrs.Add("Exclusive Parking             $30");
            retstrs.Add("Room Service                  $30");
            return retstrs;
        }
    }
}
