using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement
{
    internal class DALC
    {
        public static string GetStringConnection()
        {
            string connectionString = @"Data Source=DESKTOP-EBTHQ2Q\SQLEXPRESS;Initial Catalog=Vusal;Integrated Security=True";
            return connectionString;
        }
    }
}
