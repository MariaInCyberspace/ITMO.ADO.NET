using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        readonly string testConnect = @"Provider=SQLOLEDB.1;    
                                        Integrated Security=SSPI;
                                        Persist Security Info=False;
                                        User ID=localhost;
                                        Initial Catalog=Northwind;
                                        Data Source=LAPTOP-35VMNLA7\SQLEXPRESS02";

        public Form1()
        {
            InitializeComponent();
        }

        private void connectToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных", ex.Message);
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else 
            { 
                MessageBox.Show("Соединение с базой данных уже закрыто"); 
            }

        }
    }
}
