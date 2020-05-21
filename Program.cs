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
            var sqlConnection = new SqlConnection("Test");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("Test");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();

            var sqlCommand = new DbCommand(new SqlConnection("test"), "test SQL" );
            sqlCommand.Execute();

            var oracleCommand = new DbCommand(new OracleConnection("test"), "test Oracle");
            oracleCommand.Execute();

        }
    }
}
