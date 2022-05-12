﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.Model;
using WpfApp1.Tools;

namespace WpfApp1.ViewModels
{
     class Connection
    {
        PasswordBox passwordBox;
        private readonly CurrentPageControl currentPageControl;

        public string Server { get; set; }
        public string User { get; set; }
        public string DB { get; set; }

        public CommandVM TestConnection { get; set; }
        public CommandVM SaveSettings { get; set; }

        public Connection(PasswordBox passwordBox, CurrentPageControl currentPageControl)
        {
            this.passwordBox = passwordBox;
            this.currentPageControl = currentPageControl;
            Server = Properties.Settings.Default.server;
            User = Properties.Settings.Default.user;
            DB = Properties.Settings.Default.db;
            passwordBox.Password = Properties.Settings.Default.pass;

            TestConnection = new CommandVM(() =>
            {
                var db = MySqlDB.GetDB();
                db.InitConnection(Server, User, DB, passwordBox.Password);
                if (db.OpenConnection())
                {
                    db.CloseConnection();
                    System.Windows.MessageBox.Show("Соединение успешно!");
                }
            });

            SaveSettings = new CommandVM(() =>
            {
                Properties.Settings.Default.user = User;
                Properties.Settings.Default.db = DB;
                Properties.Settings.Default.pass = passwordBox.Password;
                Properties.Settings.Default.server = Server;
                Properties.Settings.Default.Save();
                System.Windows.MessageBox.Show("Данные сохранены!");
            });
        }
    }
}
