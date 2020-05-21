using System;

namespace DbConnection
{
    public class DbConnection
    {
        private string _connectionString;
       // private TimeSpan _timeOut;


        protected DbConnection(string connectionString)
        {
            _connectionString = connectionString ?? throw new InvalidOperationException("Invalid ConnectionString");
        }

        public virtual void OpenConnection()
        {

        }

        public virtual void CloseConnection()
        {

        }
    }
}