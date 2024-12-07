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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (comboBox1.SelectedIndex == 2)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Form7 form7 = new Form7();
                form7.Show();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Form8 form8 = new Form8();
                form8.Show();
            }/*
            if (comboBox1.SelectedIndex == 6)
             {
            Form9 form9 = new Form9();
                 form9.Show();
             }
            if (comboBox1.SelectedIndex == 7)
             {
            Form10 form10 = new Form10();
                 form10.Show();
             }
            if (comboBox1.SelectedIndex == 8)
             {
            Form11 form11 = new Form11();
                 form11.Show();
            if (comboBox1.SelectedIndex == 9)
             {
            Form12 form12 = new Form12();
                 form12.Show();
             }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        int k = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 7)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 8)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
            if (comboBox1.SelectedIndex == 9)
            {
                k = comboBox1.SelectedIndex;
                label1.Text = $"{(k + 1).ToString()} уровень";
            }
        }
    }
}
