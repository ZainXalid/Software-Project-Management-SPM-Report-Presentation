using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String pass = textBox2.Text;
            MessageBox.Show(name, pass);
        }
    }
}
