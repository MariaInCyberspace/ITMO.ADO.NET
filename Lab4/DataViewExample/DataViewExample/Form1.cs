using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataViewExample
{
    public partial class Form1 : Form
    {
        DataView customersDataView;
        DataView ordersDataView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);
            customersDataView.Sort = "CustomerID";
            customersDataGridView.DataSource = customersDataView;
        }

        private void setDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = sortTextBox.Text;
            customersDataView.RowFilter = filterTextBox.Text;
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomerRow = customersDataView.AddNew();
            newCustomerRow["CustomerID"] = "WNGTT";
            newCustomerRow["CompanyName"] = "Wing Tip Toys";
            newCustomerRow.EndEdit();
        }

        private void getOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID =
            customersDataGridView.SelectedCells[0].OwningRow.Cells["CustomerID"].Value.ToString();
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
            ordersDataView = selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);
            ordersDataGridView.DataSource = ordersDataView;
        }
    }
}