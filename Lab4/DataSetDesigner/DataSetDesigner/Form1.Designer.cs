
namespace DataSetDesigner
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
            this.getCustomersButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getCustomersButton
            // 
            this.getCustomersButton.Location = new System.Drawing.Point(24, 35);
            this.getCustomersButton.Name = "getCustomersButton";
            this.getCustomersButton.Size = new System.Drawing.Size(115, 44);
            this.getCustomersButton.TabIndex = 0;
            this.getCustomersButton.Text = "Get Customers";
            this.getCustomersButton.UseVisualStyleBackColor = true;
            this.getCustomersButton.Click += new System.EventHandler(this.getCustomersButton_Click);
            // 
            // customersListBox
            // 
            this.customersListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 16;
            this.customersListBox.Location = new System.Drawing.Point(0, 126);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(800, 324);
            this.customersListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.getCustomersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCustomersButton;
        private System.Windows.Forms.ListBox customersListBox;
    }
}

