﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.GestionElectrodomesticos
{
    public partial class IngresarCompra : Form
    {
        public IngresarCompra()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNombreIngElectV.Text = "";
            txtModeloIngElectV.Text = "";
            txtNumSerIngElectV.Text = "";
            txtPrecioIngElectV.Text = "";
            txtDueñoAntIngElectV.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNombreIngElectR.Text = "";
            txtModeloIngElectR.Text = "";
            txtNumSerIngElectR.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}