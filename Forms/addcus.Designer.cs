namespace staj_proje_ef.Forms
{
    partial class addcus
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            telBox = new MaskedTextBox();
            tcBox = new MaskedTextBox();
            cusRegistBtn = new Button();
            emailBox = new TextBox();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(34, 26);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // panel1
            // 
            panel1.Controls.Add(telBox);
            panel1.Controls.Add(tcBox);
            panel1.Controls.Add(cusRegistBtn);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(surnameBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(312, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 369);
            panel1.TabIndex = 22;
            // 
            // telBox
            // 
            telBox.Location = new Point(81, 135);
            telBox.Mask = "(999) 000-0000";
            telBox.Name = "telBox";
            telBox.Size = new Size(185, 34);
            telBox.TabIndex = 22;
            // 
            // tcBox
            // 
            tcBox.Location = new Point(81, 184);
            tcBox.Mask = "00000000000";
            tcBox.Name = "tcBox";
            tcBox.Size = new Size(185, 34);
            tcBox.TabIndex = 21;
            tcBox.ValidatingType = typeof(int);
            // 
            // cusRegistBtn
            // 
            cusRegistBtn.Location = new Point(148, 292);
            cusRegistBtn.Name = "cusRegistBtn";
            cusRegistBtn.Size = new Size(118, 55);
            cusRegistBtn.TabIndex = 20;
            cusRegistBtn.Text = "Kaydet";
            cusRegistBtn.UseVisualStyleBackColor = true;
            cusRegistBtn.Click += cusRegistBtn_Click;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(81, 229);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(185, 34);
            emailBox.TabIndex = 10;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(81, 83);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(185, 34);
            surnameBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(81, 37);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(185, 34);
            nameBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 184);
            label4.Name = "label4";
            label4.Size = new Size(32, 26);
            label4.TabIndex = 5;
            label4.Text = "TC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 232);
            label5.Name = "label5";
            label5.Size = new Size(54, 26);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 138);
            label3.Name = "label3";
            label3.Size = new Size(34, 26);
            label3.TabIndex = 2;
            label3.Text = "Tel";
            // 
            // addcus
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4);
            Name = "addcus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button cusRegistBtn;
        private TextBox emailBox;
        private TextBox surnameBox;
        private TextBox nameBox;
        private Label label4;
        private Label label5;
        private Label label3;
        private MaskedTextBox tcBox;
        private MaskedTextBox telBox;
    }
}