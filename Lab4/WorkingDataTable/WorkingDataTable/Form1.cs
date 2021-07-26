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

namespace WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customersDataGridView.DataSource = northwindDataSet.Customers;
            customersDataGridView.MultiSelect = false;
            customersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            customersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private NorthwindDataSet.CustomersRow GetSelectedRow()
        {
            String SelectedCustomerID = customersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            NorthwindDataSet.CustomersRow SelectedRow = northwindDataSet.Customers.FindByCustomerID(SelectedCustomerID);
            return SelectedRow;
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                currentDRVTextBox.Text = GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                currentDRVTextBox.Text = ex.Message;
            }
            try
            {
                originalDRVTextBox.Text = GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                originalDRVTextBox.Text = ex.Message;
            }
            rowStateTextBox.Text = GetSelectedRow().RowState.ToString();
        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(northwindDataSet.Customers);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            NorthwindDataSet.CustomersRow NewRow = (NorthwindDataSet.CustomersRow)northwindDataSet.Customers.NewRow();
            NewRow.CustomerID = "WINGT";
            NewRow.CompanyName = "Wingtip Toys";
            NewRow.ContactName = "Steve Lasker";
            NewRow.ContactTitle = "CEO";
            NewRow.Address = "1234 Main Street";
            NewRow.City = "Buffalo";
            NewRow.Region = "NY";
            NewRow.PostalCode = "98052";
            NewRow.Country = "USA";
            NewRow.Phone = "206-555-0111";
            NewRow.Fax = "206-555-0112";

            try
            {
                northwindDataSet.Customers.Rows.Add(NewRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void updateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[customersDataGridView.CurrentCell.OwningColumn.Name] = cellValueTextBox.Text;
            UpdateRowVersionDisplay();
        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cellValueTextBox.Text = customersDataGridView.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();

        }

        private void acceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void rejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
