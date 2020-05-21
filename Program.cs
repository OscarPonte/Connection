using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection(null);
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("Test");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}
