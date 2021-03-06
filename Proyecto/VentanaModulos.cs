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
    public partial class VentanaModulos : Form
    {
        public VentanaModulos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void VentanaModulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void insertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
            //this.Enabled = false;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.ConsultarCliente().ShowDialog();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.ModificarCliente().ShowDialog();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.GenerarFactura().ShowDialog();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.BuscarFactura().ShowDialog();
        }

        private void deshabilitarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.DeshabilitarFactura().ShowDialog();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Repuestos.IngresarRepuesto().ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Repuestos.ModificarRepuesto().ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Repuestos.ConsultarRepuesto().ShowDialog();
        }

        private void deshabilitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Repuestos.DeshabilitarRepuesto().ShowDialog();
        }

        private void insertarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.IngresarOrden().ShowDialog();
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.DeshabilitarOrden().ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.IngresarCompra().ShowDialog();
        }

        private void modificarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.ModificarCompra().ShowDialog();
        }

        private void eliminarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.EliminarCompra().ShowDialog();
        }

        private void usadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.ConsultarElectrodomestico().ShowDialog();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Administración.ParametrosFactura().ShowDialog();

        }

        private void VentanaModulos_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parámetrosOrdenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Administración.ParametrosOrden().ShowDialog();
        }

        private void ordenADomicilioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ConsultarOrdenD().ShowDialog();
        }

        private void ordenEnElLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ConsultarOrdenL().ShowDialog();
        }

        private void ordenADomicilioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ModificarOrdenD().ShowDialog();
        }

        private void ordenEnElLocalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ModificarOrdenL().ShowDialog();
        }

        private void consultarAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VentanaAyuda().ShowDialog();

        }
    }
}
