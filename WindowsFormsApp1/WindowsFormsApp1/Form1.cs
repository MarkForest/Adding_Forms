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

        private void button1_Click(object sender, EventArgs e)
        {
            //Передаем данные используя конструктор дочерней формы
            Child child = new Child(textBox1.Text);
            child.ShowDialog();
            MessageBox.Show("Дочерняя форма завершила свою работу");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.Ttext = textBox1.Text;
            child.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            child.ShowDialog(textBox1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if(addForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(addForm.Ttext);
            }
        }

        private void btnMagic_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label1.Text = dialog.SelectedPath;
            }
        }
    }
}
