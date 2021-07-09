using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using oracleTest.DAL;
namespace oracleTest
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public static int id;
        string name;
        int emp_type;
        AddShow add_show;
        AddCustomer add_customer;
        AddBooking add_booking;
        AddDiscount add_discount;
        AddFilm add_film;
        SeataddionalPrice addional_seat_price;
        FilmWorker add_worker;
        int selectedRow = 0;
        int sol = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                la.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                txt_empId.Visible = true;
                txt_empName.Visible = true;
                btn_logIn.Visible = true;

                btn_searchFilmWorkers.TabPages.Remove(CustomerTab);
                btn_searchFilmWorkers.TabPages.Remove(FilmTab);
                btn_searchFilmWorkers.TabPages.Remove(showTab);
                btn_searchFilmWorkers.TabPages.Remove(BookingTab);
                btn_searchFilmWorkers.TabPages.Remove(DiscountTab);
                btn_searchFilmWorkers.TabPages.Remove(SeatPriceTab);
                btn_searchFilmWorkers.TabPages.Remove(WorkerTab);
                btn_searchFilmWorkers.TabPages.Remove(TabReport);
            }
            catch (Exception xe)
            {
                MessageBox.Show("Connection failed, try agine.");
            }
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (btn_logIn.Text == "Log in" && txt_empId.Text != "" && txt_empName.Text != "")
            {
                id = Int32.Parse(txt_empId.Text);
                name = txt_empName.Text;
                try
                {
                    emp_type = DatabaseUse.ValidateUser(id, name);
                    if (emp_type == 1)
                    {
                        btn_searchFilmWorkers.TabPages.Insert(1, FilmTab);
                        btn_searchFilmWorkers.TabPages.Insert(2, WorkerTab);
                        btn_searchFilmWorkers.TabPages.Insert(3, showTab);
                        btn_searchFilmWorkers.TabPages.Insert(4, DiscountTab);
                        btn_searchFilmWorkers.TabPages.Insert(5, SeatPriceTab);
                        btn_searchFilmWorkers.TabPages.Insert(6, TabReport);
                        btn_searchFilmWorkers.TabPages.Insert(6, CustomerTab);
                        btn_searchFilmWorkers.TabPages.Insert(7, BookingTab);
                        btn_logIn.Text = "Log Out";
                        la.Text = name;

                    }
                    else if (emp_type == 2)
                    {
                        btn_searchFilmWorkers.TabPages.Insert(1, CustomerTab);
                        btn_searchFilmWorkers.TabPages.Insert(2, BookingTab);
                        btn_logIn.Text = "Log Out";
                        la.Text = name;
                    }
                    else
                    {
                        MessageBox.Show("Worng ID or Name, try agine!");
                        btn_logIn.Text = "Log in";
                        la.Text = "Please log In";
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }

            }
            else
            {
                try
                {
                    btn_logIn.Text = "Log in";
                    btn_searchFilmWorkers.TabPages.Remove(CustomerTab);
                    btn_searchFilmWorkers.TabPages.Remove(FilmTab);
                    btn_searchFilmWorkers.TabPages.Remove(showTab);
                    btn_searchFilmWorkers.TabPages.Remove(BookingTab);
                    btn_searchFilmWorkers.TabPages.Remove(DiscountTab);
                    btn_searchFilmWorkers.TabPages.Remove(SeatPriceTab);
                    btn_searchFilmWorkers.TabPages.Remove(WorkerTab);
                    btn_searchFilmWorkers.TabPages.Remove(TabReport);
                    la.Text = "Please log In";

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);

                }
            }
        }//done

        /***************************************************************************/
        /*****************************ADD AND SHOW BUTTONS***************************************/
        /***************************************************************************/

        private void btn_showCustomer_Click(object sender, EventArgs e)
        {         
            customer_dgv.Visible = true;
            lb_customerIDinterest.Visible = false;
            lb_customerTypeinterest.Visible = false;
            txt_customerIDinterest.Visible = false;
            txt_customerTypeinterest.Visible = false;
            show_dgv.AutoResizeRows();
            DataSet ds = new DataSet();
            ds = DatabaseUse.getAllColomns("CUSTOMER", null, null);
            customer_dgv.DataSource = ds.Tables[0];
            l1.Visible = true;
            tb_customerID.Visible = true;
            btn_showCustomerInt.Visible = true;

            string tb = tb_customerID.Text;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("customer_name like '%{0}%'", tb);
            customer_dgv.DataSource = dv.ToTable();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            lb_customerIDinterest.Visible = false;
            lb_customerTypeinterest.Visible = false;
            txt_customerIDinterest.Visible = false;
            txt_customerTypeinterest.Visible = false;
            l1.Visible = false;
            tb_customerID.Visible = false;
            btn_showCustomerInt.Visible = false;
            customer_dgv.Visible = false;
            if (emp_type == 2)
            {
                add_customer = new AddCustomer();
                add_customer.Visible = true;
                add_customer.Bounds = new Rectangle(10, 120, 400, 400);
                CustomerTab.Controls.Add(add_customer);
            }
            else
            {
                MessageBox.Show("you have to be a reception employee to add a customer.");
            }


        }//done

        private void btn_getCustomerInterest_Click(object sender, EventArgs e)
        {
            try
            {
                lb_customerIDinterest.Visible = true;
                lb_customerTypeinterest.Visible = true;
                txt_customerIDinterest.Visible = true;
                txt_customerTypeinterest.Visible = true;
                add_customer.Visible = false;
                customer_dgv.Visible = false;
                l1.Visible = false;


                l1.Visible = false;
                tb_customerID.Visible = false;
                btn_showCustomerInt.Visible = false;


            }
            catch (Exception x)
            {

            }
        }

        /***************************************************************************/

        private void btn_addNewShow_Click(object sender, EventArgs e)
        {
            add_show = new AddShow();
            add_show.Visible = true;
            add_show.Bounds = new Rectangle(10, 120, 400, 400);
            showTab.Controls.Add(add_show);
            show_dgv.Visible = false;
            lb_searchShow.Visible = false;
            tb_searchShow.Visible = false;
            btn_searchShow.Visible = false;
        }

        private void brn_showAllShows_Click(object sender, EventArgs e)
        {
            show_dgv.Visible = true;
            lb_searchShow.Visible = true;
            tb_searchShow.Visible = true;
            btn_searchShow.Visible = true;

            DataSet ds = new DataSet();
            List<string> a = new List<string> { };
            a.Add("FILM");
            a.Add("SHOWROOM");
            a.Add("EMPLOYEE");
            List<string> b = new List<string> { };
            b.Add("FILM_ID");
            b.Add("SHOWROOM_ID");
            b.Add("EMPLOYEE_ID");
            ds = DatabaseUse.getAllColomns("show_hall", a, b);
            show_dgv.DataSource = ds.Tables[0];

            string filmName = tb_searchShow.Text;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("film_name like '%{0}%'", filmName);
            show_dgv.DataSource = dv.ToTable();
        }


        /***************************************************************************/
        private void btn_addNewBooking_Click(object sender, EventArgs e)
        {
            lb_searchBooking.Visible = false;
            tb_searchBooking.Visible = false;
            btn_searchBooking.Visible = false;

            if (emp_type == 2)
            {
                booking_dgv.Visible = false;
                add_booking = new AddBooking();
                add_booking.Bounds = new Rectangle(10, 120, 400, 400);
                BookingTab.Controls.Add(add_booking);
            }
            else
            {
                MessageBox.Show("you have to be a reception employee to add a booking.");
            }
        }

        private void btn_viewAllBooking_Click(object sender, EventArgs e)
        {
            booking_dgv.Visible = true;
            lb_searchBooking.Visible = true;
            tb_searchBooking.Visible = true;
            btn_searchBooking.Visible = true;

            DataSet ds = new DataSet();
            List<string> a = new List<string> { };
            a.Add("EMPLOYEE");
            List<string> b = new List<string> { };
            b.Add("EMPLOYEE_ID");
            ds = DatabaseUse.getAllColomns("Booking", a, b);
            booking_dgv.DataSource = ds.Tables[0];

            if(tb_searchBooking.Text!= "")
            {
                int tb = Int32.Parse(tb_searchBooking.Text);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                 DataView dv = dt.DefaultView;
                 dv.RowFilter = string.Format("show_id = {0}", tb);
                 booking_dgv.DataSource = dv.ToTable();
            }
        
        }

        /***************************************************************************/

        private void btn_addNewDiscount_Click(object sender, EventArgs e)
        {
            discount_dgv.Visible = false;
            add_discount = new AddDiscount();
            add_discount.Bounds = new Rectangle(10, 120, 400, 400);
            DiscountTab.Controls.Add(add_discount);
        }

        private void btn_viewAllRules_Click(object sender, EventArgs e)
        {
            discount_dgv.Visible = true;
            DataSet ds = new DataSet();
            List<string> a = new List<string> { };
            a.Add("RULE_ON_FILMTYPE");
            a.Add("RULE_ON_POINTS");
            a.Add("film_type");
            List<string> b = new List<string> { };
            b.Add("RULE_ID");
            b.Add("RULE_ID");
            b.Add("TYPE_ID");

            ds = DatabaseUse.getAllColomns("RULE_DISCOUNT", a, b);
            discount_dgv.DataSource = ds.Tables[0];


        }

        /***************************************************************************/

        private void btn_addFilm_Click(object sender, EventArgs e)
        {
            film_dgv.Visible = false;
            lb_searchFilm.Visible = false;
            tb_searchFilm.Visible = false;
            btn_searchFilm.Visible = false;
            add_film = new AddFilm();
            add_film.Visible = true;
            add_film.Bounds = new Rectangle(10, 120, 400, 400);
            FilmTab.Controls.Add(add_film);

        }

        private void btn_viewAllFilms_Click(object sender, EventArgs e)
        {
            film_dgv.Visible = true;
            lb_searchFilm.Visible = true;
            tb_searchFilm.Visible = true;
            btn_searchFilm.Visible = true;
            List<string> a = new List<string> { };
            a.Add("Film_Has_Type");
            a.Add("Film_Type");
            List<string> b = new List<string> { };
            b.Add("FILM_ID");
            b.Add("TYPE_ID");
            DataSet ds = new DataSet();
            ds = DatabaseUse.getAllColomns("Film", a, b);
            film_dgv.DataSource = ds.Tables[0];

            string tb = tb_searchFilm.Text;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("film_name like '%{0}%'", tb);
            film_dgv.DataSource = dv.ToTable();

        }
        /***************************************************************************/

        private void txt_empId_TextChanged(object sender, EventArgs e)
        {
            id = Int32.Parse(txt_empId.Text);
        }
        /***************************************************************************/
        private void btn_addSeatPrice_Click(object sender, EventArgs e)
        {
            lb_searchSeat.Visible = false;
            tb_searchSeat.Visible = false;
            btn_searchSeats.Visible = false;
            addional_seat_price = new SeataddionalPrice();
            addional_seat_price.Bounds = new Rectangle(10, 120, 400, 400);
            SeatPriceTab.Controls.Add(addional_seat_price);

        }

        private void btn_ViewSeatPrices_Click(object sender, EventArgs e)
        {
            dgv_seatPrices.Visible = true;
            lb_searchSeat.Visible = true;
            tb_searchSeat.Visible = true;
            btn_searchSeats.Visible = true;
            DataSet ds = new DataSet();
            List<string> a = new List<string> { };
            a.Add("SEAT_PRICE");
            a.Add("SHOWROOM");
            List<string> b = new List<string> { };
            b.Add("SEAT_ID");
            b.Add("SHOWROOM_ID");

            ds = DatabaseUse.getAllColomns("SEAT", a, b);
            dgv_seatPrices.DataSource = ds.Tables[0];
            try
            {
                if (tb_searchSeat.Text != "")
                {
                int row = Int32.Parse(tb_searchSeat.Text.ToString());

                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format("show_id  = {0}", row);
                    dgv_seatPrices.DataSource = dv.ToTable();
                }
            }
            catch(Exception aas)
            {
                MessageBox.Show(aas.Message);
            }
        }
        /***************************************************************************/
        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            dgv_worker.Visible = false;
            lb_searchFilmWorkers.Visible = false;
            tb_searchFilmWorkers.Visible = false;
            btn_1.Visible = false;
            add_worker = new FilmWorker();
            add_worker.Bounds = new Rectangle(10, 120, 400, 400);
            WorkerTab.Controls.Add(add_worker);
        }

        private void btn_viewAllWorkers_Click(object sender, EventArgs e)
        {
            dgv_worker.Visible = true;
            lb_searchFilmWorkers.Visible = true;
            tb_searchFilmWorkers.Visible = true;
            btn_1.Visible = true;
            List<string> a = new List<string> { };
            a.Add("FILM");
            List<string> b = new List<string> { };
            b.Add("FILM_ID");
            DataSet ds = new DataSet();
            ds = DatabaseUse.getAllColomns("Film_Workers", a, b);
            dgv_worker.DataSource = ds.Tables[0];

            string filmName = tb_searchFilmWorkers.Text;
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("film_name like '%{0}%'", filmName);
            dgv_worker.DataSource = dv.ToTable();
        }

        /***************************************************************************/
        /*****************************Search***************************************/
        /***************************************************************************/
        private void btn_searchSeats_Click(object sender, EventArgs e)
        {
            btn_ViewSeatPrices.PerformClick();
        }
        private void btn_showCustomerInt_Click(object sender, EventArgs e)
        {
            btn_showCustomer.PerformClick();
        }

        private void btn_searchShow_Click(object sender, EventArgs e)
        {
            brn_showAllShows.PerformClick();
        }

        private void btn_searchBooking_Click(object sender, EventArgs e)
        {
            btn_viewAllBooking.PerformClick();
        }

        private void btn_searchFilm_Click(object sender, EventArgs e)
        {
            btn_viewAllFilms.PerformClick();
        }

        private void btn_searchWorkers_Click(object sender, EventArgs e)
        {

            btn_viewAllWorkers.PerformClick();

        }


        /***************************************************************************/
        /*****************************UPDATES***************************************/
        /***************************************************************************/

        private void customer_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = customer_dgv.Rows[selectedRow];
                    List<object> val = new List<object> { };
                    val.Add(Int32.Parse(row.Cells[0].Value.ToString()));//id
                    val.Add(row.Cells[1].Value.ToString());//name
                    val.Add(row.Cells[2].Value.ToString());//email
                    val.Add(Int32.Parse(row.Cells[3].Value.ToString()));//points
                    val.Add(row.Cells[4].Value.ToString());//num
                    DatabaseUse.updateDB("CUSTOMER", val);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void show_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = show_dgv.Rows[selectedRow];
                List<object> val = new List<object>();
                val.Add(Int32.Parse(row.Cells[3].Value.ToString()));//id
                string x = row.Cells[4].Value.ToString();

                string[] y = x.Split();

                val.Add(y[0]);//date
                val.Add(Int32.Parse(row.Cells[6].Value.ToString()));//price
                val.Add(Int32.Parse(row.Cells[5].Value.ToString()));//points
                DatabaseUse.updateDB("SHOW_HALL", val);
            }
        }

        private void booking_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = booking_dgv.Rows[selectedRow];
                    List<object> val = new List<object>();
                    val.Add(Int32.Parse(row.Cells[1].Value.ToString()));//id
                    string x1 = row.Cells[3].Value.ToString();
                    string[] y1 = x1.Split();

                    val.Add(y1[0]);//date

                    val.Add(Int32.Parse(row.Cells[4].Value.ToString()));//price
                    val.Add(Int32.Parse(row.Cells[7].Value.ToString()));//points
                    DatabaseUse.updateDB("BOOKING", val);
                }
            }

            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }



        }

        private void dgv_seatPrices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = dgv_seatPrices.Rows[selectedRow];
                    List<object> val = new List<object>();
                    val.Add(Int32.Parse(row.Cells[1].Value.ToString()));//id
                    val.Add(Int32.Parse(row.Cells[5].Value.ToString()));//id
                    val.Add(Int32.Parse(row.Cells[4].Value.ToString()));//price
                    DatabaseUse.updateDB("seat_price", val);
                }
            }

            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void discount_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = discount_dgv.Rows[selectedRow];
                    List<object> val = new List<object>();

                    val.Add(Int32.Parse(row.Cells[1].Value.ToString()));//id
                    val.Add(Int32.Parse(row.Cells[2].Value.ToString()));//discount

                    string x1 = row.Cells[3].Value.ToString();
                    string[] y1 = x1.Split();

                    val.Add(y1[0]);//date

                    string x2 = row.Cells[4].Value.ToString();
                    string[] y2 = x2.Split();
                    val.Add(y2[0]);//date

                    if (row.Cells[5].Value.ToString() == "" && row.Cells[6].Value.ToString() == "")
                     DatabaseUse.updateDBDiscount(1, val);

                    else if (row.Cells[5].Value.ToString() == "" && row.Cells[6].Value.ToString() != "")
                    {
                        val.Add(row.Cells[6].Value.ToString());//type
                        DatabaseUse.updateDBDiscount(2, val);
                        btn_viewAllRules.PerformClick();
                    }

                    else if (row.Cells[5].Value.ToString() != "" && row.Cells[6].Value.ToString() == "")
                    {
                        val.Add(Int32.Parse(row.Cells[5].Value.ToString()));//points
                        DatabaseUse.updateDBDiscount(3, val);
                        btn_viewAllRules.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("There is no such discount");
                        btn_viewAllRules.PerformClick();
                    }

                }
            }

            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void film_dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = film_dgv.Rows[selectedRow];
                    List<object> val = new List<object>();
                    val.Add(Int32.Parse(row.Cells[1].Value.ToString()));//id
                    val.Add(row.Cells[2].Value.ToString());//id
                    val.Add(row.Cells[3].Value.ToString());//price
                    val.Add(Int32.Parse(row.Cells[4].Value.ToString()));//id
                   string typeName  =row.Cells[5].Value.ToString();//price
                    val.Add(DatabaseUse.getfilmTypeID(typeName));
                     
                    DatabaseUse.updateDB("Film", val);
                }
            }

            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void dgv_worker_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (selectedRow >= 0)
                {
                    DataGridViewRow row = dgv_worker.Rows[selectedRow];
                    List<object> val = new List<object>();
                    val.Add(Int32.Parse(row.Cells[0].Value.ToString()));//id
                    val.Add(Int32.Parse(row.Cells[1].Value.ToString()));//id
                    val.Add(row.Cells[2].Value.ToString());//id
                    val.Add(row.Cells[3].Value.ToString());//price

                    DatabaseUse.updateDB("Film_workers", val);
                }
            }

            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
        }

        private void vb_reportOption_SelectedValueChanged(object sender, EventArgs e)
        {

 
            
        }

        private void btn_filmReports_Click(object sender, EventArgs e)
        {
            if(sol >0)
            {
                var dts = dgv_reports.DataSource as DataTable;
                dts.Rows.Clear();
                dgv_reports.DataSource = dts;
            }
            dgv_reports.Columns["Column1"].Visible = true;
            dgv_reports.Columns["Column2"].Visible = true;
            dgv_reports.Columns["Column3"].Visible = true;
            dgv_reports.Columns["Column4"].Visible = true;
            dgv_reports.Columns["Column5"].Visible = false;
            dgv_reports.Columns["Column6"].Visible = false;
            dgv_reports.Columns["Column7"].Visible = false;
            dgv_reports.Columns["Column8"].Visible = false;
            dgv_reports.Columns["Column9"].Visible = false;
            label7.Visible = true;
            label9.Visible = true;
            lbl_option.Visible = true;
            dtp_FromDateF.Visible = true;
            dtp_toDateF.Visible = true;
            cb_reportOption.Visible = true;
            lbl_empid.Visible = false;
            txt_emloyee_ID.Visible = false;
            btn_shorResult.Visible = false;
            cb_reportOption.Items.Clear();
            cb_reportOption.ResetText();
            cb_reportOption.Items.Add("Most Booked Film");
            cb_reportOption.Items.Add("Most Profit Film");  
        }

        private void btn_employeeReport_Click(object sender, EventArgs e)
        {
            if (sol > 0)
            {
                var dts = dgv_reports.DataSource as DataTable;
                dts.Rows.Clear();
                dgv_reports.DataSource = dts;
            }
            dgv_reports.Columns["Column1"].Visible = false;
            dgv_reports.Columns["Column2"].Visible = false;
            dgv_reports.Columns["Column3"].Visible = false;
            dgv_reports.Columns["Column4"].Visible = false;
            dgv_reports.Columns["Column5"].Visible = true;
            dgv_reports.Columns["Column6"].Visible = true;
            dgv_reports.Columns["Column7"].Visible = true;
            dgv_reports.Columns["Column8"].Visible = true;
            dgv_reports.Columns["Column9"].Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            lbl_option.Visible = true;
            dtp_FromDateF.Visible = true;
            dtp_toDateF.Visible = true;
            cb_reportOption.Visible = true;
            cb_reportOption.Items.Clear();
            cb_reportOption.ResetText();
            cb_reportOption.Items.Add("Most active Employees");
            cb_reportOption.Items.Add("Get Employee bookings");
        }

        private void btn_shorResult_Click(object sender, EventArgs e)
        {
            showEmployeeBookings();
        }


        private void showEmployeeBookings()
        {
            try
            {
                List<object> a = new List<object> { };
                string x1 = dtp_FromDateF.Text.ToString();
                string[] y1 = x1.Split();

                a.Add(y1[0]);//date
                string x2 = dtp_toDateF.Text.ToString();
                string[] y2 = x2.Split();

                a.Add(y2[0]);//date
                int empID = Int32.Parse(txt_emloyee_ID.Text.ToString());
                DataTable dt = DatabaseUse.getReports(4, a, empID);
                dgv_reports.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("there is no Reception employee with ID :" + txt_emloyee_ID.Text);
            }
        }

        private void cb_reportOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (sol > 0)
                {
                    var dts = dgv_reports.DataSource as DataTable;
                    dts.Rows.Clear();
                    dgv_reports.DataSource = dts;
                }
                sol++;
                if ((cb_reportOption.SelectedItem).ToString() == "Most Booked Film")
                {
                    dgv_reports.Columns["Column1"].Visible = true;
                    dgv_reports.Columns["Column2"].Visible = true;
                    dgv_reports.Columns["Column4"].Visible = false;
                    dgv_reports.Columns["Column3"].Visible = true;
                    dgv_reports.Columns["Column5"].Visible = false;
                    dgv_reports.Columns["Column6"].Visible = false;
                    dgv_reports.Columns["Column7"].Visible = false;
                    dgv_reports.Columns["Column8"].Visible = false;
                    dgv_reports.Columns["Column9"].Visible = false;

                    List<object> a = new List<object> { };
                    string x1 = dtp_FromDateF.Text.ToString();
                    string[] y1 = x1.Split();

                    a.Add(y1[0]);//date
                    string x2 = dtp_toDateF.Text.ToString();
                    string[] y2 = x2.Split();

                    a.Add(y2[0]);//date

                    DataTable dt = DatabaseUse.getReports(1, a, 0);
                    dgv_reports.DataSource = dt;
                }
                else if ((cb_reportOption.SelectedItem).ToString() == "Most Profit Film")
                {
                    dgv_reports.Columns["Column1"].Visible = true;
                    dgv_reports.Columns["Column2"].Visible = true;
                    dgv_reports.Columns["Column4"].Visible = true;
                    dgv_reports.Columns["Column3"].Visible = false;
                    dgv_reports.Columns["Column5"].Visible = false;
                    dgv_reports.Columns["Column6"].Visible = false;
                    dgv_reports.Columns["Column7"].Visible = false;
                    dgv_reports.Columns["Column8"].Visible = false;
                    dgv_reports.Columns["Column9"].Visible = false;

                    List<object> a = new List<object> { };
                    string x1 = dtp_FromDateF.Text.ToString();
                    string[] y1 = x1.Split();

                    a.Add(y1[0]);//date
                    string x2 = dtp_toDateF.Text.ToString();
                    string[] y2 = x2.Split();

                    a.Add(y2[0]);//date

                    DataTable dt = DatabaseUse.getReports(2, a, 0);
                    dgv_reports.DataSource = dt;
                }

                else if ((cb_reportOption.SelectedItem).ToString() == "Most active Employees")
                {
                    dgv_reports.Columns["Column1"].Visible = false;
                    dgv_reports.Columns["Column2"].Visible = false;
                    dgv_reports.Columns["Column3"].Visible = false;
                    dgv_reports.Columns["Column4"].Visible = false;
                    dgv_reports.Columns["Column6"].Visible = true;
                    dgv_reports.Columns["Column5"].Visible = true;
                    dgv_reports.Columns["Column7"].Visible = true;
                    dgv_reports.Columns["Column8"].Visible = true;
                    dgv_reports.Columns["Column9"].Visible = true;

                    lbl_empid.Visible = false;
                    txt_emloyee_ID.Visible = false;
                    btn_shorResult.Visible = false;

                    List<object> a = new List<object> { };
                    string x1 = dtp_FromDateF.Text.ToString();
                    string[] y1 = x1.Split();

                    a.Add(y1[0]);//date
                    string x2 = dtp_toDateF.Text.ToString();
                    string[] y2 = x2.Split();

                    a.Add(y2[0]);//date

                    DataTable dt = DatabaseUse.getReports(3, a, 0);
                    dgv_reports.DataSource = dt;

                }

                else if ((cb_reportOption.SelectedItem).ToString() == "Get Employee bookings")
                {
                    dgv_reports.Columns["Column1"].Visible = false;
                    dgv_reports.Columns["Column2"].Visible = false;
                    dgv_reports.Columns["Column3"].Visible = false;
                    dgv_reports.Columns["Column4"].Visible = false;
                    dgv_reports.Columns["Column6"].Visible = false;
                    dgv_reports.Columns["Column5"].Visible = false;
                    dgv_reports.Columns["Column7"].Visible = false;
                    dgv_reports.Columns["Column8"].Visible = false;
                    dgv_reports.Columns["Column9"].Visible = true;

                    lbl_empid.Visible = true;
                    txt_emloyee_ID.Visible = true;
                    btn_shorResult.Visible = true;


                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_customerIDinterest_TextChanged(object sender, EventArgs e)
        {
            int ty = DatabaseUse.getCustomerInterest(Int32.Parse(txt_customerIDinterest.Text.ToString()));
            string res = DatabaseUse.getTypeNameBasedOnID(ty);
            txt_customerTypeinterest.Text = res;
        }


     }


}


