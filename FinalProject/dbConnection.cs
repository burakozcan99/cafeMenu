using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    class dbConnection
    {
        public SqlConnection connection;
        public SqlDataAdapter dataAdapter;
        public SqlCommand command;
        public DataSet dataSet;
        public SqlDataReader dataReader;
        
        public dbConnection()
        {
            connection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=Advanced");
        }
    }
}
