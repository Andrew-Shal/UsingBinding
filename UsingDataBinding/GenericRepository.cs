using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;

namespace UsingDataBinding
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private Database _Db;
        private SqlDataAdapter _Da;

        public Database Db { get => _Db; set => _Db = value; }

        public SqlDataAdapter Da { get => _Da; set => _Da = value; }

        public GenericRepository()
        {

        }

        public GenericRepository(Database db)
        {
            Db = db;
            Da = new SqlDataAdapter();
        }

        public abstract void Insert(T obj);

        public abstract T Delete(T obj);

        public abstract BindingList<T> GetAll();

        public abstract T GetById(string id);

        public abstract T Update(T obj);
    }
}
