using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsingDataBinding
{
    public partial class Form1 : Form
    {
        Database RedDb; 
        Database UmacsDb;
        GenericRepository<Employee> EmployeeRepo;

        BindingSource Bsrc;
        BindingList<Employee> employees;

        public Form1()
        {
            
            string connectionString = @"server=DESKTOP-QPM5S0C\SQLEXPRESS;Trusted_Connection=yes;database=AdventureWorksDW2017;connection timeout = 30";
            
            RedDb = new REDDatabase(connectionString);
            UmacsDb = new UMACSDatabase(connectionString);

            EmployeeRepo = new EmployeeRepository(RedDb);


            InitializeComponent();

            //Employee andrew = new Employee(1, "andrew", "shal", "Software Engineer", "shalandrew97@gmial.com", 2);
            //EmployeeRepo.Insert(andrew);

            employees = EmployeeRepo.GetAll();
            Bsrc = new BindingSource(employees,null);
            dataGridView.DataSource = Bsrc;
        }

        private void dataGridView_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MessageBox.Show("Current Emplyee count: ",employees.Count().ToString());
        }
    }
}
