using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UsingDataBinding
{
    public abstract class Database
    {
        private string _ConnectionString;
        SqlConnection _connection;

        public Database(string connectionString)
        {
            _ConnectionString = connectionString;

            _connection = new SqlConnection(ConnectionString);
        }
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }

        public SqlConnection Connection { get => _connection; set => _connection = value; }

        public SqlConnection GetConnection() {
            return _connection;
        }

        public void encrypt()
        {
            throw new NotImplementedException();
        }

        public void decrypt() {
            throw new NotImplementedException();
        }
    }
}
