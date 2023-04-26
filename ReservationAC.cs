using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class ReservationAC : ReservationIF
    {
        private DateTime startDate;
        private DateTime endDate;
        private RoomAC room;
        private double cost;

        public ReservationAC(double cost)
        {
            this.cost = cost;
        }
        public DateTime getStartDate()
        {
            return startDate;
        }

        public void setStartDate(DateTime date)
        {
            this.startDate = date;
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public void setEndDate(DateTime date)
        {
            this.endDate = date;
        }

        public RoomAC getRoom()
        {
            return room;
        }

        public void setRoom(RoomAC room)
        {
            this.room = room;
        }

        public double getCost()
        {
            return cost;
        }

        abstract public double calculateCost();
    }
}
