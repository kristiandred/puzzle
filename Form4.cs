using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        int chet = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Proverka()
        {
            if (chet == 15)
            {
                MessageBox.Show("Ты всё нашёл! Молодец!");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ананас 2.0.png";
            pictureBox3.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ананас 2.2.png";
            pictureBox4.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            Proverka();
            label1.Text = chet.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ананас 2.0.png";
            pictureBox3.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ананас 2.2.png";
            pictureBox4.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            Proverka();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\апельсин 2.0.png";
            pictureBox5.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\апельсин 2.2.png";
            pictureBox6.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            Proverka();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\апельсин 2.0.png";
            pictureBox5.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\апельсин 2.2.png";
            pictureBox6.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            Proverka();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\куст 2.0.png";
            pictureBox7.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\куст 2.2.png";
            pictureBox8.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            Proverka();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\куст 2.0.png";
            pictureBox7.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\куст 2.2.png";
            pictureBox8.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            Proverka();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\лист 2.0.png";
            pictureBox9.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\лист 2.2.png";
            pictureBox10.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            Proverka();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ляп 2.0.png";
            pictureBox11.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ляп 2.2.png";
            pictureBox12.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            Proverka();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ляп 2.0.png";
            pictureBox11.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\ляп 2.2.png";
            pictureBox12.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            Proverka();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\лист 2.0.png";
            pictureBox9.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\лист 2.2.png";
            pictureBox10.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            Proverka();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\небо 2.0.png";
            pictureBox13.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\небо 2.2.png";
            pictureBox14.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            Proverka();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\небо 2.0.png";
            pictureBox13.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\небо 2.2.png";
            pictureBox14.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            Proverka();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\рот 2.0.png";
            pictureBox15.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\рот 2.2.png";
            pictureBox16.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            Proverka();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\рот 2.0.png";
            pictureBox15.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\рот 2.2.png";
            pictureBox16.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            Proverka();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\хобот 2.0.png";
            pictureBox17.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\хобот 2.2.png";
            pictureBox18.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;
            Proverka();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\хобот 2.0.png";
            pictureBox17.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\хобот 2.2.png";
            pictureBox18.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;
            Proverka();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\цвяточек 2.0.png";
            pictureBox19.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\цвяточек 2.2.png";
            pictureBox20.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox19.Enabled = false;
            pictureBox20.Enabled = false;
            Proverka();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\цвяточек 2.0.png";
            pictureBox19.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\цвяточек 2.2.png";
            pictureBox20.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox19.Enabled = false;
            pictureBox20.Enabled = false;
            Proverka();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\яблако 2.0.png";
            pictureBox21.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\яблако 2.2.png";
            pictureBox22.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox21.Enabled = false;
            pictureBox22.Enabled = false;
            Proverka();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Desktop\отличия\яблако 2.0.png";
            pictureBox21.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Desktop\отличия\яблако 2.2.png";
            pictureBox22.Image = Image.FromFile(imagePath2);
            chet++;
            pictureBox21.Enabled = false;
            pictureBox22.Enabled = false;
            Proverka();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\гора 2.0.png";
            pictureBox23.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\гора 2.2.png";
            pictureBox24.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox23.Enabled = false;
            pictureBox24.Enabled = false;
            Proverka();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\гора 2.0.png";
            pictureBox23.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\гора 2.2.png";
            pictureBox24.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox23.Enabled = false;
            pictureBox24.Enabled = false;
            Proverka();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\кустарник 2.0.png";
            pictureBox25.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\кустарник 2.2.png";
            pictureBox26.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox25.Enabled = false;
            pictureBox26.Enabled = false;
            Proverka();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\кустарник 2.0.png";
            pictureBox25.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\кустарник 2.2.png";
            pictureBox26.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox25.Enabled = false;
            pictureBox26.Enabled = false;
            Proverka();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\листоголовые 2.0.png";
            pictureBox27.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\листоголовые 2.2.png";
            pictureBox28.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox27.Enabled = false;
            pictureBox28.Enabled = false;
            Proverka();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\листоголовые 2.0.png";
            pictureBox27.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\листоголовые 2.2.png";
            pictureBox28.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox27.Enabled = false;
            pictureBox28.Enabled = false;
            Proverka();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\столб 2.0.png";
            pictureBox29.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\столб 2.2.png";
            pictureBox30.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox29.Enabled = false;
            pictureBox30.Enabled = false;
            Proverka();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\столб 2.0.png";
            pictureBox29.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\столб 2.2.png";
            pictureBox30.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox29.Enabled = false;
            pictureBox30.Enabled = false;
            Proverka();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\травка 2.0.png";
            pictureBox31.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\травка 2.2.png";
            pictureBox32.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox31.Enabled = false;
            pictureBox32.Enabled = false;
            Proverka();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\травка 2.0.png";
            pictureBox31.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\травка 2.2.png";
            pictureBox32.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox31.Enabled = false;
            pictureBox32.Enabled = false;
            Proverka();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\хвост 2.0.png";
            pictureBox33.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\хвост 2.2.png";
            pictureBox34.Image = Image.FromFile(imagePath2);
            chet++;
            pictureBox33.Enabled = false;
            pictureBox34.Enabled = false;
            Proverka();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            string imagePath = @"D:\Мои документы\Рабочий стол\Новая папка\хвост 2.0.png";
            pictureBox33.Image = Image.FromFile(imagePath);
            string imagePath2 = @"D:\Мои документы\Рабочий стол\Новая папка\хвост 2.2.png";
            pictureBox34.Image = Image.FromFile(imagePath2); ;
            chet++;
            pictureBox33.Enabled = false;
            pictureBox34.Enabled = false;
            Proverka();
        }
    }
}
