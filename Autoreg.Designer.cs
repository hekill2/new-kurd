namespace Kursovoe
{
    partial class Autoreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autoreg));
            textName = new TextBox();
            textPost = new TextBox();
            textPass = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(483, 138);
            textName.Name = "textName";
            textName.Size = new Size(200, 39);
            textName.TabIndex = 5;
            // 
            // textPost
            // 
            textPost.Location = new Point(483, 336);
            textPost.Name = "textPost";
            textPost.Size = new Size(200, 39);
            textPost.TabIndex = 6;
            // 
            // textPass
            // 
            textPass.Location = new Point(483, 415);
            textPass.Name = "textPass";
            textPass.Size = new Size(200, 39);
            textPass.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Location = new Point(438, 511);
            button1.Name = "button1";
            button1.Size = new Size(229, 69);
            button1.TabIndex = 9;
            button1.Text = "Зареєструватися";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.free_icon_font_phone_call_5068703;
            pictureBox1.Location = new Point(408, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.free_icon_font_envelope_3916611;
            pictureBox2.Location = new Point(408, 315);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._lock;
            pictureBox3.Location = new Point(408, 404);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.free_icon_font_user_3917688;
            pictureBox4.Location = new Point(408, 127);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.free_icon_font_angle_left_3916912;
            pictureBox5.Location = new Point(12, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 49);
            label1.TabIndex = 15;
            label1.Text = "Реєстрація";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(483, 236);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 39);
            maskedTextBox1.TabIndex = 16;
            // 
            // Autoreg
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1249, 746);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textPass);
            Controls.Add(textPost);
            Controls.Add(textName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autoreg";
            Text = "ConOfOrd";
            Load += Autoreg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textName;
        private TextBox textPost;
        private TextBox textPass;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
    }
}