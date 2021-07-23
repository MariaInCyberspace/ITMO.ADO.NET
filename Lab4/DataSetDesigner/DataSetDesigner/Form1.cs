using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCustomersButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet northwindDataSet = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter 
                = new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            customersTableAdapter.Fill(northwindDataSet.Customers);

            foreach (NorthwindDataSet.CustomersRow customer in northwindDataSet.Customers.Rows)
            {
                customersListBox.Items.Add(customer.CompanyName);
            }
        }
    }
}
