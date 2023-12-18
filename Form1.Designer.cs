namespace Kursovoe
{
    partial class ButtAutoreg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtAutoreg));
            button1 = new Button();
            txtPassword = new TextBox();
            labelAutoreg = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = SystemColors.Window;
            button1.Location = new Point(174, 500);
            button1.Name = "button1";
            button1.Size = new Size(227, 63);
            button1.TabIndex = 0;
            button1.Text = "Увійти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(183, 325);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(208, 39);
            txtPassword.TabIndex = 1;
            // 
            // labelAutoreg
            // 
            labelAutoreg.Anchor = AnchorStyles.Top;
            labelAutoreg.AutoSize = true;
            labelAutoreg.Location = new Point(90, 391);
            labelAutoreg.Name = "labelAutoreg";
            labelAutoreg.Size = new Size(378, 64);
            labelAutoreg.TabIndex = 3;
            labelAutoreg.TabStop = true;
            labelAutoreg.Text = "Ще не маєте облікового запису?\r\n            Зареєструватися              ";
            labelAutoreg.LinkClicked += labelAutoreg_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.free_icon_font_phone_call_5068703;
            pictureBox1.Location = new Point(132, 193);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(132, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(6, 640);
            label2.Name = "label2";
            label2.Size = new Size(596, 23);
            label2.TabIndex = 8;
            label2.Text = "Вітаємо у найкрацому застосунку для передзамовлень \"ConOfOrd\"\r\n";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(289, 59);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(208, 39);
            maskedTextBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 10;
            // 
            // ButtAutoreg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(595, 667);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelAutoreg);
            Controls.Add(txtPassword);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ButtAutoreg";
            Text = "ConOfOrd";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPassword;
        private LinkLabel labelAutoreg;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
    }
}
