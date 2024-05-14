using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class RegisterForm : Form
    {
        Point lastpoin;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoin.X;
                this.Top += e.Y - lastpoin.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoin = new Point(e.X, e.Y);
        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if(UserNameField.Text == "Введите имя")
            {
                UserNameField.Text = "";
                UserNameField.ForeColor= Color.Black;
            }
        }

        private void UserNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {
                UserNameField.Text = "Введите имя";
                UserNameField.ForeColor = Color.Gray;
            }
        }

        private void UserSurameField_Enter(object sender, EventArgs e)
        {
            if (UserSurameField.Text == "Введите Фамилю")
            {
                UserSurameField.Text = "";
                UserSurameField.ForeColor = Color.Black;
            }
        }

        private void UserSurameField_Leave(object sender, EventArgs e)
        {
            if (UserSurameField.Text == "")
            {
                UserSurameField.Text = "Введите Фамилю";
                UserSurameField.ForeColor = Color.Gray;
            }
        }

        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == "Введите Пароль")
            {
                PassBox.Text = "";
                PassBox.ForeColor = Color.Black;
            }
        }

        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")
            {
                PassBox.Text = "Введите Пароль";
                PassBox.ForeColor = Color.Gray;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(UserSurameField.Text == "Введите имя")
            {
                MessageBox.Show("Имя не ввёл тупица");
                return;
            }
            if (UserSurameField.Text == "")
            {
                MessageBox.Show("Имя не ввёл тупица");
                return;
            }
            if (PassBox.Text == "Введите Пароль")
            {
                MessageBox.Show("Пароль не ввёл тупица");
                return;
            }
            if (PassBox.Text == "")
            {
                MessageBox.Show("Пароль не ввёл тупица");
                return;
            }
            if (UserSurameField.Text == "Введите Фамилю")
            {
                MessageBox.Show("Фамилю не ввёл тупица");
                return;
            }
            if (UserSurameField.Text == "")
            {
                MessageBox.Show("Фамилю не ввёл тупица");
                return;
            }
            if (PassBox.Text == "Введите Логин")
            {
                MessageBox.Show("Логин не ввёл тупица");
                return;
            }
            if (PassBox.Text == "")
            {
                MessageBox.Show("Логин не ввёл тупица");
                return;
            }
            if (checkUser())
                return;
            
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname);", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Logintextbox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь Создан");
            else
                MessageBox.Show("Пользователь не Создан");

            db.closeConnection();
        }
        private void Logintextbox_Enter(object sender, EventArgs e)
        {
            if (Logintextbox.Text == "Введите Логин")
            {
                Logintextbox.Text = "";
                Logintextbox.ForeColor = Color.Black;
            }
        }

        private void Logintextbox_Leave(object sender, EventArgs e)
        {
            if (Logintextbox.Text == "")
            {
                Logintextbox.Text = "Введите Логин";
                Logintextbox.ForeColor = Color.Gray;
            }
        }
        public Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = Logintextbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) 
            {
                MessageBox.Show("Такое уже присутствует");
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
