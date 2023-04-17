using BookingApp.Core.Contracts;
using BookingApp.Models.Bookings;
using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Hotels;
using BookingApp.Models.Hotels.Contacts;
using BookingApp.Models.Rooms;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Repositories;
using BookingApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingApp.Core
{
    public class Controller : IController
    {
        private HotelRepository hotels;
        public Controller()
        {
            hotels = new HotelRepository();
        }
        public string AddHotel(string hotelName, int category)
        {
            if (hotels.Select(hotelName) != null)
            {
                return String.Format(OutputMessages.HotelAlreadyRegistered, hotelName);
            }
            Hotel hotel = new Hotel(hotelName, category);
            hotels.AddNew(hotel);
            return String.Format(OutputMessages.HotelSuccessfullyRegistered,category, hotelName);
        }

        public string BookAvailableRoom(int adults, int children, int duration, int category)
        {
            if (hotels.All().FirstOrDefault(h => h.Category == category) == null)
            {
                return String.Format(OutputMessages.CategoryInvalid,category);
            }

            var orderHotels = hotels
                .All()
                .Where(h => h.Category == category)
                .OrderBy(h => h.FullName);

            foreach (var hotel in orderHotels)
            {
                IRoom room = hotel.Rooms
                    .All()
                    .Where(p => p.PricePerNight > 0)
                    .OrderBy(p => p.BedCapacity)
                    .FirstOrDefault(r => r.BedCapacity >= adults + children);

                if (room != null)
                {
                    int bookingNumber = hotel.Bookings.All().Count() + 1;

                    IBooking booking = new Booking(room,duration,adults,children,bookingNumber);

                    hotel.Bookings.AddNew(booking);

                    return String.Format(OutputMessages.BookingSuccessful, bookingNumber, hotel.FullName);
                }
            }

            return String.Format(OutputMessages.RoomNotAppropriate);
        }

        public string HotelReport(string hotelName)
        {
            IHotel hotel = hotels.Select(hotelName);
            if (hotel == null )
            {
                return String.Format(OutputMessages.HotelNameInvalid,hotelName);
            }
            
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Hotel name: {hotel.FullName}");
            sb.AppendLine($"--{hotel.Category} star hotel");
            sb.AppendLine($"--Turnover: {hotel.Turnover:f2} $");
            sb.AppendLine($"--Bookings:");

            if (hotel.Bookings.All().Count() == 0)
            {
                sb.AppendLine();
                sb.AppendLine("none");
            }
            else
            {
                foreach (var booking in hotel.Bookings.All())
                {
                    sb.AppendLine();
                    sb.AppendLine(booking.BookingSummary());
                }
            }

            return sb.ToString().Trim();
        }

        public string SetRoomPrices(string hotelName, string roomTypeName, double price)
        {
            IHotel hotel = hotels.Select(hotelName);

            if (hotel == null)
            {
                return String.Format(OutputMessages.HotelNameInvalid);
            }

            if (roomTypeName != "Apartment" && roomTypeName != "Studio" && roomTypeName != "DoubleBed")
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
            
            IRoom room = hotel.Rooms.Select(roomTypeName);
            if (room == null)
            {
                return String.Format(OutputMessages.RoomTypeNotCreated);
            }

            if (room.PricePerNight != 0) 
            {
                throw new InvalidOperationException(ExceptionMessages.PriceAlreadySet);
            }

            room.SetPrice(price);
            return String.Format(OutputMessages.PriceSetSuccessfully, roomTypeName, hotelName);
        }

        public string UploadRoomTypes(string hotelName, string roomTypeName)
        {
            if (hotels.Select(hotelName) == null)
            {
                return String.Format(OutputMessages.HotelNameInvalid, hotelName);
            }

            IHotel hotel = hotels.Select(hotelName);
            if (hotel.Rooms.Select(roomTypeName) != null)
            {
                return String.Format(OutputMessages.RoomTypeAlreadyCreated);
            }
      
            Room room;
            if (roomTypeName == "Apartment")
            {
                room = new Apartment();
                return AddRoomToTheHotel(hotelName, room);
            }
            else if (roomTypeName == "Studio")
            {
                room = new Studio();
                return AddRoomToTheHotel(hotelName, room);
            }
            else if (roomTypeName == "DoubleBed")
            {
                room = new DoubleBed();
                return AddRoomToTheHotel(hotelName, room);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.RoomTypeIncorrect);
            }
        }

        private string AddRoomToTheHotel(string hotelName, IRoom room) 
        {
            foreach (var hotel in hotels.All())
            {
                if (hotel.FullName == hotelName)
                {
                    hotel.Rooms.AddNew(room);
                    return String.Format(OutputMessages.RoomTypeAdded,room.GetType().Name, hotelName);
                }
            }

            return null;
        }
    }
}
