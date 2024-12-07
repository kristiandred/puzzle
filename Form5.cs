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
        public Form5()
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Числа расставлены не в той последовательности, подумай ещё -_-", "Результат:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
