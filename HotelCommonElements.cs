using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    /// <summary>
    /// HotelCommonElements
    /// This class has the common elements for the hotel components (hotel, floor, and room)
    /// </summary>
    public class HotelCommonElements
    {
        private string hotelName;
        private string address;
        private string phoneNumber;

        public HotelCommonElements(string hotelName, string address, string phoneNumber)
        {
            this.hotelName = hotelName;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string getName()
        {
            return hotelName;
        }

        public void setName(string name)
        {
            this.hotelName = name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
    }
}
