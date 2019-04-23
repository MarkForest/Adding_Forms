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
    public partial class Child : Form
    {
        public string Ttext {
            set
            {
                textBox2.Text = value;
            }
        }

        public Child()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }

        public Child(string text)
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
            textBox2.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DialogResult ShowDialog(string text)
        {
            textBox2.Text = text;
            return ShowDialog();
        }
    }
}
