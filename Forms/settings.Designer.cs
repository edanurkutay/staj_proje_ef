namespace staj_proje_ef.Forms
{
    partial class settings
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
            newPassTxt = new TextBox();
            passwordLbl = new Label();
            oldPassTxt = new TextBox();
            usernameLbl = new Label();
            RegistBtn = new Button();
            SuspendLayout();
            // 
            // newPassTxt
            // 
            newPassTxt.Location = new Point(428, 214);
            newPassTxt.Name = "newPassTxt";
            newPassTxt.Size = new Size(185, 34);
            newPassTxt.TabIndex = 17;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(269, 217);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(86, 26);
            passwordLbl.TabIndex = 16;
            passwordLbl.Text = "Yeni Şifre";
            // 
            // oldPassTxt
            // 
            oldPassTxt.Location = new Point(428, 161);
            oldPassTxt.Name = "oldPassTxt";
            oldPassTxt.Size = new Size(185, 34);
            oldPassTxt.TabIndex = 15;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Location = new Point(269, 164);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(83, 26);
            usernameLbl.TabIndex = 14;
            usernameLbl.Text = "Eski Şifre";
            // 
            // RegistBtn
            // 
            RegistBtn.Location = new Point(495, 281);
            RegistBtn.Name = "RegistBtn";
            RegistBtn.Size = new Size(118, 55);
            RegistBtn.TabIndex = 21;
            RegistBtn.Text = "Kaydet";
            RegistBtn.UseVisualStyleBackColor = true;
            RegistBtn.Click += RegistBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(882, 409);
            Controls.Add(RegistBtn);
            Controls.Add(newPassTxt);
            Controls.Add(passwordLbl);
            Controls.Add(oldPassTxt);
            Controls.Add(usernameLbl);
            Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox newPassTxt;
        private Label passwordLbl;
        public TextBox oldPassTxt;
        private Label usernameLbl;
        private Button RegistBtn;
    }
}