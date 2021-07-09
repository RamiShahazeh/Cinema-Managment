using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
namespace oracleTest.DAL
{
    class DatabaseUse
    {   
        public static int ValidateUser(int id, string name)
        {
            string funcName = "validate_user";
            List<string> funcArgs = new List<string>();
            funcArgs.Add("e_id");
            funcArgs.Add("e_name");
            List<object> funcValues = new List<object>();
            funcValues.Add(id);
            funcValues.Add(name);

            OracleConnection con = DatabaseConnect.OpenConnection();
            int role_id = int.Parse((DatabaseCallFunction.CallFunction(con, funcName, funcArgs, funcValues, "re_value")).ToString());
            DatabaseConnect.CloseConnection(con);
            return role_id;
        }

        public static DataTable getAllId(string tableName)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            if (tableName == "SHOW_HALL")
            {
                ad = new OracleDataAdapter("select SHOW_ID from " + tableName, con); //SHOW_HALL don't work
                ad.Fill(dt);
                DatabaseConnect.CloseConnection(con);
                return dt;
            }
            else
            {
                ad = new OracleDataAdapter("SELECT " + tableName + "_ID FROM " + tableName, con); //SHOW_HALL don't work
                ad.Fill(dt);
                DatabaseConnect.CloseConnection(con);
                return dt;
            }

        }

        public static int getID(string selectParam, string tableName, string whereParam, string equalsParam)
        {
            int Id = 0;
            try
            {
                OracleDataAdapter ad = new OracleDataAdapter();
                DataTable dt = new DataTable();
                OracleConnection con = DatabaseConnect.OpenConnection();
                ad = new OracleDataAdapter("SELECT " + selectParam + " FROM " + tableName + " WHERE " + whereParam + " = '" + equalsParam + "'", con);
                ad.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Id = (Int32.Parse(row[selectParam].ToString()));
                }
                DatabaseConnect.CloseConnection(con);
                return Id;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }


        public static int getBookingID()
        {
            OracleConnection con = DatabaseConnect.OpenConnection();
            List<string> param = new List<string> { };
            List<object> val = new List<object> { };
            int id = Int32.Parse(DatabaseCallFunction.CallFunction(con, "Pr_get_booking_id", param, val, "bookedid").ToString());
            DatabaseConnect.CloseConnection(con);
            return id;
        }

        public static int getPoints(int cID)
        {
            int p = 0;
            try
            {
                OracleDataAdapter ad = new OracleDataAdapter();
                DataTable dt = new DataTable();
                OracleConnection con = DatabaseConnect.OpenConnection();
                ad = new OracleDataAdapter("SELECT CUSTOMER_POINTS FROM CUSTOMER  WHERE CUSTOMER_ID = " + cID, con);
                ad.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    p = (Int32.Parse(row["CUSTOMER_POINTS"].ToString()));
                }
                DatabaseConnect.CloseConnection(con);
                return p;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public static int getfilmTypeID(string filmType)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            ad = new OracleDataAdapter("SELECT TYPE_ID FROM FILM_TYPE WHERE film_type = '" + filmType + "'", con);
            ad.Fill(dt);
            int fid=0;
            foreach (DataRow row in dt.Rows)
            {
                fid = (Int32.Parse(row["TYPE_ID"].ToString()));
            }
            DatabaseConnect.CloseConnection(con);
            return fid;
        }

