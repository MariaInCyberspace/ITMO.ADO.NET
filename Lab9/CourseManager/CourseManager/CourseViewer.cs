using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
{
    public partial class CourseViewer : Form
    {
        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            // Initiate the context
            schoolContext = new SchoolEntities();
            // Populate the context
            schoolContext.Departments.Load();

            try
            {
                this.departmentList.DisplayMember = "Name";

                // Define the data source for department list based on observable collection of data in the context
                this.departmentList.DataSource = schoolContext.Departments.Local;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {   
                // Get the currently selected department
                Department department = this.departmentList.SelectedItem as Department;

                // Define data sourse for the grid element based on the chosen department from the combo box
                courseGridView.DataSource = department.Courses.ToList();

                // Make some irrelevant columns not visible in the grid
                courseGridView.Columns["Department"].Visible = false;
                courseGridView.Columns["StudentGrades"].Visible = false;
                courseGridView.Columns["OnlineCourse"].Visible = false;
                courseGridView.Columns["OnsiteCourse"].Visible = false;
                courseGridView.Columns["People"].Visible = false;
                courseGridView.Columns["DepartmentId"].Visible = false;

                courseGridView.AllowUserToDeleteRows = false;
                courseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Your changes have been saved");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
            schoolContext.Dispose();
        }
    }
}
