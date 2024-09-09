namespace staj_proje_ef
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            panel1 = new Panel();
            pageNameLabel = new Label();
            settingsButton = new PictureBox();
            exitButton = new PictureBox();
            nameLabel = new Label();
            roleLabel = new Label();
            pictureBox1 = new PictureBox();
            viewCusBtn = new Button();
            btnPanel = new Panel();
            addStaffBtn = new Button();
            addCusBtn = new Button();
            viewStaffBtn = new Button();
            acceptCusBtn = new Button();
            mainPanel = new Panel();
            unitLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(settingsButton);
            panel1.Controls.Add(pageNameLabel);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 75);
            panel1.TabIndex = 0;
            // 
            // pageNameLabel
            // 
            pageNameLabel.AutoSize = true;
            pageNameLabel.ForeColor = Color.Honeydew;
            pageNameLabel.Location = new Point(392, 23);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(96, 30);
            pageNameLabel.TabIndex = 5;
            pageNameLabel.Text = "Sayfa Adı";
            pageNameLabel.Visible = false;
            // 
            // settingsButton
            // 
            settingsButton.AccessibleRole = AccessibleRole.ButtonMenu;
            settingsButton.Image = (Image)resources.GetObject("settingsButton.Image");
            settingsButton.Location = new Point(761, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(42, 41);
            settingsButton.SizeMode = PictureBoxSizeMode.StretchImage;
            settingsButton.TabIndex = 4;
            settingsButton.TabStop = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(833, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(42, 41);
            exitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            exitButton.TabIndex = 3;
            exitButton.TabStop = false;
            exitButton.Click += pictureBox2_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.Honeydew;
            nameLabel.Location = new Point(96, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 30);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.Honeydew;
            roleLabel.Location = new Point(96, 9);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(49, 30);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Role";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // viewCusBtn
            // 
            viewCusBtn.BackColor = Color.Lavender;
            viewCusBtn.FlatAppearance.BorderSize = 0;
            viewCusBtn.FlatStyle = FlatStyle.Flat;
            viewCusBtn.Font = new Font("Segoe Print", 9F);
            viewCusBtn.Location = new Point(0, -3);
            viewCusBtn.Name = "viewCusBtn";
            viewCusBtn.Size = new Size(180, 75);
            viewCusBtn.TabIndex = 1;
            viewCusBtn.Text = "Müşteri Görüntüle";
            viewCusBtn.UseVisualStyleBackColor = false;
            viewCusBtn.Click += viewCusBtn_Click;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = Color.Lavender;
            btnPanel.Controls.Add(addStaffBtn);
            btnPanel.Controls.Add(addCusBtn);
            btnPanel.Controls.Add(viewStaffBtn);
            btnPanel.Controls.Add(acceptCusBtn);
            btnPanel.Controls.Add(viewCusBtn);
            btnPanel.Dock = DockStyle.Top;
            btnPanel.Location = new Point(0, 75);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(900, 69);
            btnPanel.TabIndex = 2;
            // 
            // addStaffBtn
            // 
            addStaffBtn.BackColor = Color.Lavender;
            addStaffBtn.FlatAppearance.BorderSize = 0;
            addStaffBtn.FlatStyle = FlatStyle.Flat;
            addStaffBtn.Font = new Font("Segoe Print", 9F);
            addStaffBtn.Location = new Point(360, -3);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.Size = new Size(180, 75);
            addStaffBtn.TabIndex = 4;
            addStaffBtn.Text = "Personel Ekle";
            addStaffBtn.UseVisualStyleBackColor = false;
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // addCusBtn
            // 
            addCusBtn.BackColor = Color.Lavender;
            addCusBtn.FlatAppearance.BorderSize = 0;
            addCusBtn.FlatStyle = FlatStyle.Flat;
            addCusBtn.Font = new Font("Segoe Print", 9F);
            addCusBtn.Location = new Point(540, -3);
            addCusBtn.Name = "addCusBtn";
            addCusBtn.Size = new Size(180, 75);
            addCusBtn.TabIndex = 3;
            addCusBtn.Text = "Müşteri Ekle";
            addCusBtn.UseVisualStyleBackColor = false;
            addCusBtn.Click += addCusBtn_Click;
            // 
            // viewStaffBtn
            // 
            viewStaffBtn.BackColor = Color.Lavender;
            viewStaffBtn.FlatAppearance.BorderSize = 0;
            viewStaffBtn.FlatStyle = FlatStyle.Flat;
            viewStaffBtn.Font = new Font("Segoe Print", 9F);
            viewStaffBtn.Location = new Point(720, -3);
            viewStaffBtn.Name = "viewStaffBtn";
            viewStaffBtn.Size = new Size(180, 75);
            viewStaffBtn.TabIndex = 5;
            viewStaffBtn.Text = "Personel Görüntüle";
            viewStaffBtn.UseVisualStyleBackColor = false;
            viewStaffBtn.Click += viewStaffBtn_Click;
            // 
            // acceptCusBtn
            // 
            acceptCusBtn.BackColor = Color.Lavender;
            acceptCusBtn.FlatAppearance.BorderSize = 0;
            acceptCusBtn.FlatStyle = FlatStyle.Flat;
            acceptCusBtn.Font = new Font("Segoe Print", 9F);
            acceptCusBtn.Location = new Point(180, -3);
            acceptCusBtn.Name = "acceptCusBtn";
            acceptCusBtn.Size = new Size(180, 75);
            acceptCusBtn.TabIndex = 2;
            acceptCusBtn.Text = "Müşteri Onayla";
            acceptCusBtn.UseVisualStyleBackColor = false;
            acceptCusBtn.Click += acceptCusBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 144);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 423);
            mainPanel.TabIndex = 3;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new Point(0, 570);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(64, 30);
            unitLabel.TabIndex = 6;
            unitLabel.Text = "label1";
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(11F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(900, 600);
            Controls.Add(unitLabel);
            Controls.Add(mainPanel);
            Controls.Add(btnPanel);
            Controls.Add(panel1);
            Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ProfilePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ProfilePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button viewCusBtn;
        private Panel btnPanel;
        private Button addCusBtn;
        private Button viewStaffBtn;
        private Button acceptCusBtn;
        private Button addStaffBtn;
        private PictureBox exitButton;
        private PictureBox settingsButton;
        private Panel mainPanel;
        public Label nameLabel;
        public Label roleLabel;
        public Label unitLabel;
        public Label pageNameLabel;
    }
}