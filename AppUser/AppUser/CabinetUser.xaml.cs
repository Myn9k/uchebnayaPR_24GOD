﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppUser
{
    public partial class CabinetUser : Window
    {
        ApplicationContext db;
        AuthWindows authWin = new AuthWindows();

        public CabinetUser()
        {
            InitializeComponent();

        }
        public void GetIdUser(int Id)
        {
            db = new ApplicationContext();

            List<User> users = db.Users.ToList();
            string strUser = "";
            foreach (User user in users)
            {
                if (user.id == Id)
                {
                    strUser += $"Логин: {user.Login}" + $"\n ФИО: {user.FIO}" + $"\n Почта: {user.Email}" + $"\n Дата рождения: {user.BirthdayDate}";
                }
            }
            LoginUser.Text = strUser;
        }
    }
}