namespace staj_proje_ef
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            userNameTxtbox = new TextBox();
            passwordTxtbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            passwordShow = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 36);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 1;
            label1.Text = "Sisteme Hoşgeldiniz";
            // 
            // userNameTxtbox
            // 
            userNameTxtbox.Location = new Point(71, 250);
            userNameTxtbox.Name = "userNameTxtbox";
            userNameTxtbox.Size = new Size(179, 38);
            userNameTxtbox.TabIndex = 2;
            // 
            // passwordTxtbox
            // 
            passwordTxtbox.Location = new Point(71, 320);
            passwordTxtbox.Name = "passwordTxtbox";
            passwordTxtbox.Size = new Size(179, 38);
            passwordTxtbox.TabIndex = 3;
            passwordTxtbox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(72, 397);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 4;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 397);
            button2.Name = "button2";
            button2.Size = new Size(75, 41);
            button2.TabIndex = 5;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 7.8F);
            label2.Location = new Point(72, 228);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 6;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 7.8F);
            label3.Location = new Point(72, 298);
            label3.Name = "label3";
            label3.Size = new Size(41, 23);
            label3.TabIndex = 7;
            label3.Text = "Şifre";
            // 
            // panel1
            // 
            panel1.Controls.Add(passwordShow);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userNameTxtbox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(passwordTxtbox);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(92, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 458);
            panel1.TabIndex = 8;
            // 
            // passwordShow
            // 
            passwordShow.AutoSize = true;
            passwordShow.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordShow.Location = new Point(130, 364);
            passwordShow.Name = "passwordShow";
            passwordShow.Size = new Size(123, 27);
            passwordShow.TabIndex = 10;
            passwordShow.Text = "Şifreyi Göster";
            passwordShow.UseVisualStyleBackColor = true;
            passwordShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cancel;
            pictureBox2.Location = new Point(441, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(495, 520);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox userNameTxtbox;
        private TextBox passwordTxtbox;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private CheckBox passwordShow;
    }
}