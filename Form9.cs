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
    public partial class Form9 : Form
    {
        public string ka { get; set; }

        public Form9()
        {
            InitializeComponent();
            listBox1.Visible = false;
            listBox2.Visible = false;
            pictureBox6.Visible = false;
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            // Устанавливаем цвет текста в зависимости от значения ka
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\лотос (208, 257).png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\проверить.png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\назад.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath6);
            }
            else if (ka == "Color [Black]")
            {
                label2.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label3.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label4.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label5.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label6.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label7.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label8.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label9.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label10.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label11.ForeColor = Color.FromArgb(255, 255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный лотос.png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath1 = @"D:\Мои документы\Рабочий стол\кнопки\черное проверить.png";
                pictureBox2.Image = Image.FromFile(imagePath1);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\кнопки\черная назад.png";
                pictureBox3.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox4.Image = Image.FromFile(imagePath3);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath6);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Научный процесс, направленный на получение новых знаний");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Основной элемент речи, используемый для передачи информации");

        }

        private void label4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Учебная группа, в которой проходят занятия");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Последовательность действий для решения задачи или выполнения операции");

        }

        private void label6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Может быть в различных формах, таких как кинетическая, потенциальная,");
            listBox1.Items.Add("тепловая и электрическая");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Строение, предназначенное для проживания и отдыха");

        }

        private void label8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Брус, который находится на полу под дверью, обычно деревянный");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Сладкий фрукт красного или тёмно-красного цвета, часто используется");
            listBox1.Items.Add("в десертах");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Может означать защитное сооружение, например, для укрепления берегов");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            listBox1.Items.Add("Информация, собранная для анализа или обработки");
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox2.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox13.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox14.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox16.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox20.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox18.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox17.Text.Length >= 1)
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

        private void richTextBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox24.Text.Length >= 1)
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

        private void richTextBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox23.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox22.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox21.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox26.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox25.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox32.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox6.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox31.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox30.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox29.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox28.Text.Length >= 1)
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

        private void richTextBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox34.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox39_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox39.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox37.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox8.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox36.Text.Length >= 1)
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

        private void richTextBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox43.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox42_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox42.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox41.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox44.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox10.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox48.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox47.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox46.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox9.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox50.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox49.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox12.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox11.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string clovo = richTextBox2.Text + richTextBox13.Text + richTextBox14.Text + richTextBox15.Text + richTextBox16.Text;
            string klass = richTextBox20.Text + richTextBox19.Text + richTextBox18.Text + richTextBox17.Text + richTextBox4.Text;
            string algoritm = richTextBox24.Text + richTextBox3.Text + richTextBox23.Text + richTextBox22.Text + richTextBox21.Text + richTextBox27.Text + richTextBox26.Text + richTextBox25.Text;
            string energia = richTextBox33.Text + richTextBox32.Text + richTextBox6.Text + richTextBox31.Text + richTextBox30.Text + richTextBox29.Text + richTextBox28.Text;
            string dom = richTextBox5.Text + richTextBox35.Text + richTextBox34.Text;
            string porog = richTextBox39.Text + richTextBox38.Text + richTextBox37.Text + richTextBox8.Text + richTextBox36.Text;
            string vishna = richTextBox7.Text + richTextBox43.Text + richTextBox42.Text + richTextBox41.Text + richTextBox40.Text;
            string val = richTextBox44.Text + richTextBox10.Text + richTextBox45.Text;
            string dannae = richTextBox48.Text + richTextBox47.Text + richTextBox46.Text + richTextBox9.Text + richTextBox50.Text + richTextBox49.Text;


            if (clovo == "слово" || clovo == "Слово" || clovo == "СЛОВО")
            {
                if (klass == "класс" || klass == "Класс" || klass == "КЛАСС")
                {
                    if (algoritm == "алгоритм" || algoritm == "Алгоритм" || algoritm == "АЛГОРИТМ")
                    {
                        if (energia == "энергия" || energia == "Энергия" || energia == "ЭНЕРГИЯ")
                        {
                            if (dom == "дом" || dom == "Дом" || dom == "ДОМ")
                            {
                                if (porog == "порог" || porog == "Порог" || porog == "ПОРОГ")
                                {
                                    if (vishna == "ВИШНЯ" || vishna == "Вишня" || vishna == "вишня")
                                    {
                                        if (val == "вал" || val == "Вал" || val == "ВАЛ")
                                        {
                                            if (dannae == "данные" || dannae == "Данные" || dannae == "ДАННЫЕ")
                                            {
                                                if (richTextBox12.Text == "и" && richTextBox11.Text == "е")
                                                {
                                                    MessageBox.Show("Вы отгадали все слова!");
                                                    this.Close();
                                                    Form2 form2 = new Form2();
                                                    string k = this.BackColor.ToString(); // Получаем значение цвета
                                                    form2.std = k; // Передаем значение
                                                    form2.BackColor = this.BackColor; // Устанавливаем цвет фона
                                                    form2.Show();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Вы неправильно отгадали первое слово!");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Вы неправильно отгадали десятое слово!");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Вы неправильно отгадали девятое слово!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Вы неправильно отгадали восьмое слово!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Вы неправильно отгадали седьмое слово!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Вы неправильно отгадали шестое слово!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Вы неправильно отгадали пятое слово!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы неправильно отгадали четвёртое слово!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы неправильно отгадали третье слово!");
                }
            }
            else
            {
                MessageBox.Show("Вы неправильно отгадали второе слово!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            string k = this.BackColor.ToString(); // Получаем значение цвета
            form2.std = k; // Передаем значение
            form2.BackColor = this.BackColor; // Устанавливаем цвет фона
            form2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            listBox2.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
            listBox2.Visible = true;
        }
    }
}
