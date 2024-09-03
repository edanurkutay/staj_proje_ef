namespace staj_proje_ef.Forms
{
    partial class viewcustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridVCustomer = new DataGridView();
            deleteCusBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 26);
            label1.TabIndex = 14;
            label1.Text = "Müşteri Tablosu";
            // 
            // dataGridVCustomer
            // 
            dataGridVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridVCustomer.BackgroundColor = Color.LightSlateGray;
            dataGridVCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVCustomer.Location = new Point(21, 48);
            dataGridVCustomer.Name = "dataGridVCustomer";
            dataGridVCustomer.RowHeadersWidth = 51;
            dataGridVCustomer.Size = new Size(835, 278);
            dataGridVCustomer.TabIndex = 13;
            // 
            // deleteCusBtn
            // 
            deleteCusBtn.BackColor = Color.Lavender;
            deleteCusBtn.FlatAppearance.BorderSize = 0;
            deleteCusBtn.FlatStyle = FlatStyle.Flat;
            deleteCusBtn.Font = new Font("Segoe Print", 9F);
            deleteCusBtn.Location = new Point(700, 341);
            deleteCusBtn.Name = "deleteCusBtn";
            deleteCusBtn.Size = new Size(156, 65);
            deleteCusBtn.TabIndex = 11;
            deleteCusBtn.Text = "Müşteri Sil";
            deleteCusBtn.UseVisualStyleBackColor = false;
            deleteCusBtn.Click += deleteCusBtn_Click;
            // 
            // viewcustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(label1);
            Controls.Add(dataGridVCustomer);
            Controls.Add(deleteCusBtn);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4, 3, 4, 3);
            Name = "viewcustomer";
            Text = "Müşteriler";
            Load += viewcustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridVCustomer;
        public Button deleteCusBtn;
    }
}