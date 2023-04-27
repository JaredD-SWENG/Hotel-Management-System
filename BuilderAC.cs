using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// BuilderAC
    /// This is the abstract class for all the builders, it interacts with the Reservation Form
    /// </summary>
    abstract class BuilderAC : BuilderIF
    {
        protected ReservationForm rf;

        abstract public DecoratorReservation build();

        public BuilderIF provideBuilder(string str)
        {
            str = "FinalProject." + str + "Builder";
            Type t = Type.GetType(str);
            BuilderIF bif = (BuilderIF)Activator.CreateInstance(t);
            bif.setRF(rf);
            return bif;
        }

        abstract public List<string> provideFeatures();

        public void setRF(ReservationForm rf)
        {
            this.rf = rf;
        }

        
    }
}
