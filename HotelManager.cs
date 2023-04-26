using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class HotelManager
    {
        private static HotelManager hotelManager = new HotelManager();
        private List<Hotel> hotels;
        private HotelManager()
        {
            string name = "DaysInn";
            string add = "123 ABC Street";
            string pnum = "123-456-7890";

            OneBedRoom f1r1 = new OneBedRoom(name, add, pnum);
            OneBedRoom f1r2 = new OneBedRoom(name, add, pnum);
            TwoBedRoom f1r3 = new TwoBedRoom(name, add, pnum);
            Floor flr1 = new Floor(name, add, pnum);
            flr1.addRoom(f1r1);
            flr1.addRoom(f1r2);
            flr1.addRoom(f1r3);

            OneBedRoom f2r1 = new OneBedRoom(name, add, pnum);
            OneBedRoom f2r2 = new OneBedRoom(name, add, pnum);
            TwoBedRoom f2r3 = new TwoBedRoom(name, add, pnum);
            Floor flr2 = new Floor(name, add, pnum);
            flr2.addRoom(f2r1);
            flr2.addRoom(f2r2);
            flr2.addRoom(f2r3);

            Hotel h1 = new Hotel(name, add, pnum);
            h1.addFloor(flr1);
            h1.addFloor(flr2);

            hotels = new List<Hotel>();
            hotels.Add(h1);


            string name2 = "EconoLodge";
            string add2 = "987 XYZ Street";
            string pnum2 = "098-765-4321";
            
            OneBedRoom f01r01 = new OneBedRoom(name2, add2, pnum2);
            TwoBedRoom f01r02 = new TwoBedRoom(name2, add2, pnum2);
            TwoBedRoom f01r03 = new TwoBedRoom(name2, add2, pnum2);
            Floor f0lr01 = new Floor(name2, add2, pnum2);
            f0lr01.addRoom(f01r01);
            f0lr01.addRoom(f01r02);
            f0lr01.addRoom(f01r03);

            OneBedRoom f02r01 = new OneBedRoom(name2, add2, pnum2);
            TwoBedRoom f02r02 = new TwoBedRoom(name2, add2, pnum2);
            TwoBedRoom f02r03 = new TwoBedRoom(name2, add2, pnum2);
            Floor f0lr02 = new Floor(name2, add2, pnum2);
            f0lr02.addRoom(f02r01);
            f0lr02.addRoom(f02r02);
            f0lr02.addRoom(f02r03);

            Hotel h2 = new Hotel(name2, add2, pnum2);
            h2.addFloor(f0lr01);
            h2.addFloor(f0lr02);

            hotels.Add(h2);
        }

        public static HotelManager getInstance()
        {
            return hotelManager;
        }

        public List<Hotel> getHotels()
        {
            return hotels;
        }
    }
}
