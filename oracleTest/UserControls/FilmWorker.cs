using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using oracleTest.DAL;
using Oracle.DataAccess.Client;

namespace oracleTest
{
    public partial class FilmWorker : UserControl
    {
        DataTable dt_film;
        public FilmWorker()
        {
            InitializeComponent();
        }

        private void FilmWorker_Load(object sender, EventArgs e)
        {
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
            param.Add("W_Name");
            param.Add("W_Role");
            param.Add("filmid");
                
            List<object> val = new List<object>();
            val.Add(txt_workerName.Text);
            val.Add(txt_workerRole.Text);

            string film_Name = (cb_filmName.SelectedItem).ToString();
            DataTable dt = new DataTable();
            int f_id = DatabaseUse.getID("FILM_ID" , "FILM", "FILM_NAME",film_Name);
            val.Add(f_id);

             OracleConnection conn =  DatabaseConnect.OpenConnection();

             DatabaseCallFunction.CallProcedure(conn, "Pr_insert_Film_workers", param, val);
             DatabaseConnect.CloseConnection(conn);
            //  this.Visible = false;
            }

            catch(Exception ee)
            {
                MessageBox.Show( ee.Message);
            }
        
        }
    }
}
