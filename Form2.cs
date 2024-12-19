using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public string std { get; set; }

        public string music;

        public string txt { get; set; }

        SoundPlayer player = new SoundPlayer("D:\\Мои документы\\Рабочий стол\\sample-15s.wav");
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false; // Отключение кнопки максимизации
            checkedListBox1.Visible = false;
            pictureBox4.Visible = false;
            player.PlayLooping();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

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

        public void UpdateBackgroundColor()
        {
            if (checkedListBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.FromArgb(255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный бегемот с едой.png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\зверополис\черный барсук.png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\черное меню.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\черное меню.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\черные рекорды.png";
                pictureBox5.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черная играть.png";
                pictureBox6.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox7.Image = Image.FromFile(imagePath6);
            }
            else if (checkedListBox1.SelectedIndex == 1)
            {
                this.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
                label1.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\бегемот с едой(271, 349).png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\зверополис\барсук (188, 175).png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\меню.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\меню.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\рекорды.png";
                pictureBox5.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\играть.png";
                pictureBox6.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox7.Image = Image.FromFile(imagePath6);
            }


            if (checkedListBox1.SelectedIndex == 2)
            {
                music = "no";
                player.Stop();
            }
            else
            {
                if (checkedListBox1.SelectedIndex == 3)
                {
                    music = "yes";
                    player.PlayLooping();
                }
            }

            if (checkedListBox1.SelectedIndex == 4)
            {
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBackgroundColor();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = txt;
            // Устанавливаем цвет текста в зависимости от значения ka
            if (std == "Color [A=255, R=255, G=255, B=192]")
            {
                label1.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\бегемот с едой(271, 349).png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\зверополис\барсук (188, 175).png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\меню.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\меню.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\рекорды.png";
                pictureBox5.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\играть.png";
                pictureBox6.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox7.Image = Image.FromFile(imagePath6);
            }
            else if (std == "Color [Black]")
            {
                label1.ForeColor = Color.FromArgb(255, 255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный бегемот с едой.png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\зверополис\черный барсук.png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\черное меню.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\черное меню.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\черные рекорды.png";
                pictureBox5.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черная играть.png";
                pictureBox6.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox7.Image = Image.FromFile(imagePath6);

            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (comboBox1.SelectedIndex == 2)
            {
                Form3 form3 = new Form3();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form3.ka = k; // Передаем значение
                form3.BackColor = this.BackColor; // Устанавливаем цвет фона
                form3.Show(); // Показываем Form3
            }
            if (comboBox1.SelectedIndex == 0)
            {
                Form5 form5 = new Form5();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form5.ka = k; // Передаем значение
                form5.BackColor = this.BackColor; // Устанавливаем цвет фона
                form5.Show();

            }

            if (comboBox1.SelectedIndex == 1)
            {
                Form4 form4 = new Form4();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form4.ka = k; // Передаем значение
                form4.BackColor = this.BackColor; // Устанавливаем цвет фона
                form4.Show();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Form6 form6 = new Form6();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form6.ka = k; // Передаем значение
                form6.BackColor = this.BackColor; // Устанавливаем цвет фона
                form6.Show();
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Form7 form7 = new Form7();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form7.ka = k; // Передаем значение
                form7.BackColor = this.BackColor; // Устанавливаем цвет фона
                form7.Show();
            }
            if (comboBox1.SelectedIndex == 5)
            {
                Form8 form8 = new Form8();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form8.ka = k; // Передаем значение
                form8.BackColor = this.BackColor;// Устанавливаем цвет фона
                form8.Show();
            }

            try
            {
                if (comboBox1.Items.Count > 6 && comboBox1.SelectedIndex == 6)
                {
                    Form9 form9 = new Form9();

                    if (this.BackColor != null)
                    {
                        string k = this.BackColor.ToString(); // Получаем значение цвета
                        form9.ka = k; // Передаем значение
                        form9.BackColor = this.BackColor;
                    }
                    else
                    {
                        MessageBox.Show("Цвет фона не установлен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    form9.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form= new Form1();
            form.Close();
        }
    }
}
