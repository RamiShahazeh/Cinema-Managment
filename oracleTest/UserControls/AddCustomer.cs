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
    public partial class AddCustomer : UserControl
    {
        static int cID;
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_SaveNewCustomer_Click(object sender, EventArgs e)
        {
            if (txt_CustomerName.Text != "" && txt_CustomerName.Text != "")
            {
                try
                {
                    List<string> param = new List<string>();
                    param.Add("C_Name");
                    param.Add("C_Email");
                    param.Add("C_Phone");
                    param.Add("c_empid");

                    List<object> val = new List<object>();
                    val.Add(txt_CustomerName.Text.ToString());
                    val.Add(txt_CustomerEmail.Text.ToString());
                    val.Add(txt_CustomerPH.Text.ToString());
                    val.Add(Form1.id);

                    OracleConnection conn = DatabaseConnect.OpenConnection();

                    DatabaseUse.insertIntoTable("CUSTOMER", param, val);
                    DatabaseConnect.CloseConnection(conn);
                }

                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    this.Visible = false;
                }
            }
            else
                MessageBox.Show("Input Error, Please try agine");
                this.Visible = false;
        }




    }
        }

