using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Access.Dao;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {


        private string connectionString = "Server=USER-PC;Database=DataBase;Trusted_Connection=True;";

        public Form10()
        {
            InitializeComponent();
            DataGrid();

        }


        private void DataGrid()
        {
            string selectQuery = "SELECT username, email, password, blocked FROM users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable; // Вывод данных в DataGridView
                        reader.Close();
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей
            string username = textBox1.Text;
            string password = textBox3.Text;
            string email = textBox2.Text;
            string plus = "no";

            // Проверка на корректность email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Пожалуйста, введите корректный адрес электронной почты.");
                return; // Прекращаем выполнение, если email некорректен
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Пожалуйста, введите в поле для пароля не меньше 8 символов.");
                return; // Прекращаем выполнение, если email некорректен
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка на уникальность имени пользователя
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @Username";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Username", username);
                    int userExists = (int)checkCommand.ExecuteScalar();

                    if (userExists > 0)
                    {
                        MessageBox.Show("Имя пользователя уже существует. Пожалуйста, выберите другое имя.");
                        return; // Прекращаем выполнение, если имя пользователя не уникально
                    }
                }

                // Запрос для вставки новой записи
                string insertQuery = "INSERT INTO users (username, password, email, blocked) VALUES (@Username, @Password, @Email, @Blocked)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    // Добавление параметров для предотвращения SQL-инъекций
                    insertCommand.Parameters.AddWithValue("@Username", username);
                    insertCommand.Parameters.AddWithValue("@Password", password);
                    insertCommand.Parameters.AddWithValue("@Email", email);
                    insertCommand.Parameters.AddWithValue("@Blocked", plus);

                    // Выполнение команды вставки
                    insertCommand.ExecuteNonQuery();
                }

                // Запрос для выборки всех пользователей (если необходимо)
                string selectQuery = "SELECT * FROM users";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = selectCommand.ExecuteReader();

                // Здесь можно обработать данные, если нужно
                reader.Close();
            }
            DataGrid();
        }

        private bool IsValidEmail(string email)
        {
            // Регулярное выражение для проверки email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usernameToDelete = textBox4.Text; // Предполагается, что имя пользователя для удаления вводится в textBox1

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Запрос для удаления пользователя
                string deleteQuery = "DELETE FROM users WHERE username = @Username";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    // Добавление параметра для предотвращения SQL-инъекций
                    deleteCommand.Parameters.AddWithValue("@Username", usernameToDelete);

                    // Выполнение команды удаления
                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пользователь успешно удален.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
            }
            DataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Запрос для проверки существования пользователя
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавление параметров для предотвращения SQL-инъекций
                    command.Parameters.AddWithValue("@Username", username);

                    // Выполнение команды и получение результата
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Пользователь найден, изменяем значение в столбце blocked
                        string updateQuery = "UPDATE users SET blocked = @Blocked WHERE username = @Username";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            // Устанавливаем новое значение для blocked
                            string newBlockedValue = "yes"; // или любое другое значение, которое вам нужно
                            updateCommand.Parameters.AddWithValue("@Blocked", newBlockedValue);
                            updateCommand.Parameters.AddWithValue("@Username", username);

                            // Выполнение команды обновления
                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Пользователь заблокирован.");
                    }
                    else
                    {
                        // Пользователь не найден, вход не удался
                        MessageBox.Show("Пользователя не существует.");
                    }
                }
            }
            DataGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Запрос для проверки существования пользователя
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавление параметров для предотвращения SQL-инъекций
                    command.Parameters.AddWithValue("@Username", username);

                    // Выполнение команды и получение результата
                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Пользователь найден, изменяем значение в столбце blocked
                        string updateQuery = "UPDATE users SET blocked = @Blocked WHERE username = @Username";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            // Устанавливаем новое значение для blocked
                            string newBlockedValue = "no"; // или любое другое значение, которое вам нужно
                            updateCommand.Parameters.AddWithValue("@Blocked", newBlockedValue);
                            updateCommand.Parameters.AddWithValue("@Username", username);

                            // Выполнение команды обновления
                            updateCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Пользователь разблокирован.");
                    }
                    else
                    {
                        // Пользователь не найден, вход не удался
                        MessageBox.Show("Пользователя не существует.");
                    }
                }
            }
            DataGrid();
        }
    }
}
