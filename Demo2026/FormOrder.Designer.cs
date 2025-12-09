namespace Demo2026
{
    partial class FormOrder
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            domainUpDown1 = new DomainUpDown();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(296, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 285);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(296, 23);
            textBox7.TabIndex = 6;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(12, 332);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 7;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(165, 333);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(143, 23);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(12, 375);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(296, 111);
            textBox9.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(324, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 293);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(441, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(337, 375);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 111);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(20, 26);
            button2.Name = "button2";
            button2.Size = new Size(111, 64);
            button2.TabIndex = 0;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(151, 26);
            button3.Name = "button3";
            button3.Size = new Size(115, 64);
            button3.TabIndex = 1;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 498);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(domainUpDown1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormOrder";
            Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DomainUpDown domainUpDown1;
        private TextBox textBox8;
        private TextBox textBox9;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
    }
}