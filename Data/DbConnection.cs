using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyAccounting
{
    public class DbConnection
    {
        private string connectionStri = @"Server=(localdb)\MSSQLLocalDB; Database=MyAccounting; Integrated Security=True;";
        public SqlConnection GetConnection()
        { 
            return new SqlConnection(connectionStri);
        }
    }
}
