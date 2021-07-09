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
    public partial class SeataddionalPrice : UserControl
    {

        DataTable dt_shows, dt_seats;
        public SeataddionalPrice()
        {
            InitializeComponent();
        }

        private void SeataddionalPrice_Load(object sender, EventArgs e)
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

        private void cb_shows_SelectedValueChanged(object sender, EventArgs e)
        {
            int showid = Int32.Parse(cb_shows.SelectedItem.ToString());
            dt_seats = new DataTable();
            dt_seats = DatabaseUse.getSeatInfo(showid);
            string ro, rn, seat;
            foreach (DataRow row in dt_seats.Rows)
            {
                ro = row["SEAT_ROW"].ToString();
                rn = row["SEAT_NUMBER"].ToString();
                seat = ro + "-" + rn;
                clb_seats.Items.Add(seat);
            }

            l1.Visible = true;
            l3.Visible = true;
            clb_seats.Visible = true;
            txt_addionalPrice.Visible = true;
        }

        private void btn_saveNewSeatPrice_Click(object sender, EventArgs e)
        {
            string strItem, selectedSeatRow, selectedSeatNumber;
            string[] rowNumber;
            int seatID, showroomID ;
            int showID = Int32.Parse(cb_shows.SelectedItem.ToString());
            showroomID = DatabaseUse.getShowroomID(showID);
            if (txt_addionalPrice.Text != "")
            {
                int addionalPrice = Int32.Parse(txt_addionalPrice.Text.ToString());
                foreach (string selecteditem in clb_seats.CheckedItems)
                {
                    strItem = selecteditem as String;
                    rowNumber = strItem.Split('-');
                    selectedSeatRow = rowNumber[0];
                    selectedSeatNumber = rowNumber[1];
                    seatID = DatabaseUse.getSeatID(Int32.Parse(selectedSeatRow), Int32.Parse(selectedSeatNumber), showroomID);

                    List<string> param = new List<string>();
                    param.Add("seatid");
                    param.Add("showid");
                    param.Add("addprice");

                    //problem 2 same as 1 
                    List<object> val = new List<object>();
                    val.Add(seatID);
                    val.Add(showID);
                    val.Add(addionalPrice);

                    OracleConnection conn = DatabaseConnect.OpenConnection();
                    DatabaseCallFunction.CallProcedure(conn, "add_seat_additional_price", param, val);
                    DatabaseConnect.CloseConnection(conn);
                    this.Visible = false;
                }
            }
            else
                MessageBox.Show("please enter addional price to add it the the selected seats.");
        }
    }
}
