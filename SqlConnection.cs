using System;

namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        {
            
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection Open!");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL Connection Closed!");
        }
    }
}