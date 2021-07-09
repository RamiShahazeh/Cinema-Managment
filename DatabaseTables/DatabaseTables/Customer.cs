using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oracleTest.DatabaseTables
{
    class Customer
    {
        int customerId;
        string customerName;
        string customerEmail;
        int customrPoints;
        string customerPhone;

        public Customer(int c_id, string c_name, string c_email, int c_points, string c_phone)
        {
            this.customerId = c_id;
            this.customerName = c_name;
            this.customerEmail = c_email;
            this.customrPoints = c_points;
            this.customerPhone = c_phone;
        }
    }

    class CustomerIntersts : Customer
    {
        List<string> filmType;

        public CustomerIntersts(int c_id, string c_name, string c_email, int c_points, string c_phone, List<string> f_type)
            : base(c_id, c_name, c_email, c_points, c_phone)
        {
            this.filmType = f_type;
        }
    }
}

