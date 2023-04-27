using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// Floor
    /// This is a component of hotels that is made of rooms
    /// </summary>
    public class Floor: HotelCommonElements, HotelIF2, InternalIF
    {
        private List<HotelIF3> rooms;

        public Floor(string hotelName, string address, string phoneNumber):base(hotelName, address, phoneNumber)
        {
            rooms = new List<HotelIF3>();
        }

        public void addRoom(HotelIF3 room)
        {
            rooms.Add(room);
        }

        public List<HotelIF3> getRooms()
        {
            return rooms;
        }
    }
}
