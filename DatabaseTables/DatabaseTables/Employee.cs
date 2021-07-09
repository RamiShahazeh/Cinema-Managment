using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Employee
    {
        public int employee_id;
        public string employee_name;

        public Employee(int e_id, string e_name)
        {
            this.employee_id = e_id;
            this.employee_name = e_name;
        }

        public Employee()
        {

        }

    }
}
