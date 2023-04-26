using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface BuilderIF
    {
        DecoratorReservation build();
        void setRF(ReservationForm rf);
        BuilderIF provideBuilder(string str);
        List<String> provideFeatures();
    }
}
