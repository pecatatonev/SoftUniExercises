using FrontDeskApp;
using NUnit.Framework;
using System;
using System.Transactions;

namespace BookigApp.Tests
{
    public class Tests
    {
        Room room;
        Booking booking;
        Hotel hotel;
        [SetUp]
        public void Setup()
        {
            room = new Room(5, 5.5);
            booking = new Booking(3, room, 5);
            hotel = new Hotel("Kotva",5);
            hotel.AddRoom(room);
        }

        [Test]
        public void CheckRoomConstructor()
        {
            int expectedBedCapacity = 5;
            double expectedPricePerNight = 5.5;

            Assert.AreEqual(expectedBedCapacity, room.BedCapacity);
            Assert.AreEqual(expectedPricePerNight, room.PricePerNight);
        }

        [TestCase(-10)]
        [TestCase(-5)]
        [TestCase(0)]
        public void CheckRoomBedCapacityThrowException(int bedCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Room(bedCapacity, 20.5));
        }

        [TestCase(-10.2)]
        [TestCase(-5)]
        [TestCase(0)]
        public void CheckRoomPricePerNightThrowException(double pricePerNight)
        {
            Assert.Throws<ArgumentException>(() => new Room(5, pricePerNight));
        }

        [Test]
        public void CheckBookingConstructor()
        {
            int expectedBookingNumber = 3;
            Room expectedRoom = room;
            double expectedResidenceDuration = 5;

            Assert.AreEqual(expectedBookingNumber, booking.BookingNumber);
            Assert.AreEqual(expectedRoom, booking.Room);
            Assert.AreEqual(expectedResidenceDuration, booking.ResidenceDuration);
        }

        [Test]
        public void CheckHotelConstructor()
        {
            string expectedName = "Kotva";
            int expectedCategory = 5;

            Assert.AreEqual(expectedName, hotel.FullName);
            Assert.AreEqual(expectedCategory, hotel.Category);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("    ")]
        [TestCase("         ")]
        public void CheckHotelFullNameThrowException(string fullName)
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(fullName, 5));
        }

        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(6)]
        [TestCase(10)]
        public void CheckHotelCategoryThrowException(int category)
        {
            Assert.Throws<ArgumentException>(() => new Hotel("Kotva", category));
        }

        [Test]
        public void CheckHotelMethodAddRoom()
        {
            hotel.AddRoom(room);

            Assert.AreEqual(2,hotel.Rooms.Count);

            hotel.AddRoom(new Room(3, 50));

            Assert.AreEqual(3, hotel.Rooms.Count);

        }

        [TestCase(-10)]
        [TestCase(0)]
        public void CheckHotelMethodBookRoomThrowExceptionWhenAdutsNotCorrect(int adults)
        {
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(adults, 2 , 3, 66.5));
        }

        [TestCase(-10)]
        [TestCase(-1)]
        public void CheckHotelMethodBookRoomThrowExceptionWhenChildrenNotCorrect(int children)
        {
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(2, children, 3, 66.5));
        }

        [TestCase(-10)]
        [TestCase(-1)]
        [TestCase(0)]
        public void CheckHotelMethodBookRoomThrowExceptionWhenDurationTimeNotCorrect(int residanceDuration)
        {
            Assert.Throws<ArgumentException>(() => hotel.BookRoom(2, 0, residanceDuration, 66.5));
        }

        [Test]
        public void CheckHotelMethodBookRoom()
        {
            hotel.BookRoom(2, 0, 2, 50);
            Assert.AreEqual(1, hotel.Bookings.Count);
            //turn over residenceDuration * room.PricePerNight
            double expectedTurnOver = 2 * 5.5;
            Assert.AreEqual(expectedTurnOver,hotel.Turnover);

        }
    }
}