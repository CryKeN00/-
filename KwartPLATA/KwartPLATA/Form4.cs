using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KwartPLATA
{
    public partial class Form4 : Form
    {
        private int UserID;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";
        private int residentsCount;
        public Form4(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            LoadUserData();
        }


        private void LoadUserData()
        {
            // Загрузка данных пользователя для отображения, включая количество жителей
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT FIO, Kolvo FROM Users WHERE UserID = @UserID", connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox9.Text = reader["FIO"].ToString();
                        // Вы можете сохранить количество жителей, если это нужно
                        int residentsCount = Convert.ToInt32(reader["Kolvo"]);
                        LoadTariffs(residentsCount);
                    }
                    reader.Close();
                }
            }
        }
        private void LoadTariffs(int residentsCount)
        {
            string query;

            // Определяем, из какой таблицы загружать тарифы
            if (residentsCount > 1)
            {
                query = "SELECT GorVoda, HolVoda, Svet, Gaz, Domofon, Musor, CapRem, Otoplenie FROM Tarif2";
            }
            else
            {
                query = "SELECT GorVoda, HolVoda, Svet, Gaz, Domofon, Musor, CapRem, Otoplenie FROM Tarif1";
            }

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Загружаем тарифы в текстовые поля
                        textBox8.Text = reader["GorVoda"].ToString();
                        textBox7.Text = reader["HolVoda"].ToString();
                        textBox6.Text = reader["Svet"].ToString();
                        textBox5.Text = reader["Gaz"].ToString();
                        textBox4.Text = reader["Domofon"].ToString();
                        textBox3.Text = reader["Musor"].ToString();
                        textBox2.Text = reader["CapRem"].ToString();
                        textBox1.Text = reader["Otoplenie"].ToString();
                    }
                    reader.Close();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { 
                    double num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0, num11 = 0;
            if (double.TryParse(textBox11.Text, out num9) && double.TryParse(textBox12.Text, out num10) && double.TryParse(textBox13.Text, out num11) && double.TryParse(textBox8.Text, out num8) && double.TryParse(textBox7.Text, out num7) && double.TryParse(textBox6.Text, out num6) && double.TryParse(textBox5.Text, out num5) && double.TryParse(textBox4.Text, out num4) && double.TryParse(textBox3.Text, out num3) && double.TryParse(textBox2.Text, out num2) && double.TryParse(textBox1.Text, out num1))
            {
                if (textBox11.Text != "" || textBox12.Text != "" || textBox13.Text != "")
                {
                    double sum = num1 + num2 + num3 + num4 + num5 + (num6 * num11) + (num7 * num10) + (num8 * num9);
                    textBox10.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("Введите значения счетчиков");
                }

            }
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";

            // Создаем подключение к базе данных
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Формируем SQL-запрос для вставки данных
                    string query = "INSERT INTO Raschet ([FIO], [Sum]) VALUES (@FIO, @Sum)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Добавляем параметры
                        command.Parameters.AddWithValue("@FIO", textBox9.Text);
                        command.Parameters.AddWithValue("@Sum", textBox10.Text);

                        // Выполняем команду
                        int result = command.ExecuteNonQuery();

                        // Проверяем результат
                        if (result > 0)
                        {
                            MessageBox.Show("Ваши данные занесены в базу данных!");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при добавлении данных.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

    }
}
