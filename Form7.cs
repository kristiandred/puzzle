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
        public string ka { get; set; }

        public Form7()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            richTextBox6.Visible = false;
            richTextBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox11.Visible = false;
            listBox1.Visible = false;
        }





        private void Form7_Load(object sender, EventArgs e)
        {
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\тигрёнок (199, 164).png";
                pictureBox4.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\далее.png";
                pictureBox5.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\далее.png";
                pictureBox6.Image = Image.FromFile(imagePath2);
                string imagPath3 = @"D:\Мои документы\Рабочий стол\кнопки\проверить.png";
                pictureBox7.Image = Image.FromFile(imagPath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\назад.png";
                pictureBox8.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox9.Image = Image.FromFile(imagePath5);
                string imagePath6= @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox10.Image = Image.FromFile(imagePath6);
                string imagePath0 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox11.Image = Image.FromFile(imagePath0);
            }
            else if (ka == "Color [Black]")
            {
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный тигрёнок.png";
                pictureBox4.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\черная далее.png";
                pictureBox5.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\черная далее.png";
                pictureBox6.Image = Image.FromFile(imagePath2);
                string imagPath3 = @"D:\Мои документы\Рабочий стол\кнопки\черное проверить.png";
                pictureBox7.Image = Image.FromFile(imagPath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\черная назад.png";
                pictureBox8.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox9.Image = Image.FromFile(imagePath5);
                string imagePath54 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox10.Image = Image.FromFile(imagePath54);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox11.Image = Image.FromFile(imagePath6);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
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
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string word = richTextBox1.Text + richTextBox2.Text + richTextBox3.Text + richTextBox4.Text + richTextBox5.Text;
            if (word == "минус")
            {
                MessageBox.Show("Ты отгадал последний ребус и прошёл уровень! Поздравляю!");
                this.Close();
                Form2 form = new Form2();
                form.std = ka;
                form.Show();
            }
            else
            {
                MessageBox.Show("Неправильно :( Подумай ещё");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            string k = this.BackColor.ToString(); // Получаем значение цвета
            form2.std = k; // Передаем значение
            form2.BackColor = this.BackColor; // Устанавливаем цвет фона
            form2.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void richTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox6.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox1.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox2.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox3.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox4.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox5.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox7.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            listBox1.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox10.Visible = true;
            listBox1.Visible = false;
        }
    }
}
