namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            首頁ToolStripMenuItem = new ToolStripMenuItem();
            點餐ToolStripMenuItem = new ToolStripMenuItem();
            折扣優惠ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(501, 12);
            button1.Name = "button1";
            button1.Size = new Size(287, 211);
            button1.TabIndex = 0;
            button1.Text = "外帶";
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(501, 227);
            button2.Name = "button2";
            button2.Size = new Size(287, 211);
            button2.TabIndex = 1;
            button2.Text = "內用";
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 379);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(48, 415);
            button3.Name = "button3";
            button3.Size = new Size(155, 23);
            button3.TabIndex = 3;
            button3.Text = "清除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(209, 415);
            button4.Name = "button4";
            button4.Size = new Size(155, 23);
            button4.TabIndex = 4;
            button4.Text = "離開";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 首頁ToolStripMenuItem, 點餐ToolStripMenuItem, 折扣優惠ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 首頁ToolStripMenuItem
            // 
            首頁ToolStripMenuItem.Name = "首頁ToolStripMenuItem";
            首頁ToolStripMenuItem.Size = new Size(43, 20);
            首頁ToolStripMenuItem.Text = "首頁";
            首頁ToolStripMenuItem.Click += 首頁ToolStripMenuItem_Click;
            // 
            // 點餐ToolStripMenuItem
            // 
            點餐ToolStripMenuItem.Name = "點餐ToolStripMenuItem";
            點餐ToolStripMenuItem.Size = new Size(43, 20);
            點餐ToolStripMenuItem.Text = "點餐";
            點餐ToolStripMenuItem.Click += 點餐ToolStripMenuItem_Click;
            // 
            // 折扣優惠ToolStripMenuItem
            // 
            折扣優惠ToolStripMenuItem.Name = "折扣優惠ToolStripMenuItem";
            折扣優惠ToolStripMenuItem.Size = new Size(67, 20);
            折扣優惠ToolStripMenuItem.Text = "折扣優惠";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "首頁";
            Activated += Form1_Activated;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 首頁ToolStripMenuItem;
        private ToolStripMenuItem 點餐ToolStripMenuItem;
        private ToolStripMenuItem 折扣優惠ToolStripMenuItem;
    }
}