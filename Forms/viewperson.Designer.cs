namespace staj_proje_ef.Forms
{
    partial class viewperson
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
            dataGridView1 = new DataGridView();
            addCusBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(634, 335);
            dataGridView1.TabIndex = 0;
            // 
            // addCusBtn
            // 
            addCusBtn.BackColor = Color.Lavender;
            addCusBtn.FlatAppearance.BorderSize = 0;
            addCusBtn.FlatStyle = FlatStyle.Flat;
            addCusBtn.Font = new Font("Segoe Print", 9F);
            addCusBtn.Location = new Point(684, 54);
            addCusBtn.Name = "addCusBtn";
            addCusBtn.Size = new Size(150, 75);
            addCusBtn.TabIndex = 4;
            addCusBtn.Text = "Personel Sil";
            addCusBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 9F);
            button1.Location = new Point(684, 158);
            button1.Name = "button1";
            button1.Size = new Size(150, 75);
            button1.TabIndex = 5;
            button1.Text = "Müşteri Sil";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Print", 9F);
            button2.Location = new Point(684, 266);
            button2.Name = "button2";
            button2.Size = new Size(150, 75);
            button2.TabIndex = 6;
            button2.Text = "Bilgileri Güncelle";
            button2.UseVisualStyleBackColor = false;
            // 
            // viewperson
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addCusBtn);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4);
            Name = "viewperson";
            Text = "Görüntüle";
            Load += viewperson_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addCusBtn;
        private Button button1;
        private Button button2;
    }
}