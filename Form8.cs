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
    public partial class Form8 : Form
    {
        int chet = 0;

        public string ka { get; set; }

        public Form8()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pictureBox26.Visible = false;
            listBox1.Visible = false;
        }

        private void Proverka()
        {
            if (chet == 9)
            {
                MessageBox.Show("Ты всё нашёл! Молодец!");
                this.Close();
                Form2 form2 = new Form2();
                form2.std = ka;
                form2.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\вентеляция 2.0.png";
            pictureBox3.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\вентеляция 2.2.png";
            pictureBox4.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            Proverka();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\вентеляция 2.0.png";
            pictureBox3.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\вентеляция 2.2.png";
            pictureBox4.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            Proverka();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\вода 2.0.png";
            pictureBox5.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\вода 2.2.png";
            pictureBox6.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            Proverka();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\вода 2.0.png";
            pictureBox5.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\вода 2.2.png";
            pictureBox6.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            Proverka();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\ляп 2.0.png";
            pictureBox7.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\ляп 2.2.png";
            pictureBox8.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            Proverka();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\ляп 2.0.png";
            pictureBox7.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\ляп 2.2.png";
            pictureBox8.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            Proverka();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                label1.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\кнопки\назад.png";
                pictureBox23.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox24.Image = Image.FromFile(imagePath1);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox25.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox26.Image = Image.FromFile(imagePath6);

            }
            else if (ka == "Color [Black]")
            {
                label1.ForeColor = Color.FromArgb(255, 255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\кнопки\черная назад.png";
                pictureBox23.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox24.Image = Image.FromFile(imagePath1);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox25.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox26.Image = Image.FromFile(imagePath6);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\майка 2.0.png";
            pictureBox9.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\майка 2.2.png";
            pictureBox10.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            Proverka();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\майка 2.0.png";
            pictureBox9.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\майка 2.2.png";
            pictureBox10.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            Proverka();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\мыло 2.0.png";
            pictureBox11.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\мыло 2.2.png";
            pictureBox12.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            Proverka();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\мыло 2.0.png";
            pictureBox11.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\мыло 2.2.png";
            pictureBox12.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            Proverka();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\носочки 2.0.png";
            pictureBox13.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\носочки 2.2.png";
            pictureBox14.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            Proverka();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\носочки 2.0.png";
            pictureBox13.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\носочки 2.2.png";
            pictureBox14.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            Proverka();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\полотенце 2.0.png";
            pictureBox15.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\полотенце 2.2.png";
            pictureBox16.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            Proverka();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\полотенце 2.0.png";
            pictureBox15.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\полотенце 2.2.png";
            pictureBox16.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            Proverka();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\пузырики 2.0.png";
            pictureBox17.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\пузырники 2.2.png";
            pictureBox18.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;
            Proverka();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\пузырики 2.0.png";
            pictureBox17.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\пузырники 2.2.png";
            pictureBox18.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;
            Proverka();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\шорты 2.0.png";
            pictureBox19.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\шорты 2.2.png";
            pictureBox20.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox19.Enabled = false;
            pictureBox20.Enabled = false;
            Proverka();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\шорты 2.0.png";
            pictureBox19.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\шорты 2.2.png";
            pictureBox20.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox19.Enabled = false;
            pictureBox20.Enabled = false;
            Proverka();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\отличатся\щетка 2.0.png";
            pictureBox21.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\отличатся\щетка 2.2.png";
            pictureBox22.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox21.Enabled = false;
            pictureBox22.Enabled = false;
            Proverka();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            string k = this.BackColor.ToString(); // Получаем значение цвета
            form2.std = k; // Передаем значение
            form2.BackColor = this.BackColor; // Устанавливаем цвет фона
            form2.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Visible = false;
            pictureBox26.Visible = true;
            listBox1.Visible = true;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Visible = false;
            pictureBox25.Visible = true;
            listBox1.Visible = false;
        }
    }
}
