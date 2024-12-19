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
    public partial class Form6 : Form
    {
        public string ka { get; set; }



        private string bigWord = "программирование"; // Большое слово
        private HashSet<string> validWords; // Множество допустимых слов
        private List<string> foundWords; // Список найденных слов
        public Form6()
        {
            InitializeComponent();
            InitializeGame();
            this.MaximizeBox = false;
            pictureBox6.Visible = false;
            listBox1.Visible = false;
        }
        private void InitializeGame()
        {
            // Инициализация допустимых слов (можно расширить)
            validWords = new HashSet<string>
            {
                "программа", "мир", "ром", "грамм", "гамма", "мама", "ров", "вор", "порог","гора", "рог", "рама", "пирог", "пар", "прима", "рана"
            };

            foundWords = new List<string>();
            textBox1.Clear();
        }

        private void Proverka()
        {
            if (richTextBox1.Text != "" && richTextBox20.Text != "" && richTextBox40.Text != ""
                 && richTextBox12.Text != "" && richTextBox47.Text != "" && richTextBox37.Text != ""
                  && richTextBox59.Text != "" && richTextBox51.Text != "" && richTextBox44.Text != ""
                   && richTextBox34.Text != "" && richTextBox68.Text != "" && richTextBox25.Text != ""
                    && richTextBox56.Text != "" && richTextBox30.Text != ""
                     && richTextBox64.Text != "" && richTextBox17.Text != "")
            {
                MessageBox.Show("Вы молодец! Вы прошли уровень!");
                this.Close();
                Form2 form = new Form2();
                form.std = ka;
                form.Show();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) // Проверяем, что текст не пустой
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // Удаляем последний символ
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\галстук(303, 227).png";
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

                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный галстук.png";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string inputWord = textBox1.Text.Trim().ToLower(); // Получаем введённое слово

            if (string.IsNullOrWhiteSpace(inputWord))
            {
                MessageBox.Show("Введите слово!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, является ли слово допустимым и не найденным ранее
            if (validWords.Contains(inputWord) && !foundWords.Contains(inputWord))
            {
                /*  foundWords.Add(inputWord); // Добавляем слово в найденные
                  listBox1.Items.Add(inputWord); // Отображаем слово в списке
                  textBox1.Clear(); // Очищаем поле ввода*/
                string word = textBox1.Text;
                if (word == "программа")
                {
                    richTextBox1.Text = "п";
                    richTextBox2.Text = "р";
                    richTextBox3.Text = "о";
                    richTextBox4.Text = "г";
                    richTextBox5.Text = "р";
                    richTextBox6.Text = "а";
                    richTextBox7.Text = "м";
                    richTextBox8.Text = "м";
                    richTextBox9.Text = "а";
                }
                if (word == "мир")
                {
                    richTextBox12.Text = "м";
                    richTextBox11.Text = "и";
                    richTextBox10.Text = "р";
                }
                if (word == "порог")
                {
                    richTextBox17.Text = "п";
                    richTextBox16.Text = "о";
                    richTextBox15.Text = "р";
                    richTextBox14.Text = "о";
                    richTextBox13.Text = "г";
                }
                if (word == "ром")
                {
                    richTextBox20.Text = "р";
                    richTextBox19.Text = "о";
                    richTextBox18.Text = "м";
                }
                if (word == "грамм")
                {
                    richTextBox25.Text = "г";
                    richTextBox24.Text = "р";
                    richTextBox23.Text = "а";
                    richTextBox22.Text = "м";
                    richTextBox21.Text = "м";
                }
                if (word == "гамма")
                {
                    richTextBox30.Text = "г";
                    richTextBox29.Text = "а";
                    richTextBox28.Text = "м";
                    richTextBox27.Text = "м";
                    richTextBox26.Text = "а";
                }
                if (word == "мама")
                {
                    richTextBox34.Text = "м";
                    richTextBox33.Text = "а";
                    richTextBox32.Text = "м";
                    richTextBox31.Text = "а";
                }
                if (word == "ров")
                {
                    richTextBox37.Text = "р";
                    richTextBox36.Text = "о";
                    richTextBox35.Text = "в";
                }
                if (word == "вор")
                {
                    richTextBox40.Text = "в";
                    richTextBox39.Text = "о";
                    richTextBox38.Text = "р";
                }
                if (word == "гора")
                {
                    richTextBox44.Text = "г";
                    richTextBox43.Text = "о";
                    richTextBox42.Text = "р";
                    richTextBox41.Text = "а";
                }
                if (word == "рог")
                {
                    richTextBox47.Text = "р";
                    richTextBox46.Text = "о";
                    richTextBox45.Text = "г";
                }
                if (word == "рама")
                {
                    richTextBox51.Text = "р";
                    richTextBox50.Text = "а";
                    richTextBox49.Text = "м";
                    richTextBox48.Text = "а";
                }
                if (word == "пирог")
                {
                    richTextBox56.Text = "п";
                    richTextBox55.Text = "и";
                    richTextBox54.Text = "р";
                    richTextBox53.Text = "о";
                    richTextBox52.Text = "г";
                }
                if (word == "пар")
                {
                    richTextBox59.Text = "п";
                    richTextBox58.Text = "а";
                    richTextBox57.Text = "р";
                }
                if (word == "прима")
                {
                    richTextBox64.Text = "п";
                    richTextBox63.Text = "р";
                    richTextBox62.Text = "и";
                    richTextBox61.Text = "м";
                    richTextBox60.Text = "а";
                }
                if (word == "рана")
                {
                    richTextBox68.Text = "р";
                    richTextBox67.Text = "а";
                    richTextBox66.Text = "н";
                    richTextBox65.Text = "а";
                }
                textBox1.Clear();
                Proverka();
            }
            else
            {
                MessageBox.Show("Слово недопустимо или уже найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear(); // Очищаем поле ввода
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
            listBox1.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
            listBox1.Visible = false;
        }
    }
}
