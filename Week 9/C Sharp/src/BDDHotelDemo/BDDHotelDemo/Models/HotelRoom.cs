using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDHotelDemo.Models
{
    public class HotelRoom
    {
        public HotelRoom(int roomNo, RoomType roomType, int maxOccupancy, decimal price)
        {
            RoomNumber = roomNo;
            HotelRoomType = roomType;
            MaxOccupancy = maxOccupancy;
            PricePerNight = price;
        }

        public int RoomNumber { get; set; }
        public RoomType HotelRoomType { get; set; }
        public int MaxOccupancy { get; set; }
        public decimal PricePerNight { get; set; }
    }

    public enum RoomType
    {
        Single,
        Double,
        Suite
    }
}
