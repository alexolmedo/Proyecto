﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Cliente
{
    public partial class ModificarCliente : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;
        public ModificarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Llenar los datos para autocompletar la búsqueda por cedula
            string strquery1 = "Select ci_cliente from cliente";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtCedula.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtCedula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCedula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtCedula.AutoCompleteCustomSource.Add(rw);
            }

            //Llenar los datos para autocompletar la búsqueda por nombre
            string strquery2 = "Select nombrecliente from cliente";
            conexion.command = new SqlCommand(strquery2, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtNombre.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("nombrecliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtNombre.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Confirma modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                
            if (dr == DialogResult.Yes)
            {
                if (nomActCliente.Text.Equals("") || cedActCliente.Text.Equals("") || dirActCliente.Text.Equals("") || telActCliente.Text.Equals("") || correoActCliente.Text.Equals(""))
                {

                    MessageBox.Show("Datos Incompletos, los campos con * son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                else if (!nomActCliente.Text.Equals("") || !cedActCliente.Text.Equals("") || !dirActCliente.Text.Equals("") || !telActCliente.Text.Equals("") || !correoActCliente.Text.Equals(""))
                {
                    //Console.WriteLine(dirActCliente);
                    string sql = "Update cliente set CI_Cliente = '" + cedActCliente.Text + "', NombreCliente ='" + nomActCliente.Text + "', TelefonoCliente='" + telActCliente.Text + 
                        "',DireccionCliente='" + dirActCliente.Text + "',RUCCliente='" + RUCActCliente.Text + "',correoCliente='" + correoActCliente.Text + "',EstadoCliente ='" + comboBoxEstC.SelectedItem + "' where CI_Cliente = '"+ cedActCliente.Text +"'";
                    Console.WriteLine(sql);
                   
                    conexion.command = new SqlCommand(sql, conexion.connection);
                    conexion.command.ExecuteNonQuery();
                    conexion.command.Dispose();
                    MessageBox.Show("El cliente se modificó correctamente", "Cliente Modificado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }

        }

        private void cedAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void telAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void RUCAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtCedula.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtCedula.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButNombre.Checked)
                {
                    if (txtNombre.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el nombre del cliente a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from cliente where NombreCliente = '" + txtNombre.Text + "'";
                    }
                }

                if (radioButCed.Checked)
                {
                    if (txtCedula.Text == "")
                    {
                        MessageBox.Show("No ha ingresado la cédula del cliente a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from cliente where CI_Cliente = " + txtCedula.Text + "";
                    }
                }

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                //fetching query in the database.
                da.SelectCommand = conexion.command;
                //inicializar nueva datatable
                dt = new DataTable();
                //refresca las filas segun el rango especificado en el datasource. 
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("El cliente no está registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiarCampos();
                }
                else
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        cedActCliente.Text = r[0].ToString();
                        nomActCliente.Text = r[1].ToString();
                        telActCliente.Text = r[2].ToString();
                        dirActCliente.Text = r[3].ToString();
                        RUCActCliente.Text = r[4].ToString();
                        correoActCliente.Text = r[5].ToString();
                        comboBoxEstC.SelectedItem = r[6];
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
 
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dirActCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar=='-'|| e.KeyChar == '.'|| e.KeyChar == ',')
            {
                 e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void correoActCliente_Leave(object sender, EventArgs e)
        {
            if (correoActCliente.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(correoActCliente.Text, "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$"))
                    {
                
                    MessageBox.Show("El correo no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    correoActCliente.Text = "";               
                }
            }
        }

        private bool validadorDeCedula(string cedula)
        {

            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;
            bool res = false;

            if (int.TryParse(cedula, out isNumeric) && cedula.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(cedula[0], cedula[1], string.Empty));
                var digitoTres = Convert.ToInt32(cedula[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {


                    var digitoVerificadorRecibido = Convert.ToInt32(cedula[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                    Convert.ToInt32(cedula[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ?
                        10 - (total % 10) : (total % 10) : total;

                    res = (digitoVerificadorObtenido == digitoVerificadorRecibido);

                }
                else
                {
                    res = false;

                }

            }

            return res;
        }

        private void cedActCliente_Leave(object sender, EventArgs e)
        {
            if (!validadorDeCedula(cedActCliente.Text))
            {
                MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cedActCliente.Text = "";
            }
        }

        private void telActCliente_Leave(object sender, EventArgs e)
        {
            if (telActCliente.Text != "")
            {
                if (telActCliente.Text.Length == 8 || telActCliente.Text.Length < 7 || telActCliente.Text.Length > 10 || !System.Text.RegularExpressions.Regex.IsMatch(telActCliente.Text, "^[0-9]{7,10}$"))
                {
                    MessageBox.Show("El teléfono no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    telActCliente.Text = "";
                }
            } 
        }

        private void dirActCliente_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(dirActCliente.Text, "^[a-zA-Z0-9., -áéíóú]{0,150}$"))
            {
                MessageBox.Show("La dirección no es válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dirActCliente.Text = "";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxEstC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            cedActCliente.Text = "";
            nomActCliente.Text = "";
            telActCliente.Text = "";
            dirActCliente.Text = "";
            RUCActCliente.Text = "";
            correoActCliente.Text = "";
            comboBoxEstC.SelectedItem = "";
        }

        private void nomActCliente_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(nomActCliente.Text, "^[a-zA-Z0-9., -áéíóú]{0,60}$"))
            {
                MessageBox.Show("La nombre no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                nomActCliente.Text = "";
            }
        }

        private void RUCActCliente_Leave(object sender, EventArgs e)
        {
            if (RUCActCliente.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(RUCActCliente.Text, "^[0-9]{13}$"))
                {
                    MessageBox.Show("El RUC no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    RUCActCliente.Text = "";

                }
                else
                {
                    if (RUCActCliente.Text.Substring(0, 10) != cedActCliente.Text || RUCActCliente.Text.Substring(10, 3) != "001")
                    {
                        MessageBox.Show("El RUC no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        RUCActCliente.Text = "";
                    }
                }

            }
        }
    }
}
