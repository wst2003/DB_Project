﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //刘琦部分
        private void ManagerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin frm = new ManagerLogin();
            frm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterCustomer frm = new RegisterCustomer();
            frm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginCustomer frm = new LoginCustomer();
            frm.Show();
        }
    }
}
