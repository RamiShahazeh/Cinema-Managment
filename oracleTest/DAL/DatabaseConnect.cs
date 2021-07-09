using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System;

namespace oracleTest.DAL
{
    public class DatabaseConnect
    {
        public static OracleConnection OpenConnection()
        {
            OracleConnection connection;
            try
            {
                connection = new OracleConnection("USER ID = cinema; PASSWORD = cinema ;DATA SOURCE=xe");
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void CloseConnection(OracleConnection oc)
        {
            oc.Close();
        }
    }
}

