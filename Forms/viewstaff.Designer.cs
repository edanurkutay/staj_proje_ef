namespace staj_proje_ef.Forms
{
    partial class viewstaff
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
            deleteCusBtn = new Button();
            acceptCusBtn = new Button();
            label1 = new Label();
            dataGridStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).BeginInit();
            SuspendLayout();
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
            deleteCusBtn.TabIndex = 5;
            deleteCusBtn.Text = "Personel Sil";
            deleteCusBtn.UseVisualStyleBackColor = false;
            // 
            // acceptCusBtn
            // 
            acceptCusBtn.BackColor = Color.Lavender;
            acceptCusBtn.FlatAppearance.BorderSize = 0;
            acceptCusBtn.FlatStyle = FlatStyle.Flat;
            acceptCusBtn.Font = new Font("Segoe Print", 9F);
            acceptCusBtn.Location = new Point(526, 341);
            acceptCusBtn.Name = "acceptCusBtn";
            acceptCusBtn.Size = new Size(156, 65);
            acceptCusBtn.TabIndex = 7;
            acceptCusBtn.Text = "Bilgileri Güncelle";
            acceptCusBtn.UseVisualStyleBackColor = false;
            acceptCusBtn.Click += acceptCusBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 26);
            label1.TabIndex = 10;
            label1.Text = "Personel Tablosu";
            label1.Click += label1_Click;
            // 
            // dataGridStaff
            // 
            dataGridStaff.BackgroundColor = Color.LightSlateGray;
            dataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStaff.Location = new Point(21, 48);
            dataGridStaff.Name = "dataGridStaff";
            dataGridStaff.RowHeadersWidth = 51;
            dataGridStaff.Size = new Size(835, 278);
            dataGridStaff.TabIndex = 9;
            // 
            // viewstaff
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(label1);
            Controls.Add(dataGridStaff);
            Controls.Add(acceptCusBtn);
            Controls.Add(deleteCusBtn);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4);
            Name = "viewstaff";
            Text = "Personeller";
            Load += viewperson_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button deleteCusBtn;
        public Button acceptCusBtn;
        private Label label1;
        private DataGridView dataGridStaff;
    }
}