        public static DataTable getfilmNames()
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            ad = new OracleDataAdapter("SELECT FILM_NAME FROM FILM", con);
            ad.Fill(dt);
            DatabaseConnect.CloseConnection(con);
            return dt;
        }

        public static DataTable getTypeNames()
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            ad = new OracleDataAdapter("SELECT FILM_TYPE FROM FILM_TYPE", con);
            ad.Fill(dt);
            DatabaseConnect.CloseConnection(con);
            return dt;
        }

        public static string getTypeNameBasedOnID(int typeid)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            ad = new OracleDataAdapter("SELECT FILM_TYPE FROM FILM_TYPE where type_id = " + typeid, con);
            ad.Fill(dt);
            string result = "";
            foreach (DataRow row in dt.Rows)
            {
                result = (row["film_type"].ToString());
            }
            DatabaseConnect.CloseConnection(con);
            return result;
        }


        public static DataSet getAllColomns(string tableName, List<string> joinTable, List<string> joinParm)
        {
            DataSet ds = new DataSet();
            OracleDataAdapter ad = new OracleDataAdapter();
            OracleConnection con = DatabaseConnect.OpenConnection();
            string sql = "select * from " + tableName;
            if (joinTable == null)
            {
                ad = new OracleDataAdapter(sql, con);
                ad.Fill(ds);
                DatabaseConnect.CloseConnection(con);
                return ds;
            }

            else
            {
                int count = joinTable.Count();
                string joinSql = "";
                for (int i = 0; i < count; i++)
                {
                    joinSql = joinSql + " left join " + joinTable[i] + " using ( " + joinParm[i] + " ) ";
                }

                ad = new OracleDataAdapter(sql + joinSql, con);
                ad.Fill(ds);
                DatabaseConnect.CloseConnection(con);
                return ds;


            }
        }

        public static void insertIntoTable(string tableName, List<string> param, List<object> val)
        {
            OracleConnection con = DatabaseConnect.OpenConnection();
            if (tableName == "SHOW_HALL")
            {
                DatabaseCallFunction.CallProcedure(con, "Pr_insert_show", param, val);
                DatabaseConnect.CloseConnection(con);
            }
            else if (tableName == "CUSTOMER")
            {
                DatabaseCallFunction.CallProcedure(con, "Pr_insert_Customer", param, val);
                DatabaseConnect.CloseConnection(con);

            }
            else if (tableName == "BOOKED_SEATS")
            {
                DatabaseCallFunction.CallProcedure(con, "Pr_insert_booked_seat", param, val);
                DatabaseConnect.CloseConnection(con);
            }
        }

        public static int getAvailableSeatsNumber(int showid)
        {
            List<string> param = new List<string>();
            param.Add("showid");

            List<object> val = new List<object>();
            val.Add(showid);

            OracleConnection con = DatabaseConnect.OpenConnection();
            int result = Int32.Parse(DatabaseCallFunction.CallFunction(con, "get_available_seats", param, val, "av_seats").ToString());
            DatabaseConnect.CloseConnection(con);
            return result;

        }

        public static int getCustomerInterest(int customerid)
        {
            List<string> param = new List<string>();
            param.Add("customerid");

            List<object> val = new List<object>();
            val.Add(customerid);

            OracleConnection con = DatabaseConnect.OpenConnection();
            int result = Int32.Parse(DatabaseCallFunction.CallFunction(con, "get_customer_interest", param, val, "f_type").ToString());
            DatabaseConnect.CloseConnection(con);
            return result;

        }

        public static int getShowroomID(int showid)
        {
            List<string> param = new List<string>();
            param.Add("showid");

            List<object> val = new List<object>();
            val.Add(showid);
            OracleConnection con = DatabaseConnect.OpenConnection();
            int result = Int32.Parse(DatabaseCallFunction.CallFunction(con, "get_showroom_id", param, val, "showroomid").ToString());
            DatabaseConnect.CloseConnection(con);
            return result;

        }

        public static DataTable getAvailableSeatInformation(int showid)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            int srid = getShowroomID(showid);
            ad = new OracleDataAdapter("select SEAT_ID, SEAT_ROW, SEAT_NUMBER FROM SEAT JOIN SEAT_PRICE USING(SEAT_ID) WHERE STATUS = 1 AND SHOWROOM_ID =" + srid, con);
            ad.Fill(dt);
            DatabaseConnect.CloseConnection(con);
            return dt;
        }


        public static int getSeatID(int seatRow, int seatNumber, int srID)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            int seatid = 0;
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            ad = new OracleDataAdapter("SELECT SEAT_ID FROM SEAT WHERE SEAT_ROW = " + seatRow + " AND SEAT_NUMBER = " + seatNumber + " AND SHOWROOM_ID = " + srID, con);
            ad.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                seatid = (Int32.Parse(row["SEAT_ID"].ToString()));
            }
            DatabaseConnect.CloseConnection(con);
            return seatid;
        }

        public static void deleteRow(string tableName, string whereParam, string equalParam)
        {
            OracleConnection con = DatabaseConnect.OpenConnection();
            string sql = "DELETE FROM " + tableName + " WHERE " + whereParam + " = " + equalParam;
            OracleCommand command = new OracleCommand(sql, con);
            command.ExecuteNonQuery();
            DatabaseConnect.CloseConnection(con);
        }

        public static DataTable getSeatInfo(int showid)
        {
            OracleDataAdapter ad = new OracleDataAdapter();
            DataTable dt = new DataTable();
            OracleConnection con = DatabaseConnect.OpenConnection();
            int srid = getShowroomID(showid);
            ad = new OracleDataAdapter("select SEAT_ID, SEAT_ROW, SEAT_NUMBER FROM SEAT JOIN SEAT_PRICE USING(SEAT_ID) WHERE SHOWROOM_ID =" + srid, con);
            ad.Fill(dt);
            DatabaseConnect.CloseConnection(con);
            return dt;

        }



        public static void updateDB(string tableName , List<object> a)
        {
            if(tableName=="CUSTOMER")
            {
                OracleConnection con = DatabaseConnect.OpenConnection();

                string sql = "UPDATE " + tableName + " SET " + " CUSTOMER_NAME =  '" + a[1] + "', " +
                                                                " CUSTOMER_EMAIL =  '" + a[2] + "' , " +
                                                                " CUSTOMER_POINTS =  " + a[3] + " , " +
                                                                " Customer_Phone_Number =  '" + a[4] + 
                                                                "' WHERE CUSTOMER_ID = " + a[0];
                OracleCommand command = new OracleCommand(sql, con);
                command.ExecuteNonQuery();
                DatabaseConnect.CloseConnection(con);
            }

            else if (tableName == "SHOW_HALL")
            {
                OracleConnection con = DatabaseConnect.OpenConnection();

      

                string sql = "UPDATE " + tableName + " SET " + " SHOW_DATE =  '" + a[1] + "', " +
                                                                " SHOW_PRICE =  " + a[2] + " , " +
                                                                " SHOW_POINTS =  " + a[3] + " " +                                                                
                                                                " WHERE SHOW_ID = " + a[0];
                OracleCommand command = new OracleCommand(sql, con);
                command.ExecuteNonQuery();


                DatabaseConnect.CloseConnection(con);
            }

            else if (tableName == "BOOKING")
            {
                OracleConnection con = DatabaseConnect.OpenConnection();



                string sql = "UPDATE " + tableName + " SET " + " customer_paid_time =  '" + a[1] + "' , " +
                                                                 " seats =  " + a[2] + " , "+
                                                                " booking_canceled =  '" + a[3] + "' " +
                                                                " WHERE BOOKING_ID = " + a[0];
                OracleCommand command = new OracleCommand(sql, con);
                command.ExecuteNonQuery();


                DatabaseConnect.CloseConnection(con);
            }

            else if (tableName == "seat_price")
            {
                OracleConnection con = DatabaseConnect.OpenConnection();



                string sql = "UPDATE " + tableName + " SET " + " seat_additional_price =  " + a[2] +
                                                                " WHERE SEAT_ID = " + a[0] + " AND SHOW_ID = " + a[1];
                OracleCommand command = new OracleCommand(sql, con);
                command.ExecuteNonQuery();


                DatabaseConnect.CloseConnection(con);
            }

            else if (tableName == "Discount")
            {              
                List<string> param = new List<string>();
                param.Add("ruleid");
                param.Add("dis");
                param.Add("s_date");
                param.Add("e_date");
                //param.Add("newpoints");
               // param.Add("typename");

                OracleConnection con = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(con, "update_discount", param, a);
                DatabaseConnect.CloseConnection(con);
            }
            else if (tableName == "Film")
            {
                OracleConnection con = DatabaseConnect.OpenConnection();



                string sql1 = "UPDATE " + tableName + " SET " + " film_name =  '" + a[1] + "' , " +
                                                                 " film_description =  '" + a[2] + "' , " +
                                                                " film_duration =  " + a[3] + " " +
                                                                " WHERE film_id = " + a[0];
                OracleCommand command1 = new OracleCommand(sql1, con);
                

                string sql2 = "UPDATE  FILM_HAS_TYPE SET TYPE_ID =  " + a[4]  +
                                                " WHERE film_id = " + a[0];
                OracleCommand command2 = new OracleCommand(sql2, con);
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();


                DatabaseConnect.CloseConnection(con);
            }
           
            else if (tableName == "Film_workers")
            {
               OracleConnection con = DatabaseConnect.OpenConnection();



               string sql = "UPDATE " + tableName + " SET " + " worker_name =  '" + a[2] + "' , " +
                                                                " worker_role  =  '" + a[3] +
                                                                "' WHERE film_id = " + a[0] + " AND Worker_id = " +a[1] ;
                                                                   
                OracleCommand command = new OracleCommand(sql, con);
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Update error please try agine!.");
            }
        }


        public static void updateDBDiscount(int type, List<object> a)
        {
            if(type ==1)
            {
                List<string> param = new List<string>();
                param.Add("ruleid");
                param.Add("dis");
                param.Add("s_date");
                param.Add("e_date");

                OracleConnection con = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(con, "update_discount", param, a);
                DatabaseConnect.CloseConnection(con);

            }

            else if (type==2)
            {
                List<string> param = new List<string>();
                param.Add("ruleid");
                param.Add("dis");
                param.Add("s_date");
                param.Add("e_date");
                param.Add("typename");

                OracleConnection con = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(con, "update_discount_type", param, a);
                DatabaseConnect.CloseConnection(con);
            }

            else
            {
                List<string> param = new List<string>();
                param.Add("ruleid");
                param.Add("dis");
                param.Add("s_date");
                param.Add("e_date");
                param.Add("newpoints");

                OracleConnection con = DatabaseConnect.OpenConnection();
                DatabaseCallFunction.CallProcedure(con, "update_discount_points", param, a);
                DatabaseConnect.CloseConnection(con);
            }
        }


         public static DataTable getReports(int reportType, List<object> a, int empID)
         {
             if (reportType == 1)
             {
                 OracleDataAdapter ad = new OracleDataAdapter();
                 DataTable ds = new DataTable();
                 OracleConnection con = DatabaseConnect.OpenConnection();
                 ad = new OracleDataAdapter(
                 "select show_id , film_name ,count(SEATS) s from BOOKING join SHOW_HALL using (SHOW_ID) join FILM using(FILM_ID)" + 
                 "where BOOKING_CANCELED = 0 and SHOW_DATE between " +
                 "'" + a[0] + "' and '" + a[1] + "' group by show_id,film_name order by s desc", con);
                 ad.Fill(ds);
                 DatabaseConnect.CloseConnection(con);
                 return ds;
             }
             else if (reportType == 2)
             {
                 OracleDataAdapter ad = new OracleDataAdapter();
                 DataTable dt = new DataTable();
                 OracleConnection con = DatabaseConnect.OpenConnection();
                 ad = new OracleDataAdapter(
                 "select show_id, sum(total_price) tot , film_name from show_hall join BOOKING using (SHOW_ID) "+ 
                 " join film using(film_id) " + 
                 " join BOOKED_SEATS using (BOOKING_ID) " + 
                 " join SEAT_PRICE using(SEAT_ID,SHOW_ID) " + 
                 " where BOOKING_CANCELED = 0 and SHOW_DATE between " +
                 " '" + a[0] + "' and '" + a[1] + "'" + 
                 " group by SHOW_ID, FILM_NAME order by tot Desc", con);
                 ad.Fill(dt);
                 DatabaseConnect.CloseConnection(con);
                 return dt;

             }
              else if (reportType == 3)
             {
                 OracleDataAdapter ad = new OracleDataAdapter();
                 DataTable dt = new DataTable();
                 OracleConnection con = DatabaseConnect.OpenConnection();
                 ad = new OracleDataAdapter(
                 "select RECEPTION_EMPLOYEE.Employee_id as empID , Employee_name as empName, sum(seats) tot1, count(booking_id) tot2 " +
                 "from RECEPTION_EMPLOYEE join BOOKING on RECEPTION_EMPLOYEE.EMPLOYEE_ID = BOOKING.EMPLOYEE_ID " +
                 " join SHOW_HALL on SHOW_HALL.SHOW_ID = BOOKING.SHOW_ID " +
                 " join employee on employee.employee_id = RECEPTION_EMPLOYEE.EMPLOYEE_ID " +
                 " where BOOKING_CANCELED = 0 and SHOW_DATE between " +
                 " '" + a[0] + "' and '" + a[1] + "'" + 
                 " And customer_paid_time between " +
                 " '" + a[0] + "' and '" + a[1] + "'" + 
                 " group by RECEPTION_EMPLOYEE.EMPLOYEE_ID,EMPLOYEE_NAME " +
                 " order by tot1,tot2 desc ",con);
                 ad.Fill(dt);
                 DatabaseConnect.CloseConnection(con);
                 return dt;
             }
             else if (reportType == 4)
             {
                 OracleDataAdapter ad = new OracleDataAdapter();
                 DataTable dt = new DataTable();
                 OracleConnection con = DatabaseConnect.OpenConnection();
                 ad = new OracleDataAdapter(
                 "select  Booking_id "+
                 "from RECEPTION_EMPLOYEE join BOOKING on RECEPTION_EMPLOYEE.EMPLOYEE_ID = BOOKING.EMPLOYEE_ID " +
                 " join SHOW_HALL on SHOW_HALL.SHOW_ID = BOOKING.SHOW_ID " +
                 " join employee on employee.employee_id = RECEPTION_EMPLOYEE.EMPLOYEE_ID " +
                 " where RECEPTION_EMPLOYEE.Employee_id = " + empID + " and SHOW_DATE between " +
                 " '" + a[0] + "' and '" + a[1] + "'", con);
                 ad.Fill(dt);
                 DatabaseConnect.CloseConnection(con);
                 return dt;
             }
             else
             {
                 MessageBox.Show("Input error please try agine");
                 return null;
             }
         }
    }

       
    }


