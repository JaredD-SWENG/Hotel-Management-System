using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// Hotel
    /// This class is represents the hotel, which is made of floors
    /// </summary>
    public class Hotel: HotelCommonElements, InternalIF
    {
        private List<InternalIF> floors;

        public Hotel(string hotelName, string address, string phonenumber):base(hotelName, address, phonenumber)
        {
             floors = new List<InternalIF>(); 
        }

        public void addFloor(Floor floor)
        {
            floors.Add(floor);
        }

        public List<HotelIF3> getRooms()
        {
            List<HotelIF3> rooms = new List<HotelIF3>();
            foreach(InternalIF flrs in floors){
                rooms.AddRange(flrs.getRooms());
            }
            return rooms;
        }
        public override string ToString()
        {
            return getName();
        }
    }
}
