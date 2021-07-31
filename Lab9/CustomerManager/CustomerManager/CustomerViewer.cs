using CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CodeFirst.Model;

namespace CustomerManager
{
    public partial class CustomerViewer : Form
    {
        SampleContext context;
        byte[] Ph;

        public List<Order> Orders { get; private set; }

        public CustomerViewer()
        {
            InitializeComponent();
            context = new SampleContext();
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void Output()
        {
            if (this.customerRadioButton.Checked == true)
                GridView.DataSource = context.Customers.ToList();
            else if (this.orderRadioButton.Checked == true)
                GridView.DataSource = context.Orders.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.textBoxName.Text,
                    LastName = this.textBoxLastName.Text,
                    Email = this.textBoxMail.Text,
                    Age = Int32.Parse(this.textBoxAge.Text),
                    Orders = orderListBox.SelectedItems.OfType<Order>().ToList(),
                    Photo = Ph
                };
                context.Customers.Add(customer);
                Orders = orderListBox.SelectedItems.OfType<Order>().ToList();
                context.SaveChanges();
                Output();
                textBoxName.Text = String.Empty;
                textBoxLastName.Text = String.Empty;
                textBoxMail.Text = String.Empty;
                textBoxAge.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());

                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;
            customerList.DataSource = query.ToList();
        }

        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order { ProductName = "Аудио", Quantity = 12, PurchaseDate = DateTime.Parse("12.01.2016") });
            context.Orders.Add(new Order { ProductName = "Видео", Quantity = 22, PurchaseDate = DateTime.Parse("10.01.2016") });
            context.SaveChanges();
            orderListBox.DataSource = context.Orders.ToList();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
            var customer = GridView.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;
            labelId.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();

            textBoxName.Text = customer.FirstName;
            textBoxLastName.Text = customer.LastName;
            textBoxMail.Text = customer.Email;
            textBoxAge.Text = Convert.ToString(customer.Age);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;
            var id = Convert.ToInt32(labelId.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;

            customer.FirstName = this.textBoxName.Text;
            customer.LastName = this.textBoxLastName.Text;
            customer.Email = this.textBoxMail.Text;
            customer.Age = Int32.Parse(this.textBoxAge.Text);
            context.Entry(customer).State = EntityState.Modified;

            context.SaveChanges();
            Output();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;

            var id = Convert.ToInt32(labelId.Text);
            var customer = context.Customers.Find(id);

            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
        }
    }
}
