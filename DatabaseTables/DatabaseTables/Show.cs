using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Show : Showroom
    {
        int showId;
        DateTime showDate;
        int showPoints;
        int filmId;
        int showPrice;

        public Show(int s_id, DateTime s_date, int s_points, int sr_id, int f_id, int s_price)
            : base(sr_id)
        {
            this.showId = s_id;
            this.showDate = s_date;
            this.showPoints = s_points;
            this.filmId = f_id;
            this.showPrice = s_price;
        }
    }
}

