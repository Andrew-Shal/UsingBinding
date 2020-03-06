using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;

namespace UsingDataBinding
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(Database db) : base(db)
        {
            //if (db.IsOpen()) {
            //}
        }

        public override void Insert(Employee obj)
        {
            throw new NotImplementedException();
        }

        public override Employee Delete(Employee obj)
        {
            throw new NotImplementedException();
        }

        public override BindingList<Employee> GetAll()
        {
            var list = new List<Employee>();
            string sql = "SELECT [EmployeeKey],[FirstName],[LastName],[Title],[EmailAddress],[SalesTerritoryKey] FROM [dbo].[DimEmployee]";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(Db.ConnectionString)) { 
                Da.SelectCommand = new SqlCommand(sql, connection);

                Da.Fill(dt);
            }
            if (dt.Rows.Count < 1) return new BindingList<Employee>(list);

            foreach (var row in dt.AsEnumerable()) 
            {
                var EmployeeKey = row.Field<int>("EmployeeKey");
                var FirstName = row.Field<string>("FirstName");
                var LastName = row.Field<string>("LastName");
                var Title = row.Field<string>("Title");
                var EmailAddress = row.Field<string>("EmailAddress");
                var SalesTerritoryKey = row.Field<int>("SalesTerritoryKey");

                list.Add(new Employee(EmployeeKey, FirstName, LastName, Title, EmailAddress, SalesTerritoryKey));
            }

            return new BindingList<Employee>(list);
        }

        public override Employee GetById(string id)
        {
            throw new NotImplementedException();
        }

        public override Employee Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
