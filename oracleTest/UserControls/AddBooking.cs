using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using oracleTest.DAL;

namespace oracleTest
{
    public partial class AddBooking : UserControl
    {

        DataTable dt_shows;
        public AddBooking()
        {
            InitializeComponent();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            dt_shows = new DataTable();
            dt_shows = DatabaseUse.getAllId("SHOW_HALL");
            string SrId;
            foreach (DataRow row in dt_shows.Rows)
            {
                SrId = row["SHOW_ID"].ToString();
                cb_shows.Items.Add(SrId);
            }
        }

        private void btn_bookingSave_Click(object sender, EventArgs e)
        {
            try
            {
                txt_bookingId.Text = DatabaseUse.getBookingID().ToString();

                List<string> param = new List<string>();
                param.Add("B_Date");
                param.Add("B_Cus_Date");
                param.Add("B_Seats");
                param.Add("B_Showid");
                param.Add("B_Cusid");
                param.Add("b_empid");

                List<object> val = new List<object>();
                val.Add(dtp_bookingDate.Text);
                if (ch_customerPaid.Checked)
                    val.Add(dtp_bookingDate.Text);
                else val.Add(null);
                val.Add(Int32.Parse(txt_bookingSeatNum.Text.ToString()));
                val.Add(Int32.Parse((cb_shows.SelectedItem).ToString()));
                val.Add(Int32.Parse(txt_bookingCustomer.Text.ToString()));
                val.Add(Form1.id);

                OracleConnection conn = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(conn, "Pr_insert_Booking", param, val);
                DatabaseConnect.CloseConnection(conn);
                saveBookedSeats();

                List<string> p1 = new List<string>();
                p1.Add("customerid");
                p1.Add("showdate");
                p1.Add("bookingid");

                //problem 2 same as 1 
                List<object> v1 = new List<object>();
                v1.Add(Int32.Parse(txt_bookingCustomer.Text.ToString()));
                v1.Add(dtp_bookingDate.Text);
                v1.Add(Int32.Parse(txt_bookingId.Text));
                
                

                conn = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(conn, "Discount_On_points", p1, v1);
                DatabaseConnect.CloseConnection(conn);      
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                this.Visible = false;
            }
        }

        private void cb_shows_SelectedIndexChanged(object sender, EventArgs e)
        {
            int showid = Int32.Parse((cb_shows.SelectedItem).ToString());
            int numberOfAvialableSeats = DatabaseUse.getAvailableSeatsNumber(showid);
            txt_avSeats.Text = numberOfAvialableSeats.ToString();
        }

        private void txt_bookingSeatNum_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void saveBookedSeats()
        {
            try
            {
                int seatNumWanted = Int32.Parse((txt_bookingSeatNum.Text).ToString());
                string selectedSeatRow, selectedSeatNumber, strItem;
                int showid = Int32.Parse((cb_shows.SelectedItem).ToString());
                int showroomID = DatabaseUse.getShowroomID(showid);
                int numOfSeats = 0;
                int seatID = 0;
                int bookingID;
                string[] rowNumber;
                foreach (string selecteditem in clb_seats.CheckedItems)
                {
                    numOfSeats++;
                }
                if (numOfSeats == seatNumWanted)
                {
                    foreach (string selecteditem in clb_seats.CheckedItems)
                    {
                        strItem = selecteditem as String;
                        rowNumber = strItem.Split('-');
                        selectedSeatRow = rowNumber[0];
                        selectedSeatNumber = rowNumber[1];
                        seatID = DatabaseUse.getSeatID(Int32.Parse(selectedSeatRow), Int32.Parse(selectedSeatNumber), showroomID);
                        bookingID = Int32.Parse(txt_bookingId.Text) ;

                        List<string> param = new List<string>();
                        param.Add("seatid");
                        param.Add("bookedid");

                        List<object> val = new List<object>();
                        val.Add(seatID);
                        val.Add(bookingID);

                        DatabaseUse.insertIntoTable("BOOKED_SEATS", param, val);
                    }
                }
                if (numOfSeats != seatNumWanted)
                {
                    try
                    {
                        MessageBox.Show("Worng number of seats, change the number of seats wanted or unselect some of the seats you picked.");
                        bookingID = Int32.Parse(txt_bookingId.Text);
                        DatabaseUse.deleteRow("BOOKING", "BOOKING_ID", txt_bookingId.Text);
                        if (ch_customerPaid.Checked)
                        {
                            List<string> param = new List<string>();
                            param.Add("showid");
                            param.Add("customerid");

                            //problem 2 same as 1 
                            List<object> val = new List<object>();
                            val.Add(Int32.Parse((cb_shows.SelectedItem).ToString()));
                            val.Add(Int32.Parse(txt_bookingCustomer.Text.ToString()));

                            OracleConnection conn = DatabaseConnect.OpenConnection();
                            DatabaseCallFunction.CallProcedure(conn, "remove_customer_added_points", param, val);
                            DatabaseConnect.CloseConnection(conn);
                        }
                    }
                    catch (Exception xe)
                    {
                        MessageBox.Show(xe.Message);
                    }
                }              
            }
            catch (Exception xe)
            {
                MessageBox.Show(xe.Message);
            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txt_bookingSeatNum.Text == "")
            {
                clb_seats.Visible = false;
            }
            else
            {
                int seatNumWanted = Int32.Parse((txt_bookingSeatNum.Text).ToString());
                int availableSeats = Int32.Parse(txt_avSeats.Text.ToString());
                int showid = Int32.Parse((cb_shows.SelectedItem).ToString());

                if (seatNumWanted <= availableSeats)
                {
                    clb_seats.Visible = true;
                    clb_seats.Items.Clear();
                    label2.Visible = true;
                    DataTable dt = DatabaseUse.getAvailableSeatInformation(showid);
                    string ro, rn, seat;
                    foreach (DataRow row in dt.Rows)
                    {
                        ro = row["SEAT_ROW"].ToString();
                        rn = row["SEAT_NUMBER"].ToString();
                        seat = ro + "-" + rn;
                        clb_seats.Items.Add(seat);
                    }
                }

                else if (seatNumWanted > availableSeats) //remove def customers with unpaid booking
                {
                    if (ch_customerPaid.Checked)
                    {
                        int def = seatNumWanted - availableSeats;

                        List<string> param = new List<string>();
                        param.Add("SEATS");

                        //problem 2 same as 1 
                        List<object> val = new List<object>();
                        val.Add(def);

                        OracleConnection conn = DatabaseConnect.OpenConnection();
                        int result = Int32.Parse(DatabaseCallFunction.CallFunction(conn, "cancel_customer", param, val, "res").ToString());
                        DatabaseConnect.CloseConnection(conn);
                        if(result == 1)
                        {
                            int numberOfAvialableSeats = DatabaseUse.getAvailableSeatsNumber(showid);
                            txt_avSeats.Text = numberOfAvialableSeats.ToString();
                            txt_bookingSeatNum.Text = "";
                        }
                    }
                }
            }
        }
    }
}
