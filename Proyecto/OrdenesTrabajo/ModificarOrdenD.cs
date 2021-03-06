﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.OrdenesTrabajo
{
    public partial class ModificarOrdenD : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;
        public ModificarOrdenD()
        {
            InitializeComponent();
            this.CenterToScreen();
            autocompletarOrdenDomicilio();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autocompletarOrdenDomicilio()
        {
            string strquery1 = "Select num_ordentrabajo from ordendetrabajo where TIPOORDENTRABAJO='D'";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            da.SelectCommand = conexion.command;
            dt = new DataTable();
            da.Fill(dt);

            txtOrdenDomicilio.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                var rw = r.Field<string>("num_ordentrabajo");

                txtOrdenDomicilio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtOrdenDomicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtOrdenDomicilio.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strquery = "";

            strquery = "select [NUM_ORDENTRABAJO],[CI_CLIENTE],[TIPOORDENTRABAJO],CAST(FECHARECEP_REV AS DATE),[FECHAENTREGA],cast(HORAINICIOC as time(0)),[HABILITADA],[ESTADOOT],[DESCRIPCIONOT],[COSTOOT] from ordendetrabajo where num_ordentrabajo = " + txtOrdenDomicilio.Text + "";

            conexion.command = new SqlCommand(strquery, conexion.connection);

            da = new SqlDataAdapter();
            da.SelectCommand = conexion.command;
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("La orden no está registrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    txtCedulaDomicilio.Text = r[1].ToString();
                    fechaDomicilio.Value= DateTime.Parse(r[3].ToString());
                    horaDomicilio.Value = DateTime.Parse(r[5].ToString());
                    if (r[6].ToString().Equals("H"))
                    {
                        cbHabilitadaDomicilio.SelectedItem = "Habilitada";
                    }
                    else
                    {
                        cbHabilitadaDomicilio.Text = "Deshabilitada";
                    }

                    if (r[7].ToString().Equals("E"))
                    {
                        cbEstadoDomicilio.Text = "Entregada";
                    }
                    else
                    {
                        cbEstadoDomicilio.Text = "No entregada";
                    }

                    txtDescripcionDomicilio.Text = r[8].ToString();
                    txtCostoDomicilio.Text = r[9].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ordendetrabajo SET FECHARECEP_REV='" + fechaDomicilio.Value.Date.ToString("yyyyMMdd") + "',HORAINICIOC='" + horaDomicilio.Value.TimeOfDay.ToString(@"hh\:mm") + "',HABILITADA='"+cbHabilitadaDomicilio.SelectedItem.ToString()[0] + "',DESCRIPCIONOT='" + txtDescripcionDomicilio.Text + "',COSTOOT=" + txtCostoDomicilio.Text + ",ESTADOOT='"+cbEstadoDomicilio.SelectedItem.ToString()[0]+"' WHERE NUM_ORDENTRABAJO="+txtOrdenDomicilio.Text;
            //Console.WriteLine(sql);
            conexion.command = new SqlCommand(sql, conexion.connection);
            conexion.command.ExecuteNonQuery();
            conexion.command.Dispose();
            MessageBox.Show("La orden se modificó correctamente", "Orden Agregada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
