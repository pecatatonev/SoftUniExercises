using BookingApp.Models.Bookings.Contracts;
using BookingApp.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Repositories
{
    public class BookingRepository : IRepository<IBooking>
    {
        public BookingRepository()
        {
            bookings = new List<IBooking>();
        }
        private List<IBooking> bookings;
        public void AddNew(IBooking model)
        {
            bookings.Add(model);
        }

        public IReadOnlyCollection<IBooking> All()
        {
            return bookings.AsReadOnly();
        }

        public IBooking Select(string criteria)
        {
            bookings.FirstOrDefault(p => p.BookingNumber == int.Parse(criteria));
            foreach (var booking in bookings)
            {
                if (booking.BookingNumber == int.Parse(criteria))
                {
                    return booking;
                }
            }

            return null;
        }
    }
}
