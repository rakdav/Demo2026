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
            textBoxArticul = new TextBox();
            textBoxName = new TextBox();
            textBoxUM = new TextBox();
            textBoxPrice = new TextBox();
            textBoxSuplier = new TextBox();
            textBoxManufactor = new TextBox();
            textBoxCategory = new TextBox();
            textBoxCount = new TextBox();
            textBoxDescription = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBoxArticul
            // 
            textBoxArticul.Location = new Point(12, 12);
            textBoxArticul.Name = "textBoxArticul";
            textBoxArticul.PlaceholderText = "Введите артикул";
            textBoxArticul.Size = new Size(296, 23);
            textBoxArticul.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 54);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Введите название";
            textBoxName.Size = new Size(296, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxUM
            // 
            textBoxUM.Location = new Point(12, 99);
            textBoxUM.Name = "textBoxUM";
            textBoxUM.PlaceholderText = "Введите единицу измерения";
            textBoxUM.Size = new Size(296, 23);
            textBoxUM.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 140);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Введите цену";
            textBoxPrice.Size = new Size(296, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxSuplier
            // 
            textBoxSuplier.Location = new Point(12, 187);
            textBoxSuplier.Name = "textBoxSuplier";
            textBoxSuplier.PlaceholderText = "Введите поставщика";
            textBoxSuplier.Size = new Size(296, 23);
            textBoxSuplier.TabIndex = 4;
            // 
            // textBoxManufactor
            // 
            textBoxManufactor.Location = new Point(12, 233);
            textBoxManufactor.Name = "textBoxManufactor";
            textBoxManufactor.PlaceholderText = "Введите производителя";
            textBoxManufactor.Size = new Size(296, 23);
            textBoxManufactor.TabIndex = 5;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Location = new Point(12, 285);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.PlaceholderText = "Введите категорию";
            textBoxCategory.Size = new Size(296, 23);
            textBoxCategory.TabIndex = 6;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(165, 333);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.PlaceholderText = "Введите остаток";
            textBoxCount.Size = new Size(143, 23);
            textBoxCount.TabIndex = 8;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 375);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Введите описание";
            textBoxDescription.Size = new Size(296, 111);
            textBoxDescription.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(324, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            button1.Click += button1_Click;
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
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(151, 26);
            button3.Name = "button3";
            button3.Size = new Size(115, 64);
            button3.TabIndex = 1;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(20, 26);
            button2.Name = "button2";
            button2.Size = new Size(111, 64);
            button2.TabIndex = 0;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 332);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 498);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxManufactor);
            Controls.Add(textBoxSuplier);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxUM);
            Controls.Add(textBoxName);
            Controls.Add(textBoxArticul);
            Name = "FormOrder";
            Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox9;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        public TextBox textBoxArticul;
        public TextBox textBoxName;
        public TextBox textBoxUM;
        public TextBox textBoxPrice;
        public TextBox textBoxSuplier;
        public TextBox textBoxManufactor;
        public TextBox textBoxCategory;
        public NumericUpDown numericUpDown1;
        public TextBox textBoxCount;
        public TextBox textBoxDescription;
        private OpenFileDialog openFileDialog1;
    }
}