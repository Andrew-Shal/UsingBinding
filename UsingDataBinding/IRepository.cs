using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UsingDataBinding
{
    public interface IRepository<T> where T : class
    {
        BindingList<T> GetAll();
        void Insert(T obj);
        T Update(T obj);
        T Delete(T obj);
        T GetById(string id);
        //BindingList<T> GetByQuery();
    }
}
