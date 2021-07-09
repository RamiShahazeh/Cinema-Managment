using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Booking
    {
        int bookingId;
        DateTime bookingDateTime;
        DateTime CustomerPaidTime;
        int seats;
        int showId;
        int customerId;
        int employeeId;
        int bookingCanceled = 0;

        public Booking(int b_id, DateTime b_date, DateTime c_paid_date, int num_seats, int s_id, int c_id,
            int e_id)
        {
            this.bookingId = b_id;
            this.bookingDateTime = b_date;
            this.CustomerPaidTime = c_paid_date;
            this.seats = num_seats;
            this.showId = s_id;
            this.customerId = c_id;
            this.employeeId = e_id;
        }

    }

    class BookedSeats : Booking
    {
        int seatId;

        public BookedSeats(int b_id, DateTime b_date, DateTime c_paid_date, int num_seats, int show_id, int c_id,
            int e_id, int seat_id)
            : base(b_id, b_date, c_paid_date, num_seats, show_id, c_id, e_id)
        {
            this.seatId = seat_id;
        }
    }
}
