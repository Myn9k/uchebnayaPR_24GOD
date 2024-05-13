using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUser
{
    public class User
    {
        public int id { get; set; }

        private string login, pass, email, birthdaydate, fio;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string BirthdayDate
        {
            get { return birthdaydate; }
            set { birthdaydate = value; }
        }
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public User() { }
        public User(string login, string pass, string email, string birthdaydate, string fIO)
        {
            this.login = login;
            this.pass = pass;
            this.email = email;
            this.birthdaydate = birthdaydate;
            this.FIO = fIO;
        }
    }
}
