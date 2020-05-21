using System;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;


        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }

    }
}