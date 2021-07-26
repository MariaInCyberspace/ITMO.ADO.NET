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

namespace DataAdapterProgram
{
    public partial class Form1 : Form
    {
        private SqlConnection NorthwindConnection = new SqlConnection("Data Source=LAPTOP-35VMNLA7\\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True");
        private SqlDataAdapter SqlDataAdapter1;
        private  DataSet NorthwindDataSet = new DataSet("Northwind");
        private DataTable customersTable = new DataTable("Customers");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
            NorthwindDataSet.Tables.Add(customersTable);
            SqlDataAdapter1.Fill(NorthwindDataSet.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataSet.Tables["Customers"];

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter1.Update(NorthwindDataSet.Tables["Customers"]);
        }
    }
}
