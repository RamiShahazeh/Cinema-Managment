using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Seat : Showroom
    {
        int seatId;
        int seatRow;
        int seatNumber;

        public Seat(int s_id, int s_row, int s_number, int sr_id)
            : base(sr_id)
        {
            this.seatId = s_id;
            this.seatRow = s_row;
            this.seatNumber = s_number;
        }
    }

    class SeatPrice : Seat
    {
        int seatAdditionalPrice;
        int showId;
        float seatPrice;
        float totalPrice;

        public SeatPrice(int seat_id, int s_row, int s_number, int sr_id, int show_id,
            int s_additional_price, float s_price, float total_price)
            : base(seat_id, s_row, s_number, sr_id)
        {
            this.seatAdditionalPrice = s_additional_price;
            this.showId = show_id;
            this.seatPrice = s_price;
            this.totalPrice = total_price;
        }
    }

    class SeatStatus : Seat
    {
        int seatStatus;

        public SeatStatus(int seat_id, int s_row, int s_number, int sr_id, int s_status)
            : base(seat_id, s_row, s_number, sr_id)
        {
            this.seatStatus = s_status;
        }

    }


}
