using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            using (sqlConnection1)
            {
                sqlConnection1.Open();

                using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                {
                    bool MoreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                sb.Append(reader[i].ToString() + "\t");
                            }
                            sb.Append(Environment.NewLine);
                        }
                        MoreResults = reader.NextResult();
                    }
                    while (MoreResults);
                }
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.CommandText = "Ten Most Expensive Products";
            using (sqlCommand2.Connection)
            {
                sqlCommand2.Connection.Open();

                using (SqlDataReader reader = sqlCommand2.ExecuteReader())
                {
                    bool MoreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                sb.Append(reader[i].ToString() + "\t");
                            }
                            sb.Append(Environment.NewLine);
                        }
                        MoreResults = reader.NextResult();
                    }
                    while (MoreResults);
                }
            }
            richTextBox1.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCommand3.CommandType = CommandType.Text;

                using (sqlCommand3.Connection)
                {
                    sqlCommand3.Connection.Open();
                    sqlCommand3.CommandText = "CREATE TABLE SalesPersons (" +
                                              "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                                              "[FirstName] [nvarchar](50)  NULL, " +
                                              "[LastName] [nvarchar](50)  NULL)";

                    sqlCommand3.ExecuteNonQuery();
                }
                MessageBox.Show("Таблица SalesPersons создана");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sqlCommand4.CommandType = CommandType.Text;
                sqlCommand4.Parameters["@City"].Value = CityTextBox.Text;
                using (sqlCommand4.Connection)
                {
                    sqlCommand4.Connection.Open();

                    using (SqlDataReader reader = sqlCommand4.ExecuteReader())
                    {
                        bool MoreResults = false;
                        do
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    sb.Append(reader[i].ToString() + "\t");
                                }
                                sb.Append(Environment.NewLine);
                            }
                            MoreResults = reader.NextResult();
                        }
                        while (MoreResults);
                    }
                }
                richTextBox1.Text = sb.ToString();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCommand4.Connection.State == ConnectionState.Open)
                {
                    sqlCommand4.Connection.Close();
                }
                sqlConnection1.ConnectionString = @"Data Source=LAPTOP-35VMNLA7\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True";
            }
        }
    }
}
