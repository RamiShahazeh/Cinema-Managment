using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System;

namespace oracleTest.DAL
{
    public class DatabaseCallFunction
    {
        public static void CallProcedure(OracleConnection conn, string procName, List<string> args, List<object> values)
        {
            OracleCommand command = new OracleCommand(procName, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.BindByName = true;

            for (int i = 0; i < args.Count; i++)
            {
                OracleParameter p = new OracleParameter();
                p.ParameterName = args[i];
                p.Value = values[i];
                command.Parameters.Add(p);
            }
            command.ExecuteNonQuery();
        }

        public static object CallFunction(OracleConnection conn, string funcName, List<string> args, List<object> values, string retParamName)
        {

            try
            {
                OracleCommand command = new OracleCommand(funcName, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.BindByName = true;

                for (int i = 0; i < args.Count; i++)
                {
                    OracleParameter p = new OracleParameter();
                    p.ParameterName = args[i];
                    p.Value = values[i];
                    command.Parameters.Add(p);
                }

                    command.Parameters.Add(new OracleParameter(retParamName, OracleDbType.Int32, ParameterDirection.Output));

                    command.ExecuteNonQuery();
                    return command.Parameters[retParamName].Value;
                            
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
