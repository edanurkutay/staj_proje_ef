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
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
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
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(81, 135);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(185, 34);
            maskedTextBox2.TabIndex = 22;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(81, 184);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(185, 34);
            maskedTextBox1.TabIndex = 21;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Location = new Point(148, 292);
            button1.Name = "button1";
            button1.Size = new Size(118, 55);
            button1.TabIndex = 20;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 34);
            textBox5.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 34);
            textBox1.TabIndex = 6;
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
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
    }
}