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
    public partial class Form3 : Form
    {
        int chet = 3;

        public Form3()
        {
            InitializeComponent();
        }
        private void CheckAllRichTextBoxesFilled()
        {
            bool allFilled = true; // Переменная для проверки, заполнены ли все RichTextBox

            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                if (string.IsNullOrWhiteSpace(richTextBox.Text)) // Проверяем, пуст ли RichTextBox
                {
                    allFilled = false; // Если хотя бы один пуст, устанавливаем false
                    break; // Выходим из цикла, так как уже нашли пустой RichTextBox
                }
            }

            if (allFilled) // Если все RichTextBox заполнены
            {
                MessageBox.Show("Все поля заполнены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearAllRichTextBoxes()
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.Clear();
                richTextBox.ReadOnly = false;
            }
            chet = 3;
            richTextBox2.Text = " и";
            richTextBox2.ReadOnly = true;
            richTextBox22.Text = "ш";
            richTextBox22.ReadOnly = true;
            richTextBox10.Text = " о";
            richTextBox10.ReadOnly = true;
            richTextBox37.Text = " к";
            richTextBox37.ReadOnly = true;
            richTextBox62.Text = " б";
            richTextBox62.ReadOnly = true;
            richTextBox68.Text = " е";
            richTextBox68.ReadOnly = true;
            richTextBox26.Text = " :";
            richTextBox26.ReadOnly = true;
            richTextBox48.Text = "  , ";
            richTextBox48.ReadOnly = true;
        }

        private void Proverka()
        {

                    chet -= 1;
                    MessageBox.Show("Неправильная буква");

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                for (int i = 1; i <= 73; i++)
                {
                    var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                    richTextBox.BackColor = Color.White;
                }
                richTextBox1.BackColor = Color.Red;
                string text = richTextBox1.Text;
                if (text != "ж" && chet > 0)
                {
                Proverka();
                    richTextBox1.Clear();
                }

                if (text == "ж")
                {
                    richTextBox1.ReadOnly = true;

                }

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
                label6.Text = $"Осталось попыток {chet.ToString()}";
            

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox3.BackColor = Color.Red;
            richTextBox47.BackColor = Color.Red;
            

            string text = richTextBox3.Text;
            if (text != "з" && chet > 0)
            {
                Proverka();
                richTextBox3.Clear();
            }
            if (text == "з")
            {
                richTextBox3.ReadOnly = true;

            }

            if (chet <= 0)
            {
               // MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
            label6.Text = $"Осталось попыток {chet.ToString()}";
            
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox4.Text;
            if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox4.Clear();
            }
            if (text == "н")
            {
                richTextBox4.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox5.BackColor = Color.Red;
            richTextBox42.BackColor = Color.Red;

            string text = richTextBox5.Text;
            if (text != "ь" && chet > 0)
            {
                Proverka();
                richTextBox5.Clear();
            }
            if (text == "ь")
            {
                richTextBox5.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

                if (chet <= 0)
                {
                 //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                    ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                    return; // Выходим из метода
                }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox8.Text;
            if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox8.Clear();
            }
            if (text == "к")
            {
                richTextBox8.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
                //MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox7.Text;
            if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox7.Clear();
            }
            if (text == "а")
            {
                richTextBox7.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
                //MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox6.Text;
            if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox6.Clear();
            }
            if (text == "к")
            {
                richTextBox6.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
                //MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox13.Text;
            if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox13.Clear();
            }
            if (text == "к")
            {
                richTextBox13.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox12.Text;
            if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox12.Clear();
            }
            if (text == "о")
            {
                richTextBox12.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
               // MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox11.BackColor = Color.Red;

            string text = richTextBox11.Text;
            if (text != "р" && chet > 0)
            {
                Proverka();
                richTextBox11.Clear();
            }
            if (text == "р")
            {
                richTextBox11.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox9.BackColor = Color.Red;
            richTextBox62.BackColor = Color.Red;

            string text = richTextBox9.Text;
            if (text != "б" && chet > 0)
            {
                Proverka();
                richTextBox9.Clear();
            }
            if (text == "б")
            {
                richTextBox9.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox15.Text;
            if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox15.Clear();
            }
            if (text == "к")
            {
                richTextBox15.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox14.Text;
            if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox14.Clear();
            }
            if (text == "а")
            {
                richTextBox14.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox22.BackColor = Color.Red;
            richTextBox43.BackColor = Color.Red;

            string text = richTextBox22.Text;
            if (text != "ш" && chet > 0)
            {
                Proverka();
                richTextBox22.Clear();
            }
            if (text == "ш")
            {
                richTextBox22.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox21.Text;
            if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox21.Clear();
            }
            if (text == "о")
            {
                richTextBox21.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox20.Text;
            if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox20.Clear();
            }
            if (text == "к")
            {
                richTextBox20.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
               // MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox19.Text;
            if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox19.Clear();
            }
            if (text == "о")
            {
                richTextBox19.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
               // MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox18.BackColor = Color.Red;

            string text = richTextBox18.Text;
            if (text != "л")
            {
                Proverka();
                richTextBox18.Clear();
            }
            if (text == "л")
            {
                richTextBox18.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox17_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox17.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox17.Clear();
            }
            if (text == "а")
            {
                richTextBox17.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox16.BackColor = Color.Red;
            richTextBox34.BackColor = Color.Red;
            richTextBox69.BackColor = Color.Red;


            string text = richTextBox16.Text;
            if (text != "д")
            {
                Proverka();
                richTextBox16.Clear();
            }
            if (text == "д")
            {
                richTextBox16.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox25_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox25.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox25.Clear();
            }
            if (text == "н")
            {
                richTextBox25.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox24_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox17.BackColor = Color.Red;

            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox24.BackColor = Color.Red;


            string text = richTextBox24.Text;
            if (text != "ы")
            {
                Proverka();
                richTextBox24.Clear();
            }
            if (text == "ы")
            {
                richTextBox24.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox23_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox23.BackColor = Color.Red;


            string text = richTextBox23.Text;
            if (text != "х")
            {
                Proverka();
                richTextBox23.Clear();
            }
            if (text == "х")
            {
                richTextBox23.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox32_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox32.Text;
            if (text != "к")
            {
                Proverka();
                richTextBox32.Clear();
            }
            if (text == "к")
            {
                richTextBox32.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox31_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox31.Text;
            if (text != "о")
            {
                Proverka();
                richTextBox31.Clear();
            }
            if (text == "о")
            {
                richTextBox31.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox30_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox30.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox30.Clear();
            }
            if (text == "н")
            {
                richTextBox30.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox29_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox29.BackColor = Color.Red;

            string text = richTextBox29.Text;
            if (text != "ф")
            {
                Proverka();
                richTextBox29.Clear();
            }
            if (text == "ф")
            {
                richTextBox29.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox28_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;


            string text = richTextBox28.Text;
            if (text != "е")
            {
                Proverka();
                richTextBox28.Clear();
            }
            if (text == "е")
            {
                richTextBox28.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox27_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox27.BackColor = Color.Red;
            richTextBox64.BackColor = Color.Red;
            richTextBox67.BackColor = Color.Red;

            string text = richTextBox27.Text;
            if (text != "т")
            {
                Proverka();
                richTextBox27.Clear();
            }
            if (text == "т")
            {
                richTextBox27.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox39_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox39.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox39.Clear();
            }
            if (text == "н")
            {
                richTextBox39.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox38_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox57.BackColor = Color.Red;
            richTextBox38.BackColor = Color.Red;
            richTextBox2.BackColor = Color.Red;
            string text = richTextBox38.Text;
            if (text != "и")
            {
                Proverka();
                richTextBox38.Clear();
            }
            if (text == "и")
            {
                richTextBox38.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox36_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox36.Text;
            if (text != "о")
            {
                Proverka();
                richTextBox36.Clear();
            }
            if (text == "о")
            {
                richTextBox36.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
            //    MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox35_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox35.BackColor = Color.Red;


            string text = richTextBox35.Text;
            if (text != "г")
            {
                Proverka();
                richTextBox35.Clear();
            }
            if (text == "г")
            {
                richTextBox35.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox34_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox16.BackColor = Color.Red;
            richTextBox34.BackColor = Color.Red;
            richTextBox69.BackColor = Color.Red;

            string text = richTextBox34.Text;
            if (text != "д")
            {
                Proverka();
                richTextBox34.Clear();
            }
            if (text == "д")
            {
                richTextBox34.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
            //    MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox33_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox33.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox33.Clear();
            }
            if (text == "а")
            {
                richTextBox33.ReadOnly = true;

            }
            label6.Text = $"Осталось по пыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox47_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }

            richTextBox47.BackColor = Color.Red;
            richTextBox3.BackColor = Color.Red;

            string text = richTextBox47.Text;
            if (text != "з")
            {
                Proverka();
                richTextBox47.Clear();
            }
            if (text == "з")
            {
                richTextBox47.ReadOnly = true;

            }
            label6.Text = $"Осталось по пыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();

        }

        private void richTextBox46_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox46.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox46.Clear();
            }
            if (text == "н")
            {
                richTextBox46.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
            //    MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox45_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox45.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox45.Clear();
            }
            if (text == "а")
            {
                richTextBox45.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox44_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;


            string text = richTextBox44.Text;
            if (text != "е")
            {
                Proverka();
                richTextBox44.Clear();
            }
            if (text == "е")
            {
                richTextBox44.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox43_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox22.BackColor = Color.Red;
            richTextBox43.BackColor = Color.Red;

            string text = richTextBox43.Text;
            if (text != "ш")
            {
                Proverka();
                richTextBox43.Clear();
            }
            if (text == "ш")
            {
                richTextBox43.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox42_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox5.BackColor = Color.Red;
            richTextBox42.BackColor = Color.Red;

            string text = richTextBox42.Text;
            if (text != "ь")
            {
                Proverka();
                richTextBox42.Clear();
            }
            if (text == "ь")
            {
                richTextBox42.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox53_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox53.Text;
            if (text != "к")
            {
                Proverka();
                richTextBox53.Clear();
            }
            if (text == "к")
            {
                richTextBox53.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox52_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox52.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox52.Clear();
            }
            if (text == "а")
            {
                richTextBox52.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
            //    MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox51_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox51.Text;
            if (text != "к")
            {
                Proverka();
                richTextBox51.Clear();
            }
            if (text == "к")
            {
                richTextBox51.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox50_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox50.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox50.Clear();
            }
            if (text == "а")
            {
                richTextBox50.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox49_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox49.BackColor = Color.Red;
            richTextBox65.BackColor = Color.Red;


            string text = richTextBox49.Text;
            if (text != "я")
            {
                Proverka();
                richTextBox49.Clear();
            }
            if (text == "я")
            {
                richTextBox49.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox60_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;

            string text = richTextBox60.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox60.Clear();
            }
            if (text == "н")
            {
                richTextBox60.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox59_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox59.Text;
            if (text != "а")
            {
                Proverka();
                MessageBox.Show("Неправильная буква");
                richTextBox59.Clear();
            }
            if (text == "а")
            {
                richTextBox59.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
            //    MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox58_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox58.BackColor = Color.Red;


            string text = richTextBox58.Text;
            if (text != "ч")
            {
                Proverka();
                richTextBox58.Clear();
            }
            if (text == "ч")
            {
                richTextBox58.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox57_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox57.BackColor = Color.Red;
            richTextBox38.BackColor = Color.Red;
            richTextBox2.BackColor = Color.Red;
            string text = richTextBox57.Text;
            if (text != "и")
            {
                Proverka();
                richTextBox57.Clear();
            }
            if (text == "и")
            {
                richTextBox57.ReadOnly = true;

            }
            
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox56_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;

            string text = richTextBox56.Text;
            if (text != "н")
            {
                Proverka();
                richTextBox56.Clear();
            }
            if (text == "н")
            {
                richTextBox56.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox55_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;

            string text = richTextBox55.Text;
            if (text != "к")
            {
                Proverka();
                richTextBox55.Clear();
            }
            if (text == "к")
            {
                richTextBox55.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox54_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox54.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox54.Clear();
            }
            if (text == "а")
            {
                richTextBox54.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox64_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox27.BackColor = Color.Red;
            richTextBox64.BackColor = Color.Red;
            richTextBox67.BackColor = Color.Red;

            string text = richTextBox64.Text;
            if (text != "т")
            {
                Proverka();
                richTextBox64.Clear();
            }
            if (text == "т")
            {
                richTextBox64.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox63_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;

            string text = richTextBox63.Text;
            if (text != "е")
            {
                Proverka();
                richTextBox63.Clear();
            }
            if (text == "е")
            {
                richTextBox63.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox61_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;

            string text = richTextBox61.Text;
            if (text != "е")
            {
                Proverka();
                richTextBox61.Clear();
            }
            if (text == "е")
            {
                richTextBox61.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox73_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox73.BackColor = Color.Red;
            richTextBox71.BackColor = Color.Red;

            string text = richTextBox73.Text;
            if (text != "п")
            {
                Proverka();
                richTextBox73.Clear();
            }
            if (text == "п")
            {
                richTextBox73.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox72_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;

            string text = richTextBox72.Text;
            if (text != "о")
            {
                Proverka();
                richTextBox72.Clear();
            }
            if (text == "о")
            {
                richTextBox72.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox71_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox73.BackColor = Color.Red;
            richTextBox71.BackColor = Color.Red;

            string text = richTextBox71.Text;
            if (text != "п")
            {
                Proverka();
                richTextBox71.Clear();
            }
            if (text == "п")
            {
                richTextBox71.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox70_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox7.BackColor = Color.Red;
            richTextBox14.BackColor = Color.Red;
            richTextBox17.BackColor = Color.Red;
            richTextBox33.BackColor = Color.Red;
            richTextBox45.BackColor = Color.Red;
            richTextBox52.BackColor = Color.Red;
            richTextBox50.BackColor = Color.Red;
            richTextBox59.BackColor = Color.Red;
            richTextBox54.BackColor = Color.Red;
            richTextBox70.BackColor = Color.Red;

            string text = richTextBox70.Text;
            if (text != "а")
            {
                Proverka();
                richTextBox70.Clear();
            }
            if (text == "а")
            {
                richTextBox70.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox69_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox16.BackColor = Color.Red;
            richTextBox34.BackColor = Color.Red;
            richTextBox69.BackColor = Color.Red;

            string text = richTextBox69.Text;
            if (text != "д")
            {
                Proverka();
                richTextBox69.Clear();
            }
            if (text == "д")
            {
                richTextBox69.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox67_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox27.BackColor = Color.Red;
            richTextBox64.BackColor = Color.Red;
            richTextBox67.BackColor = Color.Red; 
            
            string text = richTextBox67.Text;
            if (text != "т")
            {
                Proverka();
                richTextBox67.Clear();
            }
            if (text == "т")
            {
                richTextBox67.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox66_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox66.BackColor = Color.Red;

            string text = richTextBox66.Text;
            if (text != "с" && chet > 0)
            {
                Proverka();
                richTextBox66.Clear();
            }
            if (text == "с")
            {
                richTextBox66.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox65_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox49.BackColor = Color.Red;
            richTextBox65.BackColor = Color.Red;
            
            
            string text = richTextBox65.Text;
            if (text != "я" && chet > 0)
            {
                Proverka();
                richTextBox65.Clear();
            }
            if (text == "я")
            {
                richTextBox65.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox57.BackColor = Color.Red;
            richTextBox38.BackColor = Color.Red;
            richTextBox2.BackColor = Color.Red;
        }

        private void richTextBox41_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox4.BackColor = Color.Red;
            richTextBox30.BackColor = Color.Red;
            richTextBox39.BackColor = Color.Red;
            richTextBox41.BackColor = Color.Red;
            richTextBox46.BackColor = Color.Red;
            richTextBox60.BackColor = Color.Red;
            richTextBox56.BackColor = Color.Red;
            string text = richTextBox41.Text;
            if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox41.Clear();
            }
            if (text == "н")
            {
                richTextBox41.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
             //   MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox37_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox8.BackColor = Color.Red;
            richTextBox6.BackColor = Color.Red;
            richTextBox13.BackColor = Color.Red;
            richTextBox15.BackColor = Color.Red;
            richTextBox20.BackColor = Color.Red;
            richTextBox32.BackColor = Color.Red;
            richTextBox37.BackColor = Color.Red;
            richTextBox53.BackColor = Color.Red;
            richTextBox51.BackColor = Color.Red;
            richTextBox55.BackColor = Color.Red;
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox12.BackColor = Color.Red;
            richTextBox10.BackColor = Color.Red;
            richTextBox19.BackColor = Color.Red;
            richTextBox21.BackColor = Color.Red;
            richTextBox31.BackColor = Color.Red;
            richTextBox36.BackColor = Color.Red;
            richTextBox72.BackColor = Color.Red;
        }

        private void richTextBox62_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox9.BackColor = Color.Red;
            richTextBox62.BackColor = Color.Red;
        }

        private void richTextBox40_TextChanged(object sender, EventArgs e)
        {

            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;


            string text = richTextBox40.Text;
            if (text != "е" && chet>0)
            {
                Proverka();
                richTextBox40.Clear();
            }
            if (text == "е")
            {
                richTextBox40.ReadOnly = true;

            }
            label6.Text = $"Осталось попыток {chet.ToString()}";

            if (chet <= 0)
            {
              //  MessageBox.Show("Вы исчерпали все попытки! Игра окончена.");
                ClearAllRichTextBoxes(); // Сбрасываем все RichTextBox
                return; // Выходим из метода
            }

            CheckAllRichTextBoxesFilled();
        }

        private void richTextBox68_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 73; i++)
            {
                var richTextBox = (RichTextBox)this.Controls["richTextBox" + i];
                richTextBox.BackColor = Color.White;
            }
            richTextBox28.BackColor = Color.Red;
            richTextBox40.BackColor = Color.Red;
            richTextBox44.BackColor = Color.Red;
            richTextBox61.BackColor = Color.Red;
            richTextBox68.BackColor = Color.Red;
            richTextBox63.BackColor = Color.Red;
        }
    }
}
