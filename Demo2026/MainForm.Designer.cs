namespace Demo2026
{
    partial class MainForm
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
            labelUser = new Label();
            SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.Right;
            labelUser.Font = new Font("Segoe UI", 14F);
            labelUser.Location = new Point(580, 9);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(208, 45);
            labelUser.TabIndex = 0;
            labelUser.Text = "label1";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelUser);
            Name = "MainForm";
            Text = "Главная";
            FormClosed += MainForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Label labelUser;
    }
}