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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            richTextBox6.Visible = false;
            richTextBox7.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = "";
            word += richTextBox1.Text;
            word += richTextBox2.Text;
            word += richTextBox3.Text;
            word += richTextBox4.Text;
            word += richTextBox5.Text;
            if (word == "хомяк")
            {
                MessageBox.Show("Вы отгадали один Ребус!Продолжайте в том же духе!");
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox3.Clear();
                richTextBox4.Clear();
                richTextBox5.Clear();
                richTextBox7.Visible = true;
                richTextBox6.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = richTextBox1.Text + richTextBox2.Text + richTextBox3.Text + richTextBox4.Text + richTextBox5.Text + richTextBox7.Text + richTextBox6.Text;
            if (word == "пифагор")
            {
                MessageBox.Show("Вы отгадали один Ребус!Продолжайте в том же духе!");
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox3.Clear();
                richTextBox4.Clear();
                richTextBox5.Clear();
                richTextBox7.Visible = false;
                richTextBox6.Visible = false;
                button2.Visible = false;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string word = richTextBox1.Text + richTextBox2.Text + richTextBox3.Text + richTextBox4.Text + richTextBox5.Text;
            if (word == "минус")
            {
                MessageBox.Show("Ты отгадал последний ребус и прошёл уровень! Поздравляю!");
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }
    }
}
