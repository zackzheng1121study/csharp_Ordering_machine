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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        string[] maindish = new string[] { "漢堡", "炸雞", "雙層牛肉吉事堡" };
        int[] dishPrice = new int[] { 100, 120, 130 };
        string[] maindessert = new string[] { "薯條", "雞塊", "冰炫風" };
        int[] dessertPrice = new int[] { 50, 60, 70 };
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(maindessert);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(maindish);
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg +=comboBox2.Text + " " + dishPrice[comboBox2.SelectedIndex]+"\r\n";
            Form1.msg += comboBox1.Text + " " + dessertPrice[comboBox1.SelectedIndex] + "\r\n";
            Form1.price += dishPrice[comboBox2.SelectedIndex]+ dessertPrice[comboBox1.SelectedIndex];
            Form1.msg += $"合計{Form1.price}元\r\n";
            this.Dispose();



            DiscomeForm DF = new DiscomeForm();
            DF.ShowDialog();
        }
    }
}
