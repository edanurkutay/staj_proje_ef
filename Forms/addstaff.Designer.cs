namespace staj_proje_ef.Forms
{
    partial class addstaff
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
            label2 = new Label();
            label3 = new Label();
            TcLbl = new Label();
            label5 = new Label();
            usernameLbl = new Label();
            nameTxtBox = new TextBox();
            surnameTxtBox = new TextBox();
            addressTxtBox = new TextBox();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            passwordLbl = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            unitBox = new ComboBox();
            jobBox = new ComboBox();
            roleBox = new ComboBox();
            empRegistBtn = new Button();
            panel1 = new Panel();
            updateBtn = new Button();
            telTxtBox = new MaskedTextBox();
            tcTxtBox = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
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
            // TcLbl
            // 
            TcLbl.AutoSize = true;
            TcLbl.Location = new Point(20, 184);
            TcLbl.Name = "TcLbl";
            TcLbl.Size = new Size(32, 26);
            TcLbl.TabIndex = 5;
            TcLbl.Text = "TC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 263);
            label5.Name = "label5";
            label5.Size = new Size(56, 26);
            label5.TabIndex = 4;
            label5.Text = "Adres";
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(350, 192);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(107, 26);
            usernameLbl.TabIndex = 3;
            usernameLbl.Text = "Kullanıcı Adı";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(81, 37);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(185, 34);
            nameTxtBox.TabIndex = 6;
            // 
            // surnameTxtBox
            // 
            surnameTxtBox.Location = new Point(81, 83);
            surnameTxtBox.Name = "surnameTxtBox";
            surnameTxtBox.Size = new Size(185, 34);
            surnameTxtBox.TabIndex = 7;
            // 
            // addressTxtBox
            // 
            addressTxtBox.Location = new Point(81, 229);
            addressTxtBox.Multiline = true;
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(185, 87);
            addressTxtBox.TabIndex = 10;
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(509, 189);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(185, 34);
            usernameTxt.TabIndex = 11;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(509, 242);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(185, 34);
            passwordTxt.TabIndex = 13;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(356, 245);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(48, 26);
            passwordLbl.TabIndex = 12;
            passwordLbl.Text = "Şifre";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(350, 135);
            label8.Name = "label8";
            label8.Size = new Size(35, 26);
            label8.TabIndex = 16;
            label8.Text = "Rol";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(350, 86);
            label9.Name = "label9";
            label9.Size = new Size(23, 26);
            label9.TabIndex = 15;
            label9.Text = "İş";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(350, 40);
            label10.Name = "label10";
            label10.Size = new Size(54, 26);
            label10.TabIndex = 14;
            label10.Text = "Birim";
            // 
            // unitBox
            // 
            unitBox.FormattingEnabled = true;
            unitBox.Location = new Point(509, 40);
            unitBox.Name = "unitBox";
            unitBox.Size = new Size(185, 34);
            unitBox.TabIndex = 17;
            unitBox.SelectionChangeCommitted += unitBox_SelectionChangeCommitted;
            // 
            // jobBox
            // 
            jobBox.FormattingEnabled = true;
            jobBox.Location = new Point(509, 86);
            jobBox.Name = "jobBox";
            jobBox.Size = new Size(185, 34);
            jobBox.TabIndex = 18;
            // 
            // roleBox
            // 
            roleBox.FormattingEnabled = true;
            roleBox.Location = new Point(509, 135);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(185, 34);
            roleBox.TabIndex = 19;
            // 
            // empRegistBtn
            // 
            empRegistBtn.Location = new Point(576, 312);
            empRegistBtn.Name = "empRegistBtn";
            empRegistBtn.Size = new Size(118, 55);
            empRegistBtn.TabIndex = 20;
            empRegistBtn.Text = "Kaydet";
            empRegistBtn.UseVisualStyleBackColor = true;
            empRegistBtn.Click += empRegistBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(telTxtBox);
            panel1.Controls.Add(tcTxtBox);
            panel1.Controls.Add(empRegistBtn);
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(jobBox);
            panel1.Controls.Add(unitBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(passwordTxt);
            panel1.Controls.Add(passwordLbl);
            panel1.Controls.Add(usernameTxt);
            panel1.Controls.Add(addressTxtBox);
            panel1.Controls.Add(surnameTxtBox);
            panel1.Controls.Add(nameTxtBox);
            panel1.Controls.Add(TcLbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(usernameLbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(69, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 396);
            panel1.TabIndex = 21;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(439, 312);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(118, 55);
            updateBtn.TabIndex = 25;
            updateBtn.Text = "Güncelle\r\n";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Visible = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // telTxtBox
            // 
            telTxtBox.Location = new Point(81, 135);
            telTxtBox.Mask = "(0999) 000-0000";
            telTxtBox.Name = "telTxtBox";
            telTxtBox.Size = new Size(185, 34);
            telTxtBox.TabIndex = 24;
            // 
            // tcTxtBox
            // 
            tcTxtBox.Location = new Point(81, 181);
            tcTxtBox.Mask = "00000000000";
            tcTxtBox.Name = "tcTxtBox";
            tcTxtBox.Size = new Size(185, 34);
            tcTxtBox.TabIndex = 23;
            tcTxtBox.ValidatingType = typeof(int);
            // 
            // addstaff
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4);
            Name = "addstaff";
            Text = "Personel Ekle";
            Load += addstaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label TcLbl;
        private Label label5;
        private Label usernameLbl;
        private Label passwordLbl;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button empRegistBtn;
        private Panel panel1;
        public TextBox nameTxtBox;
        public TextBox surnameTxtBox;
        public TextBox addressTxtBox;
        public TextBox usernameTxt;
        public TextBox passwordTxt;
        public ComboBox unitBox;
        public ComboBox jobBox;
        public ComboBox roleBox;
        public MaskedTextBox telTxtBox;
        public MaskedTextBox tcTxtBox;
        private Button updateBtn;
    }
}