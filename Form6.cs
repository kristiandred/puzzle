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
        private string bigWord = "программирование"; // Большое слово
        private HashSet<string> validWords; // Множество допустимых слов
        private List<string> foundWords; // Список найденных слов
        public Form6()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            // Инициализация допустимых слов (можно расширить)
            validWords = new HashSet<string>
            {
                "программа", "мир", "ром", "грамм", "гамма", "мама", "ров", "вор", "порог","гора", "рог", "рама", "пирог", "пар", "прима", "рана"
            };

            foundWords = new List<string>();
            // label1.Text = bigWord; // Отображаем большое слово
            textBox1.Clear(); // Очищаем поле ввода
                              // listBox1.Items.Clear(); // Очищаем список найденных слов
        }

        private void button1_Click(object sender, EventArgs e)
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
                    richTextBox51.Text = "р";
                    richTextBox50.Text = "а";
                    richTextBox49.Text = "н";
                    richTextBox48.Text = "а";
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Слово недопустимо или уже найдено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear(); // Очищаем поле ввода
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
    }
}
