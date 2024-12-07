using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Access.Dao;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string last = "0";

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            this.Resize += new System.EventHandler(this.Form1_Resize); // Подписка на событие изменения размера формы
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            last = "label1";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            button2.Visible = true;





        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (last == "label1")
            {
                string k = textBox2.Text;
                int x = 0;
                for (int i = 0; i < k.Length; i++)
                {
                    x++;
                }
                if (x < 8)
                {
                    MessageBox.Show("Пароль должен содержать не менее 8 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string k2 = textBox3.Text;
                if (k != k2)
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (k == k2 && x >= 8)
                {
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
            }
            if (last == "label2")
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            string username = textBox4.Text;
            string password = textBox6.Text;
            string email = textBox5.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            last = "label2";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Visible = true;
            button2.Text = "Войти";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            label5.Visible = true;
            label5.Text = "e-mail";
            label6.Visible = true;
            textBox6.Visible = true;
            button4.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox6.Text;


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Width += 50; // Устанавливаем ширину кнопки в половину ширины формы
            button1.Height += 20;
            button1.Location = new System.Drawing.Point((this.ClientSize.Width - button1.Width) / 2, (this.ClientSize.Height - button1.Height) / 2); // Центрируем кнопку по горизонтали и вертикали

            int labelWidth = this.ClientSize.Width / 2;
            int startY = (this.ClientSize.Height - (label1.Height + label2.Height + label3.Height + label4.Height)) / 2;

            // Устанавливаем положение каждой метки
            // Задаем расстояние между метками
            int spacing = 20; // Увеличьте это значение для большего расстояния

            // Устанавливаем положение каждой метки с учетом отступа
            label1.Location = new System.Drawing.Point((this.ClientSize.Width - label1.Width) / 2, startY);
            label2.Location = new System.Drawing.Point((this.ClientSize.Width - label2.Width) / 2, startY + label1.Height + spacing);
            label3.Location = new System.Drawing.Point((this.ClientSize.Width - label3.Width) / 2, startY + label1.Height + label2.Height + 2 * spacing);
            label4.Location = new System.Drawing.Point((this.ClientSize.Width - label4.Width) / 2, startY + label1.Height + label2.Height + label3.Height + 3 * spacing);
            label1.Font = new System.Drawing.Font(label1.Font.FontFamily, 20);
            label2.Font = new System.Drawing.Font(label1.Font.FontFamily, 20);
            label3.Font = new System.Drawing.Font(label1.Font.FontFamily, 20);
            label4.Font = new System.Drawing.Font(label1.Font.FontFamily, 20);
            button1.Font = new System.Drawing.Font(label1.Font.FontFamily, 20);
            button3.Location = new System.Drawing.Point(this.ClientSize.Width - button3.Width - 10, 10); // 10 - отступ от верхнего и правого края

           




            // Задаем отступ между компонентами
            int spacing2 = 10;

            // Начальная позиция по вертикали
            int startY2 = (this.ClientSize.Height - (8 * spacing2 + label5.Height + textBox5.Height + label6.Height + textBox6.Height + label8.Height + textBox3.Height + label7.Height + textBox4.Height)) / 2;

            // Устанавливаем положение каждого компонента
            label5.Location = new System.Drawing.Point((this.ClientSize.Width - label5.Width) / 2, startY2);
            textBox1.Location = new System.Drawing.Point((this.ClientSize.Width - textBox1.Width) / 2, startY2 + label5.Height + spacing2);
            textBox5.Location = new System.Drawing.Point((this.ClientSize.Width - textBox5.Width) / 2, startY2 + label5.Height + spacing2);

            label6.Location = new System.Drawing.Point((this.ClientSize.Width - label6.Width) / 2, startY2 + label5.Height + textBox5.Height + 2 * spacing2);
            textBox2.Location = new System.Drawing.Point((this.ClientSize.Width - textBox2.Width) / 2, startY2 + label5.Height + textBox2.Height + label6.Height + 3 * spacing2);
            textBox6.Location = new System.Drawing.Point((this.ClientSize.Width - textBox6.Width) / 2, startY2 + label5.Height + textBox5.Height + label6.Height + 3 * spacing2);

            label8.Location = new System.Drawing.Point((this.ClientSize.Width - label8.Width) / 2, startY2 + label5.Height + textBox5.Height + label6.Height + textBox6.Height + 4 * spacing2);
            textBox3.Location = new System.Drawing.Point((this.ClientSize.Width - textBox3.Width) / 2, startY2 + label5.Height + textBox5.Height + label6.Height + textBox6.Height + label8.Height + 5 * spacing2);

            label7.Location = new System.Drawing.Point((this.ClientSize.Width - label7.Width) / 2, startY2 + label5.Height + textBox5.Height + label6.Height + textBox6.Height + label8.Height + textBox3.Height + 6 * spacing2);
            textBox4.Location = new System.Drawing.Point((this.ClientSize.Width - textBox4.Width) / 2, startY2 + label5.Height + textBox5.Height + label6.Height + textBox6.Height + label8.Height + textBox3.Height + label7.Height + 7 * spacing2);

            label5.Font = new System.Drawing.Font(label1.Font.FontFamily, 16);
            label6.Font = new System.Drawing.Font(label1.Font.FontFamily, 16);
            label8.Font = new System.Drawing.Font(label1.Font.FontFamily, 16);
            label7.Font = new System.Drawing.Font(label1.Font.FontFamily, 16);
            
            textBox1.Width += 70;
            textBox1.Height += 10;
            textBox1.Font = new System.Drawing.Font(textBox1.Font.FontFamily, 16);







        }
    }
}