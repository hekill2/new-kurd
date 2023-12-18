namespace Kursovoe
{
    partial class PlacingAnOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacingAnOrder));
            numericUpDown1 = new NumericUpDown();
            checkBoxord = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox4 = new CheckBox();
            sumPlacing = new Label();
            buttonsham = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(371, 667);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 39);
            numericUpDown1.TabIndex = 0;
            // 
            // checkBoxord
            // 
            checkBoxord.AutoSize = true;
            checkBoxord.Location = new Point(12, 552);
            checkBoxord.Name = "checkBoxord";
            checkBoxord.Size = new Size(243, 36);
            checkBoxord.TabIndex = 2;
            checkBoxord.Text = "як модна скоріше";
            checkBoxord.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.None;
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.ControlDarkDark;
            dateTimePicker1.CustomFormat = "H:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.ImeMode = ImeMode.AlphaFull;
            dateTimePicker1.Location = new Point(297, 549);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeftLayout = true;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(159, 39);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.UseWaitCursor = true;
            dateTimePicker1.Value = new DateTime(2023, 12, 12, 22, 1, 37, 0);
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(297, 421);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(146, 36);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "З собою ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 421);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(146, 36);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "У закладі";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(297, 300);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(247, 36);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Карткою у закладі";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 300);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(251, 36);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Готівкою у закладі";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // sumPlacing
            // 
            sumPlacing.AutoSize = true;
            sumPlacing.Font = new Font("Times New Roman", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            sumPlacing.Location = new Point(134, 110);
            sumPlacing.Name = "sumPlacing";
            sumPlacing.Size = new Size(0, 67);
            sumPlacing.TabIndex = 8;
            // 
            // buttonsham
            // 
            buttonsham.Location = new Point(229, 777);
            buttonsham.Name = "buttonsham";
            buttonsham.Size = new Size(214, 81);
            buttonsham.TabIndex = 9;
            buttonsham.Text = "Замовити";
            buttonsham.UseVisualStyleBackColor = true;
            buttonsham.Click += buttonsham_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 10;
            label1.Text = "Спосіб оплати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 360);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 11;
            label2.Text = "Вид упаковки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 485);
            label3.Name = "label3";
            label3.Size = new Size(263, 32);
            label3.TabIndex = 12;
            label3.Text = "Час готовності страви ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 674);
            label4.Name = "label4";
            label4.Size = new Size(327, 32);
            label4.TabIndex = 13;
            label4.Text = "Кількість столових приборів";
            // 
            // PlacingAnOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(782, 942);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonsham);
            Controls.Add(sumPlacing);
            Controls.Add(checkBox4);
            Controls.Add(checkBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBoxord);
            Controls.Add(numericUpDown1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlacingAnOrder";
            StartPosition = FormStartPosition.Manual;
            Text = "ConOfOrd";
            Load += PlacingAnOrder_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private CheckBox checkBoxord;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private Label sumPlacing;
        private Button buttonsham;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}