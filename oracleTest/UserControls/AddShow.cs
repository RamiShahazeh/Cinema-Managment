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
    public partial class AddShow : UserControl
    {

        DataTable dt_showRoom, dt_film;
        public AddShow()
        {
            InitializeComponent();
        }

        private void AddShow_Load(object sender, EventArgs e)
        {
            dt_showRoom = new DataTable();
            dt_showRoom = DatabaseUse.getAllId("SHOWROOM");
            string SrId;
            foreach (DataRow row in dt_showRoom.Rows)
            {
                 SrId = row["SHOWROOM_ID"].ToString();
                 cb_showroomId.Items.Add(SrId);
            }

            dt_film = new DataTable();
            dt_film = DatabaseUse.getfilmNames();
            string filmName;
            foreach (DataRow row in dt_film.Rows)
            {
                filmName = row["FILM_NAME"].ToString();
                cb_filmName.Items.Add(filmName);
            }
        }

        private void btn_saveNewShow_Click(object sender, EventArgs e)
        {

            try
            {
            List<string> param = new List<string>();
            param.Add("S_Date");
            param.Add("S_points");
            param.Add("Showr_Id");
            param.Add("F_Id");
            param.Add("S_Price");
            param.Add("em_id");
                
            List<object> val = new List<object>();
            val.Add(dtp_ShowDate.Text);
            val.Add(Int32.Parse(txt_showPoints.Text.ToString()));
            val.Add(Int32.Parse((cb_showroomId.SelectedItem).ToString()));

            string film_Name = (cb_filmName.SelectedItem).ToString();
            DataTable dt = new DataTable();
            int f_id = DatabaseUse.getID("FILM_ID" , "FILM", "FILM_NAME",film_Name);
            val.Add(f_id);
            val.Add(Int32.Parse(txt_showPrice.Text.ToString()));
            val.Add(Form1.id);

              OracleConnection conn =  DatabaseConnect.OpenConnection();

              DatabaseCallFunction.CallProcedure(conn, "Pr_insert_show", param, val);
              DatabaseConnect.CloseConnection(conn);
              this.Visible = false;
            }

            catch(Exception ee)
            {
                MessageBox.Show(dtp_ShowDate.Text + ee.Message);
            }
        }

        private void dtp_ShowDate_ValueChanged(object sender, EventArgs e)
        {

        }





    }
}
