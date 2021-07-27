
namespace DataViewExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.sortTextBox = new System.Windows.Forms.TextBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.setDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.customersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new DataViewExample.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            this.northwindDataSet1 = new DataViewExample.NorthwindDataSet();
            this.getOrdersButton = new System.Windows.Forms.Button();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(997, 193);
            this.customersDataGridView.TabIndex = 0;
            // 
            // sortTextBox
            // 
            this.sortTextBox.Location = new System.Drawing.Point(12, 434);
            this.sortTextBox.Name = "sortTextBox";
            this.sortTextBox.Size = new System.Drawing.Size(209, 22);
            this.sortTextBox.TabIndex = 1;
            this.sortTextBox.Text = "CustomerID";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(292, 434);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(209, 22);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.Text = "City = \'London\'";
            // 
            // setDataViewPropertiesButton
            // 
            this.setDataViewPropertiesButton.Location = new System.Drawing.Point(12, 494);
            this.setDataViewPropertiesButton.Name = "setDataViewPropertiesButton";
            this.setDataViewPropertiesButton.Size = new System.Drawing.Size(209, 23);
            this.setDataViewPropertiesButton.TabIndex = 3;
            this.setDataViewPropertiesButton.Text = "Set Data View Properties";
            this.setDataViewPropertiesButton.UseVisualStyleBackColor = true;
            this.setDataViewPropertiesButton.Click += new System.EventHandler(this.setDataViewPropertiesButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(310, 494);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(173, 23);
            this.addRowButton.TabIndex = 4;
            this.addRowButton.Text = "Add Row";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getOrdersButton
            // 
            this.getOrdersButton.Location = new System.Drawing.Point(499, 494);
            this.getOrdersButton.Name = "getOrdersButton";
            this.getOrdersButton.Size = new System.Drawing.Size(173, 23);
            this.getOrdersButton.TabIndex = 5;
            this.getOrdersButton.Text = "Get Orders";
            this.getOrdersButton.UseVisualStyleBackColor = true;
            this.getOrdersButton.Click += new System.EventHandler(this.getOrdersButton_Click);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(0, 199);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(997, 165);
            this.ordersDataGridView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 541);
            this.Controls.Add(this.ordersDataGridView);
            this.Controls.Add(this.getOrdersButton);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.setDataViewPropertiesButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.sortTextBox);
            this.Controls.Add(this.customersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.TextBox sortTextBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button setDataViewPropertiesButton;
        private System.Windows.Forms.Button addRowButton;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private NorthwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.Button getOrdersButton;
        private System.Windows.Forms.DataGridView ordersDataGridView;
    }
}

