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

        public string ka { get; set; }
        public Form3()
        {
            InitializeComponent();
            label6.Text = $"Осталось попыток: {chet.ToString()}";
            this.MaximizeBox = false;
            listBox1.Visible = false;
            pictureBox6.Visible = false;
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
                this.Close();
                Form2 form2 = new Form2();
                string k = this.BackColor.ToString(); // Получаем значение цвета
                form2.std = k; // Передаем значение
                form2.BackColor = this.BackColor; // Устанавливаем цвет фона
                form2.Show();
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
            

            if (text == "ж")
            {
                richTextBox1.ReadOnly = true;

            }
            else if (text != "ж" && chet > 0)
            {
                Proverka();
                richTextBox1.Clear();
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
            
            if (text == "з")
            {
                richTextBox3.ReadOnly = true;

            } else if (text != "з" && chet > 0)
            {
                Proverka();
                richTextBox3.Clear();
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
            
            if (text == "н")
            {
                richTextBox4.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox4.Clear();
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
           
            if (text == "ь")
            {
                richTextBox5.ReadOnly = true;

            }else if (text != "ь" && chet > 0)
            {
                Proverka();
                richTextBox5.Clear();
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
           
            if (text == "к")
            {
                richTextBox8.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox8.Clear();
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
            
            if (text == "а")
            {
                richTextBox7.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox7.Clear();
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
            
            if (text == "к")
            {
                richTextBox6.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox6.Clear();
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
            
            if (text == "к")
            {
                richTextBox13.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox13.Clear();
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
            
            if (text == "о")
            {
                richTextBox12.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox12.Clear();
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
            
            if (text == "р")
            {
                richTextBox11.ReadOnly = true;

            }else if (text != "р" && chet > 0)
            {
                Proverka();
                richTextBox11.Clear();
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
            
            if (text == "б")
            {
                richTextBox9.ReadOnly = true;

            }else if (text != "б" && chet > 0)
            {
                Proverka();
                richTextBox9.Clear();
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
            
            if (text == "к")
            {
                richTextBox15.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox15.Clear();
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
            
            if (text == "а")
            {
                richTextBox14.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox14.Clear();
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
            
            if (text == "ш")
            {
                richTextBox22.ReadOnly = true;

            }else if (text != "ш" && chet > 0)
            {
                Proverka();
                richTextBox22.Clear();
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
            
            if (text == "о")
            {
                richTextBox21.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox21.Clear();
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
           
            if (text == "к")
            {
                richTextBox20.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox20.Clear();
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
            
            if (text == "о")
            {
                richTextBox19.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox19.Clear();
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
            
            if (text == "л")
            {
                richTextBox18.ReadOnly = true;

            }else if (text != "л" && chet > 0)
            {
                Proverka();
                richTextBox18.Clear();
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
            
            if (text == "а")
            {
                richTextBox17.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox17.Clear();
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
            
            if (text == "д")
            {
                richTextBox16.ReadOnly = true;

            }else if (text != "д" && chet > 0)
            {
                Proverka();
                richTextBox16.Clear();
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
            
            if (text == "н")
            {
                richTextBox25.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox25.Clear();
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
           
            if (text == "ы")
            {
                richTextBox24.ReadOnly = true;

            }else if (text != "ы" && chet > 0)
            {
                Proverka();
                richTextBox24.Clear();
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
            
            if (text == "х")
            {
                richTextBox23.ReadOnly = true;

            }else if (text != "х" && chet > 0)
            {
                Proverka();
                richTextBox23.Clear();
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
           
            if (text == "к")
            {
                richTextBox32.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox32.Clear();
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
            
            if (text == "о")
            {
                richTextBox31.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox31.Clear();
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
            
            if (text == "н")
            {
                richTextBox30.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox30.Clear();
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
            
            if (text == "ф")
            {
                richTextBox29.ReadOnly = true;

            }else if (text != "ф" && chet > 0)
            {
                Proverka();
                richTextBox29.Clear();
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
           
            if (text == "е")
            {
                richTextBox28.ReadOnly = true;

            }else if (text != "е" && chet > 0)
            {
                Proverka();
                richTextBox28.Clear();
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
            
            if (text == "т")
            {
                richTextBox27.ReadOnly = true;

            }else if (text != "т" && chet > 0)
            {
                Proverka();
                richTextBox27.Clear();
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
            
            if (text == "н")
            {
                richTextBox39.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox39.Clear();
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
            
            if (text == "и")
            {
                richTextBox38.ReadOnly = true;

            }else if (text != "и" && chet > 0)
            {
                Proverka();
                richTextBox38.Clear();
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
            
            if (text == "о")
            {
                richTextBox36.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox36.Clear();
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
            
            if (text == "г")
            {
                richTextBox35.ReadOnly = true;

            }else if (text != "г" && chet > 0)
            {
                Proverka();
                richTextBox35.Clear();
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
            
            if (text == "д")
            {
                richTextBox34.ReadOnly = true;

            }else if (text != "д" && chet > 0)
            {
                Proverka();
                richTextBox34.Clear();
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
            
            if (text == "а")
            {
                richTextBox33.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox33.Clear();
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
            
            if (text == "з")
            {
                richTextBox47.ReadOnly = true;

            }else if (text != "з" && chet > 0)
            {
                Proverka();
                richTextBox47.Clear();
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
            
            if (text == "н")
            {
                richTextBox46.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox46.Clear();
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
            
            if (text == "а")
            {
                richTextBox45.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox45.Clear();
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
            
            if (text == "е")
            {
                richTextBox44.ReadOnly = true;

            }else if (text != "е" && chet > 0)
            {
                Proverka();
                richTextBox44.Clear();
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
            
            if (text == "ш")
            {
                richTextBox43.ReadOnly = true;

            }else if (text != "ш" && chet > 0)
            {
                Proverka();
                richTextBox43.Clear();
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
            
            if (text == "ь")
            {
                richTextBox42.ReadOnly = true;

            }else if (text != "ь" && chet > 0)
            {
                Proverka();
                richTextBox42.Clear();
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
           
            if (text == "к")
            {
                richTextBox53.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox53.Clear();
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
           
            if (text == "а")
            {
                richTextBox52.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox52.Clear();
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
           
            if (text == "к")
            {
                richTextBox51.ReadOnly = true;

            }else if (text != "к")
            {
                Proverka();
                richTextBox51.Clear();
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
            
            if (text == "а")
            {
                richTextBox50.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox50.Clear();
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
           
            if (text == "я")
            {
                richTextBox49.ReadOnly = true;

            }else if (text != "я" && chet > 0)
            {
                Proverka();
                richTextBox49.Clear();
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
           
            if (text == "н")
            {
                richTextBox60.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox60.Clear();
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
           
            if (text == "а")
            {
                richTextBox59.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                MessageBox.Show("Неправильная буква");
                richTextBox59.Clear();
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
           
            if (text == "ч")
            {
                richTextBox58.ReadOnly = true;

            }else if (text != "ч" && chet > 0)
            {
                Proverka();
                richTextBox58.Clear();
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
            
            if (text == "и")
            {
                richTextBox57.ReadOnly = true;

            }else if (text != "и" && chet > 0)
            {
                Proverka();
                richTextBox57.Clear();
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
            
            if (text == "н")
            {
                richTextBox56.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox56.Clear();
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
           
            if (text == "к")
            {
                richTextBox55.ReadOnly = true;

            }else if (text != "к" && chet > 0)
            {
                Proverka();
                richTextBox55.Clear();
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
           
            if (text == "а")
            {
                richTextBox54.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox54.Clear();
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
           
            if (text == "т")
            {
                richTextBox64.ReadOnly = true;

            }else if (text != "т" && chet > 0)
            {
                Proverka();
                richTextBox64.Clear();
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
           
            if (text == "е")
            {
                richTextBox63.ReadOnly = true;

            }else if (text != "е" && chet > 0)
            {
                Proverka();
                richTextBox63.Clear();
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
           
            if (text == "е")
            {
                richTextBox61.ReadOnly = true;

            }else if (text != "е" && chet > 0)
            {
                Proverka();
                richTextBox61.Clear();
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
           
            if (text == "п")
            {
                richTextBox73.ReadOnly = true;

            }else if (text != "п" && chet > 0)
            {
                Proverka();
                richTextBox73.Clear();
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
           
            if (text == "о")
            {
                richTextBox72.ReadOnly = true;

            }else if (text != "о" && chet > 0)
            {
                Proverka();
                richTextBox72.Clear();
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
           
            if (text == "п")
            {
                richTextBox71.ReadOnly = true;

            }else if (text != "п" && chet > 0)
            {
                Proverka();
                richTextBox71.Clear();
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
            
            if (text == "а")
            {
                richTextBox70.ReadOnly = true;

            }else if (text != "а" && chet > 0)
            {
                Proverka();
                richTextBox70.Clear();
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
           
            if (text == "д")
            {
                richTextBox69.ReadOnly = true;

            }else if (text != "д" && chet > 0)
            {
                Proverka();
                richTextBox69.Clear();
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
           
            if (text == "т")
            {
                richTextBox67.ReadOnly = true;

            }else if (text != "т" && chet > 0)
            {
                Proverka();
                richTextBox67.Clear();
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
           
            if (text == "с")
            {
                richTextBox66.ReadOnly = true;

            }else if (text != "с" && chet > 0)
            {
                Proverka();
                richTextBox66.Clear();
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
           
            if (text == "я")
            {
                richTextBox65.ReadOnly = true;

            }else if (text != "я" && chet > 0)
            {
                Proverka();
                richTextBox65.Clear();
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
           
            if (text == "н")
            {
                richTextBox41.ReadOnly = true;

            }else if (text != "н" && chet > 0)
            {
                Proverka();
                richTextBox41.Clear();
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
           
            if (text == "е")
            {
                richTextBox40.ReadOnly = true;

            }else if (text != "е" && chet > 0)
            {
                Proverka();
                richTextBox40.Clear();
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



        private void Form3_Load(object sender, EventArgs e)
        {

            // Устанавливаем цвет текста в зависимости от значения ka
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\джуди заяц(136, 275).png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\зверополис\лис(125, 260).png";
                pictureBox2.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\назад.png";
                pictureBox3.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox4.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath6);
            }
            else if (ka == "Color [Black]")
            {
                label1.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label2.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label3.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label4.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label5.ForeColor = Color.FromArgb(255, 255, 255, 192);
                label6.ForeColor = Color.FromArgb(255, 255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\черный джуди заяц.png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\зверополис\черный лис.png";
                pictureBox2.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\черная назад.png";
                pictureBox3.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox4.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath6);
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox1.Text.Length >= 1)
            {
                e.Handled = true;
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

        private void richTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox8.Text.Length >= 1)
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

        private void richTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox6.Text.Length >= 1)
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

        private void richTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox9.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox15.Text.Length >= 1)
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

        private void richTextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox21.Text.Length >= 1)
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

        private void richTextBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox19.Text.Length >= 1)
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

        private void richTextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox16.Text.Length >= 1)
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

        private void richTextBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox24.Text.Length >= 1)
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

        private void richTextBox32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox32.Text.Length >= 1)
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

        private void richTextBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox27.Text.Length >= 1)
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

        private void richTextBox38_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox38.Text.Length >= 1)
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

        private void richTextBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox35.Text.Length >= 1)
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

        private void richTextBox33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox33.Text.Length >= 1)
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

        private void richTextBox40_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox40.Text.Length >= 1)
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

        private void richTextBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox45.Text.Length >= 1)
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

        private void richTextBox53_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox53.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox52.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox51_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox51.Text.Length >= 1)
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

        private void richTextBox60_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox60.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox59_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox59.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox58.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox57.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox56_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox56.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox55.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox54.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox64_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox64.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox63_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox63.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox61_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox61.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox73_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox73.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox72_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox72.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox71_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox71.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox70_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox70.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox69_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox69.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox67_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox67.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox66_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox66.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
            }
        }

        private void richTextBox65_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (richTextBox65.Text.Length >= 1)
            {
                e.Handled = true; // Отменяем ввод, если уже есть символ
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
            listBox1.Visible = true;
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            listBox1.Visible = false;
        }
    }
}
