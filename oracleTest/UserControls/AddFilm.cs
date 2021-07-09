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
    public partial class AddFilm : UserControl
    {

        DataTable dt_filmType;
        bool flag;
        public AddFilm()
        {
            InitializeComponent();
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {
            w1.Visible = false;
            w2.Visible = false;
            txt_workerName.Visible = false;
            txt_workerRole.Visible = false;
            btn_addWorker.Visible = false;

            dt_filmType = new DataTable();
            dt_filmType = DatabaseUse.getTypeNames();
            string SrId;
            foreach (DataRow row in dt_filmType.Rows)
            {
                SrId = row["FILM_TYPE"].ToString();
                clb_FilmType.Items.Add(SrId);
            }


            //make another for worker role
        }

        private void btn_addWorker_Click(object sender, EventArgs e)
        {
            w1.Visible = true;
            w2.Visible = true;
            txt_workerName.Visible = true;
            txt_workerRole.Visible = true;
            clb_FilmType.Visible = false;
            label25.Visible = false;
            txt_workerName.Text = "";   
            flag = true;
        }

        private void btn_saveNewFilm_Click(object sender, EventArgs e)
        {
            if(flag ==false && txt_filmName.Text!= "")
            {
                try
                {
                    List<string> param = new List<string>();
                    param.Add("F_Name");
                    param.Add("F_Des");
                    param.Add("f_dur");

                    //problem 2 same as 1 
                    List<object> val = new List<object>();
                    val.Add(txt_filmName.Text);
                    val.Add(tb_desc.Text);
                    val.Add(Int32.Parse(txt_duration.Text.ToString()));

                    OracleConnection conn = DatabaseConnect.OpenConnection();
                    DatabaseCallFunction.CallProcedure(conn, "Pr_insert_Film", param, val);
                    int f_Id = DatabaseUse.getID("FILM_ID", "FILM", "FILM_NAME", txt_filmName.Text.ToString());
                    String strItem;
                    foreach (string selecteditem in clb_FilmType.CheckedItems)
                        {
                            strItem = selecteditem as String;
                            param = new List<string>();
                            val = new List<object>();
                            param.Add("F_Id");
                            param.Add("F_type");
                            val.Add(f_Id);
                            val.Add(strItem);
                            DatabaseCallFunction.CallProcedure(conn, "Pr_insert_Film_type", param, val);

                        }
                   
                    DatabaseConnect.CloseConnection(conn);
                    this.Visible = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
            else if (flag == true)
            {
                try
                {
                    int id = DatabaseUse.getID("FILM_ID", "FILM", "FILM_NAME", txt_filmName.Text.ToString());
                    List<string> param = new List<string>();
                    param.Add("W_Name");
                    param.Add("W_Role");
                    param.Add("filmid");

                    List<object> val = new List<object>();
                    val.Add(txt_filmName.Text);
                    val.Add(txt_workerRole.Text);
                    val.Add(id);

                    OracleConnection conn = DatabaseConnect.OpenConnection();

                    DatabaseCallFunction.CallProcedure(conn, "Pr_insert_Film_type", param, val);

                    DatabaseConnect.CloseConnection(conn);
                    w1.Visible = false;
                    w2.Visible = false;
                    txt_workerName.Visible = false;
                    txt_workerRole.Visible = false;
                    clb_FilmType.Visible = true;
                    label25.Visible = true;
                    this.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Worng input, Pleas enter the date agine");
                this.Visible = false;
            }
            }

        private void clb_FilmType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }





    }

