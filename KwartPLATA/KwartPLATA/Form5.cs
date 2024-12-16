using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KwartPLATA
{
    public partial class Form5 : Form
    {
        private OleDbConnection connection;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";
        private string currentTable;
        public Form5()
        {

            InitializeComponent();
            LoadTables();
            LoadData();

        }
        private void LoadTables()
        {
            comboBox1.Items.Add("Users");
            comboBox1.Items.Add("Tarif1");
            comboBox1.Items.Add("Tarif2");
            comboBox1.SelectedIndex = 0; // Выбираем первую таблицу по умолчанию
            LoadData();
        }
        private void LoadData()
        {
            currentTable = comboBox1.SelectedItem.ToString();
            using (connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {currentTable}", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsers.DataSource = dataTable;
                connection.Close();
            }
        }
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUsers.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridViewUsers.CurrentRow;
                    string tableName = comboBox1.SelectedItem.ToString();
                    string columnName = dataGridViewUsers.Columns[dataGridViewUsers.CurrentCell.ColumnIndex].Name;
                    string newValue = textBox1.Text;

                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();
                        string query = $"UPDATE [{tableName}] SET [{columnName}] = @newValue";
                        using (OleDbCommand cmd = new OleDbCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@newValue", newValue);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Обновление GridView после сохранения
                    LoadData();
                    textBox1.Clear(); // Очистить текстовое поле
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedRowIndex = dataGridViewUsers.SelectedRows[0].Index;
                    int id = (int)dataGridViewUsers.Rows[selectedRowIndex].Cells["UserID"].Value; // Предполагается, что у вас есть колонка ID

                    using (connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();
                        string query = $"DELETE FROM {currentTable} WHERE UserID = @UserID";
                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", id);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }
        private void btnAddEmptyRow_Click(object sender, EventArgs e)
        {
            // Строка подключения к базе данных Access
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";

            // Получаем имя выбранной таблицы из комбобокса
            string selectedTable = comboBox1.SelectedItem.ToString();

            // Условие для определения полей в зависимости от выбранной таблицы
            string query;
            try
            {
                // Создание соединения с базой данных
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    switch (selectedTable)
                    {
                        case "Users":
                            // Вставка пустой строки для таблицы Payments
                            query = "INSERT INTO Users ([FIO],[Pasport],[S],[Birthdat],[Domofone],[Kolvo],[Password]) VALUES ('', '', '','','','','')";
                            break;

                        case "Tarif1":
                            // Вставка пустой строки для еще одной таблицы, например, AnotherTable
                            query = "INSERT INTO Tarif1 (GorVoda, HolVoda, Svet, Gaz, Domofon, Musor, CapRem, Otoplenie) VALUES ('', '', '','','','','','')";
                            break;

                        case "Tarif2":
                            // Вставка пустой строки для таблицы Payments
                            query = "INSERT INTO Tarif1 (GorVoda, HolVoda, Svet, Gaz, Domofon, Musor, CapRem, Otoplenie) VALUES ('', '', '','','','','','')";
                            break;

                        // Добавьте дополнительные случаи для других таблиц по мере необходимости

                        default:
                            MessageBox.Show("Выберите допустимую таблицу.");
                            return;
                    }

                            using (OleDbCommand command = new OleDbCommand(query, connection))
                            {
                                // Выполнение команды
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Запись успешно добавлена.");

                            // Вы можете дополнительно обновить DataGridView или другой элемент управления, чтобы отобразить изменения
                            LoadData();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

