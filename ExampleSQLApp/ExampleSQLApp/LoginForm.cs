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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PassBox.AutoSize = false;
            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 64);
            this.PassBox.Size = new Size(this.PassBox.Size.Width, 64);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = PassBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @ul AND `pass` = @up", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@up", MySqlDbType.  VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else MessageBox.Show("No");
        }
    }
}
