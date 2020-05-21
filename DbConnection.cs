using System;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private string _connectionString;
       // private TimeSpan _timeOut;


        protected DbConnection(string connectionString)
        {
            _connectionString = connectionString ?? throw new InvalidOperationException("Invalid ConnectionString");
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}