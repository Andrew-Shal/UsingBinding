using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDataBinding
{
    public class Employee
    {
        private int _EmployeeKey;
        private string _FirstName;
        private string _LastName;
        private string _Title;
        private string _EmailAddress;
        private int _SalesTerritoryKey;
        public Employee() {
            _EmployeeKey = -1;
            _FirstName = null;
            _LastName = null;
            _Title = null;
            _EmailAddress = null;
            _SalesTerritoryKey = -1;
        }
        public Employee(int employeeKey, string firstName, string lastName, string title, string emailAddress, int salesTerritoryKey)
        {
            _EmployeeKey = employeeKey;
            _FirstName = firstName;
            _LastName = lastName;
            _Title = title;
            _EmailAddress = emailAddress;
            _SalesTerritoryKey = salesTerritoryKey;
        }

        public int EmployeeKey { get => _EmployeeKey; set => _EmployeeKey = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string EmailAddress { get => _EmailAddress; set => _EmailAddress = value; }
        public int SalesTerritoryKey1 { get => _SalesTerritoryKey; set => _SalesTerritoryKey = value; }
    }
}
