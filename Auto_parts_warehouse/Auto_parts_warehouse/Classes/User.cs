using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_parts_warehouse.Classes
{
    public class User
    {
        public int id { get; set; }

        private string login, pass;
        private int root_id;
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
        public int Root_id
        {
            get { return root_id; }
            set { root_id = value; }
        }

        public User() { }
        public User(string login, string pass, int root_id)
        {
            this.login = login;
            this.pass = pass;
            this.root_id = root_id;
        }
    }
}
