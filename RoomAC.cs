using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// RoomAC
    /// This is the abstract class for all rooms, it is also an obserable object
    /// </summary>
    abstract public class RoomAC : HotelCommonElements, HotelIF3, ObservableIF
    {
        private bool reserved;
        private double roomCost;
        private ObserverMultiCaster obsMC;

        public RoomAC(string hotelName, string address, string phoneNumber):base(hotelName, address, phoneNumber)
        {
            obsMC = new ObserverMultiCaster();
            reserved = false;
        }

        public bool isReserved()
        {
            return reserved;
        }


        abstract public double calculateCost(DateTime startDate, DateTime endDate);

        public double getCost()
        {
            return roomCost;
        }

        public void setCost(double cost)
        {
            this.roomCost = cost;
        }

        public void addObserver(ObserverIF obif)
        {
            obsMC.addObserver(obif);
        }

        public void removeObserver(ObserverIF obif)
        {
            obsMC.removeObserver(obif);
        }

        public void changeReservedStatus()
        {
            reserved = (reserved) ? false : true;
            if (!reserved)
            {
                obsMC.notifyObservers();
            }
        }
    }
}
