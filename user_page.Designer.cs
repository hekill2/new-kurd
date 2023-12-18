namespace Kursovoe
{
    partial class user_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_page));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_font_angle_left_3916912;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.free_icon_font_user_3917688;
            pictureBox2.Location = new Point(12, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.free_icon_font_envelope_3916611;
            pictureBox4.Location = new Point(12, 332);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.free_icon_font_phone_call_5068703;
            pictureBox5.Location = new Point(12, 240);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 68);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 185);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 276);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 368);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(162, 438);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(205, 32);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Замінити пароль.\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // user_page
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(642, 967);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "user_page";
            Text = "ConOfOrd";
            Load += user_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void passwordreplaс()
        {
            textpass = new TextBox();
            textpass.Location = new Point(165,540);
            textpass.Size = new Size(205, 64);
            Controls.Add(textpass);
            labelpass = new Label();
            labelpass.Location = new Point(90, 500);
            labelpass.Text = "Для заміни пароля введіть старий пароль";
            labelpass.Size = new Size(780, 32);
            labelpass.TabIndex = 7;
            Controls.Add(labelpass);
            textpassnew = new TextBox();
            textpassnew.Location = new Point(165,600);
            textpassnew.Size = new Size(205, 64);
            Controls.Add(textpassnew);
            buttonpassnew = new Button();
            buttonpassnew.Location = new Point(165, 650);
            buttonpassnew.Size = new Size(205, 64);
            buttonpassnew.Text = "Замінити пароль";
            buttonpassnew.Click += ClicButtonPasNew;
            buttonpassnew.BackColor = Color.White;
            Controls.Add(buttonpassnew);
        }
        
        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox textpass;
        private TextBox textpassnew;
        private Label labelpass;
        private Button buttonpassnew;
    }
}