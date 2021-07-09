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
    public partial class AddDiscount : UserControl
    {

        DataTable dt_discount;
        public AddDiscount()
        {
            InitializeComponent();
        }
        private void AddDiscount_Load(object sender, EventArgs e)
        {
            dt_discount = new DataTable();
            dt_discount = DatabaseUse.getTypeNames();
            string SrId;
            foreach (DataRow row in dt_discount.Rows)
            {
                SrId = row["FILM_TYPE"].ToString();
                cb_filmType.Items.Add(SrId);
            }
        }

        private void btn_saveNewDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> param = new List<string>();
                param.Add("Dis");
                param.Add("S_Date");
                param.Add("e_date");

                //problem 2 same as 1 
                List<object> val = new List<object>();
                val.Add(Int32.Parse(txt_Discount.Text));
                val.Add(dtp_DisStartDate.Text);
                val.Add(dtp_DisEndDate.Text);

                if(!(rb_filmType.Checked) && !(rb_points.Checked))
                {
                    //discount on all shows
                    OracleConnection conn = DatabaseConnect.OpenConnection();
                    DatabaseCallFunction.CallProcedure(conn, "Pr_insert_rule_discount", param, val);
                    DatabaseConnect.CloseConnection(conn);
                    this.Visible = false;

                }
                else if((rb_filmType.Checked))
                {
                    param.Add("typeid");
                    string film_type = (cb_filmType.SelectedItem).ToString();
                    DataTable dt = new DataTable();
                    int id = DatabaseUse.getID("TYPE_ID", "FILM_TYPE", "FILM_TYPE", film_type);
                    
                    val.Add(id);
                    OracleConnection conn = DatabaseConnect.OpenConnection();
                    DatabaseCallFunction.CallProcedure(conn, "Pr_insert_ruleOnType", param, val);
                    DatabaseConnect.CloseConnection(conn);
                    this.Visible = false;
                }
                else if((rb_points.Checked))
                {
                    param.Add("min_points");
                    val.Add(Int32.Parse(txt_MinPoints.Text.ToString()));
                    OracleConnection conn = DatabaseConnect.OpenConnection();
                    DatabaseCallFunction.CallProcedure(conn, "Pr_insert_ruleOnPoints", param, val);
                    DatabaseConnect.CloseConnection(conn);
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("error!!");
                    this.Visible = false;
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
