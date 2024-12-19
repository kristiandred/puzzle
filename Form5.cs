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
    public partial class Form5 : Form
    {
        public string ka { get; set; }


        public Form5()
        {
            this.MaximizeBox = false;
            InitializeComponent();
            int[] mas = new int[7];
            HashSet<int> uniqueNumbers = new HashSet<int>();
            Random random = new Random();

            while (uniqueNumbers.Count < 7)
            {
                int number = random.Next(0, 100);
                uniqueNumbers.Add(number); // HashSet автоматически игнорирует дубликаты
            }

            // Переносим уникальные числа в массив
            uniqueNumbers.CopyTo(mas);

            // Выводим числа в textBox1
            textBox1.Text = string.Join(" ", mas);
            listBox1.Visible = false;
            pictureBox7.Visible = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (ka == "Color [A=255, R=255, G=255, B=192]")
            {
                label1.ForeColor = Color.Black;
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\барашкис(132, 140).png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\зверополис\белка в наушниках(216, 357).png";
                pictureBox2.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\проверить.png";
                pictureBox3.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\назад.png";
                pictureBox4.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\выйти.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath6);
                string imagePath7 = @"D:\Мои документы\Рабочий стол\кнопки\инструкция.png";
                pictureBox7.Image = Image.FromFile(imagePath7);

            }
            else if (ka == "Color [Black]")
            {
                label1.ForeColor = Color.FromArgb(255, 255, 255, 192);
                string imagePath = @"D:\Мои документы\Рабочий стол\зверополис\чёрный барашкис.png";
                pictureBox1.Image = Image.FromFile(imagePath);
                string imagePath2 = @"D:\Мои документы\Рабочий стол\зверополис\черная белка в наушниках.png";
                pictureBox2.Image = Image.FromFile(imagePath2);
                string imagePath3 = @"D:\Мои документы\Рабочий стол\кнопки\черное проверить.png";
                pictureBox3.Image = Image.FromFile(imagePath3);
                string imagePath4 = @"D:\Мои документы\Рабочий стол\кнопки\черная назад.png";
                pictureBox4.Image = Image.FromFile(imagePath4);
                string imagePath5 = @"D:\Мои документы\Рабочий стол\кнопки\черный выход.png";
                pictureBox5.Image = Image.FromFile(imagePath5);
                string imagePath54 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox6.Image = Image.FromFile(imagePath54);
                string imagePath6 = @"D:\Мои документы\Рабочий стол\кнопки\черная инструкция.png";
                pictureBox7.Image = Image.FromFile(imagePath6);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int[] mas = new int[7];
            string input = textBox2.Text;
            string[] numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length != 7)
            {
                MessageBox.Show("Вы ввели больше/меньше чисел, чем нужно.", "Неправильное количество чисел", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Выходим из метода, если количество чисел неверное
            }

            bool isIncreasing = true; // Флаг для проверки возрастания

            for (int i = 0; i < 7; i++)
            {
                mas[i] = int.Parse(numbers[i]);

                // Проверяем, если текущее число меньше или равно предыдущему
                if (i > 0 && mas[i] <= mas[i - 1])
                {
                    isIncreasing = false; // Если не в порядке возрастания, устанавливаем флаг в false
                    break; // Выходим из цикла, если последовательность нарушена
                }
            }

            if (isIncreasing)
            {
                MessageBox.Show("Ты молодец! :)", "Результат:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form2 form2 = new Form2();
                form2.std = ka;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Числа расставлены не в той последовательности, подумай ещё -_-", "Результат:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            string k = this.BackColor.ToString(); // Получаем значение цвета
            form2.std = k; // Передаем значение
            form2.BackColor = this.BackColor; // Устанавливаем цвет фона
            form2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            listBox1.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            listBox1.Visible = false;
        }
    }
}
