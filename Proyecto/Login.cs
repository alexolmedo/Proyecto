﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new VentanaModulos().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new VentanaModulos().Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}