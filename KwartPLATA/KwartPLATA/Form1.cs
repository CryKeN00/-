using System.Data.OleDb;
using System.Net.Security;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace KwartPLATA
{
    public partial class Form1 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\revno\\KwartPLATA1.accdb";
        private TextBox userInputTextBox;
        private Label UserLabel1;
        private Label PasswordLabel1;
        private Label pasportLabel1;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserLabel1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string FIO = userInputTextBox.Text;
                string Pasport = pasportTextBox.Text;
                string Password = passwordTextBox.Text;
                if (FIO == "Admin" && Pasport == "Admin" && Password == "Admin")
                {
                    Form5 newForm = new Form5();
                    FormSwitcher.SwitchMainForm(this, newForm);

                }
                else
                {
                    int UserID = AuthenticateUser(FIO, Pasport, Password);
                    if (UserID != -1)
                    {
                        Form4 userCabinet = new Form4(UserID);
                        FormSwitcher.SwitchMainForm(this, userCabinet);

                    }
                    else
                    {
                        MessageBox.Show("Неверное имя пользователя или пароль.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private int AuthenticateUser(string FIO, string Pasport, string Password)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand("SELECT UserID FROM Users WHERE [FIO] = @FIO AND [Pasport] = @Pasport AND [Password] = @Password", connection))
                {
                    command.Parameters.Add("@FIO", OleDbType.VarChar).Value = FIO;
                    command.Parameters.Add("@Pasport", OleDbType.VarChar).Value =Pasport;
                    command.Parameters.Add("@Password", OleDbType.VarChar).Value = Password; 
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}

