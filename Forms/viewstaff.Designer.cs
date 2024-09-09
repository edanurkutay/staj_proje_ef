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
            deleteStaffBtn = new Button();
            updateBtn = new Button();
            label1 = new Label();
            dataGridStaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).BeginInit();
            SuspendLayout();
            // 
            // deleteStaffBtn
            // 
            deleteStaffBtn.BackColor = Color.Lavender;
            deleteStaffBtn.FlatAppearance.BorderSize = 0;
            deleteStaffBtn.FlatStyle = FlatStyle.Flat;
            deleteStaffBtn.Font = new Font("Segoe Print", 9F);
            deleteStaffBtn.Location = new Point(700, 341);
            deleteStaffBtn.Name = "deleteStaffBtn";
            deleteStaffBtn.Size = new Size(156, 65);
            deleteStaffBtn.TabIndex = 5;
            deleteStaffBtn.Text = "Personel Sil";
            deleteStaffBtn.UseVisualStyleBackColor = false;
            deleteStaffBtn.Click += deleteStaffBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.Lavender;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe Print", 9F);
            updateBtn.Location = new Point(526, 341);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(156, 65);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Bilgileri Güncelle";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 26);
            label1.TabIndex = 10;
            label1.Text = "Personel Tablosu";
            // 
            // dataGridStaff
            // 
            dataGridStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Controls.Add(updateBtn);
            Controls.Add(deleteStaffBtn);
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
        public Button deleteStaffBtn;
        public Button updateBtn;
        private Label label1;
        private DataGridView dataGridStaff;
    }
}