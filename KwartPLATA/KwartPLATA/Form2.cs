using System.Data.OleDb;
namespace KwartPLATA
{
    public partial class Form2 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";

        public Form2()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> items = new List<string>()
            {
             "Да",
             "Нет"
            };
            comboBox1.Items.AddRange(items.ToArray());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users ([FIO],[Pasport],[S],[Birthdat],[Domofone],[Kolvo],[Password]) VALUES (?,?,?,?,?,?,?)";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FIO", textBox7.Text);
                        command.Parameters.AddWithValue("@Pasport", textBox5.Text);
                        command.Parameters.AddWithValue("@S", textBox3.Text);
                        command.Parameters.AddWithValue("@Birthdat", DateTime.Parse(maskedTextBox1.Text));
                        command.Parameters.AddWithValue("@Domofone", comboBox1.Text);
                        command.Parameters.AddWithValue("@Kolvo", textBox1.Text);
                        command.Parameters.AddWithValue("@Password", textBox2.Text);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Вы зарегистрированы!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            Form1 newForm = new Form1();
            FormSwitcher.SwitchMainForm(this, newForm);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
