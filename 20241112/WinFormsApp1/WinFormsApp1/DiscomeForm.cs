using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DiscomeForm : Form
    {
        public DiscomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "=====================\r\n";
                if (checkBox1.Checked)
            {
                Form1.price = Form1.price * 0.95;
                Form1.msg += "會員打95折\r\n";
            }
            if (checkBox2.Checked)
            {
                Form1.price = Form1.price -20;
                Form1.msg += "折扣20元\r\n";
            }
            Form1.msg += "實收" + Math.Round(Form1.price, 2).ToString()+"元";
            this.Dispose();
        }
    }
}
