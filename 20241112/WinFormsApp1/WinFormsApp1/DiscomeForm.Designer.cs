namespace WinFormsApp1
{
    partial class DiscomeForm
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "我有會員";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(92, 12);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "我有20元折價眷";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(121, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "確定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DiscomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 70);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "DiscomeForm";
            Text = "折價";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
    }
}