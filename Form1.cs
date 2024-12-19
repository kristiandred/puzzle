using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {


        private string connectionString = "Server=USER-PC;Database=DataBase;Trusted_Connection=True;";

        private string last = "0";

        public Form1()
        {
            this.MaximizeBox = false; // ���������� ������ ������������
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
                    MessageBox.Show("������ ������ ��������� �� ����� 8 ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string k2 = textBox3.Text;
                if (k != k2)
                {
                    MessageBox.Show("������ �� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (k == k2 && x >= 8)
                {
                    string username = textBox4.Text;
                    string password = textBox2.Text;
                    string email = textBox1.Text;
                    string plus = "no";

                    // �������� �� ������������ email
                    if (!IsValidEmail(email))
                    {
                        MessageBox.Show("����������, ������� ���������� ����� ����������� �����.");
                        return; // ���������� ����������, ���� email �����������
                    }

                    if (password.Length < 8)
                    {
                        MessageBox.Show("����������, ������� � ���� ��� ������ �� ������ 8 ��������.");
                        return; // ���������� ����������, ���� email �����������
                    }

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // �������� �� ������������ ����� ������������
                        string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @Username";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Username", username);
                            int userExists = (int)checkCommand.ExecuteScalar();

                            if (userExists > 0)
                            {
                                MessageBox.Show("��� ������������ ��� ����������. ����������, �������� ������ ���.");
                                return; // ���������� ����������, ���� ��� ������������ �� ���������
                            }
                        }

                        // ������ ��� ������� ����� ������
                        string insertQuery = "INSERT INTO users (username, password, email, blocked) VALUES (@Username, @Password, @Email, @Blocked)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            // ���������� ���������� ��� �������������� SQL-��������
                            insertCommand.Parameters.AddWithValue("@Username", username);
                            insertCommand.Parameters.AddWithValue("@Password", password);
                            insertCommand.Parameters.AddWithValue("@Email", email);
                            insertCommand.Parameters.AddWithValue("@Blocked", plus);

                            // ���������� ������� �������
                            insertCommand.ExecuteNonQuery();
                        }

                        // ������ ��� ������� ���� ������������� (���� ����������)
                        string selectQuery = "SELECT * FROM users";
                        SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        // ����� ����� ���������� ������, ���� �����
                        reader.Close();
                    }


                    Form2 form = new Form2();
                    form.txt = $"{username}";
                    form.Show();
                    this.Hide();
                }
            }







            //���� 
            if (last == "label2")
            {
                string username = textBox5.Text;
                string password = textBox6.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // ������ ��� �������� ������������� ������������ � ��� �������
                    string query = "SELECT blocked FROM users WHERE username = @Username AND password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // ���������� ���������� ��� �������������� SQL-��������
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // ���������� ������� � ��������� ����������
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            string blockedStatus = result.ToString();

                            if (blockedStatus == "no")
                            {
                                // ������������ ������ � �� ������������, ���� �������
                                MessageBox.Show("���� �������� �������!");
                                SendMessage();
                                // ����� ����� �������� ��� ��� �������� �� ������ ����� ��� ���������� ������ ��������
                                Form2 form = new Form2();
                                form.txt = $"{username}";
                                form.Show();
                                this.Hide();
                            }
                            else if (blockedStatus == "yes")
                            {
                                // ������������ ������, �� ������������
                                MessageBox.Show("��� ������� ������������. ����������, ���������� � ��������������.");
                            }
                        }
                        else
                        {
                            // ������������ �� ������, ���� �� ������
                            MessageBox.Show("�������� ��� ������������ ��� ������.");
                        }
                    } 
                    
                }
               
            }



        }

        private void SendMessage()
        {
            // ��������� SMTP-������� Mail.ru
            string smtpServer = "smtp.gmail.ru"; //smpt ������(������� �� ����� �����������)
            int smtpPort = 587; // ������ ������������ ���� 587 ��� TLS
            string smtpUsername = "kristiandref@gmail.ru"; //���� �����, � ������� ������������ ���������
            string smtpPassword = "k02102006";//������ ���������� (�� �����)

            // ������� ������ ������� SMTP
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                // ��������� ��������������
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add("kotikulia8@gmail.com"); // ������� ����� ����������
                    mailMessage.Subject = "��������� ��������� (����)";
                    mailMessage.Body = $"����� ���������";

                    try
                    {
                        // ���������� ���������
                        smtpClient.Send(mailMessage);
                        MessageBox.Show("��������� ������� ����������.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������ �������� ���������: {ex.Message}");
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
            {
                // ���������� ��������� ��� �������� email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern);
            }





        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            Form2 form = new Form2();
            form.txt = $"player {randomNumber}"; // ���������, ��� �������� txt ���������� � Form2
            form.Show(); // ���������� Form2
            this.Hide(); // �������� ������� ����� ������ ��������
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
            button2.Text = "�����";
            label5.Text = "��� ������������";
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


        //�����
        private void button4_Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            string password = textBox6.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // ������ ��� �������� ������������� ������������
                string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // ���������� ���������� ��� �������������� SQL-��������
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // ���������� ������� � ��������� ����������
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // ������������ ������, ���� �������
                        MessageBox.Show("���� �������� �������!");
                        // ����� ����� �������� ��� ��� �������� �� ������ ����� ��� ���������� ������ ��������
                        Form10 form = new Form10();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        // ������������ �� ������, ���� �� ������
                        MessageBox.Show("�������� email ��� ������.");
                    }
                }
            }

        }

    }
}