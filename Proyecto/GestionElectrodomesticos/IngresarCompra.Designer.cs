﻿namespace Proyecto.GestionElectrodomesticos
{
    partial class IngresarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMesesIngElectV = new System.Windows.Forms.ComboBox();
            this.cbAñosIngElectV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDueñoAntIngElectV = new System.Windows.Forms.TextBox();
            this.txtPrecioIngElectV = new System.Windows.Forms.TextBox();
            this.txtNumSerIngElectV = new System.Windows.Forms.TextBox();
            this.txtModeloIngElectV = new System.Windows.Forms.TextBox();
            this.txtNombreIngElectV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Image = global::Proyecto.Properties.Resources.new2;
            this.Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar.Location = new System.Drawing.Point(400, 199);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(68, 29);
            this.Agregar.TabIndex = 57;
            this.Agregar.Text = "Agregar";
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(555, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 56;
            this.button2.Text = "Cerrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMesesIngElectV);
            this.groupBox1.Controls.Add(this.cbAñosIngElectV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDueñoAntIngElectV);
            this.groupBox1.Controls.Add(this.txtPrecioIngElectV);
            this.groupBox1.Controls.Add(this.txtNumSerIngElectV);
            this.groupBox1.Controls.Add(this.txtModeloIngElectV);
            this.groupBox1.Controls.Add(this.txtNombreIngElectV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 175);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Electrodoméstico Usado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(453, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Contacto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Precio de Venta";
            // 
            // cbMesesIngElectV
            // 
            this.cbMesesIngElectV.FormattingEnabled = true;
            this.cbMesesIngElectV.Items.AddRange(new object[] {
            "1 mes",
            "2 meses",
            "3 meses",
            "4 meses",
            "5 meses",
            "6 meses",
            "7 meses",
            "8 meses",
            "9 meses",
            "10 meses",
            "11 meses",
            "12 meses"});
            this.cbMesesIngElectV.Location = new System.Drawing.Point(518, 23);
            this.cbMesesIngElectV.Name = "cbMesesIngElectV";
            this.cbMesesIngElectV.Size = new System.Drawing.Size(75, 21);
            this.cbMesesIngElectV.TabIndex = 49;
            // 
            // cbAñosIngElectV
            // 
            this.cbAñosIngElectV.FormattingEnabled = true;
            this.cbAñosIngElectV.Items.AddRange(new object[] {
            "1 Año",
            "2 Años",
            "3 Años",
            "4 Años",
            "5 Años"});
            this.cbAñosIngElectV.Location = new System.Drawing.Point(453, 23);
            this.cbAñosIngElectV.Name = "cbAñosIngElectV";
            this.cbAñosIngElectV.Size = new System.Drawing.Size(59, 21);
            this.cbAñosIngElectV.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tiempo de uso";
            // 
            // txtDueñoAntIngElectV
            // 
            this.txtDueñoAntIngElectV.Location = new System.Drawing.Point(453, 63);
            this.txtDueñoAntIngElectV.Name = "txtDueñoAntIngElectV";
            this.txtDueñoAntIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtDueñoAntIngElectV.TabIndex = 46;
            // 
            // txtPrecioIngElectV
            // 
            this.txtPrecioIngElectV.Location = new System.Drawing.Point(140, 137);
            this.txtPrecioIngElectV.Name = "txtPrecioIngElectV";
            this.txtPrecioIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtPrecioIngElectV.TabIndex = 45;
            // 
            // txtNumSerIngElectV
            // 
            this.txtNumSerIngElectV.Location = new System.Drawing.Point(140, 97);
            this.txtNumSerIngElectV.Name = "txtNumSerIngElectV";
            this.txtNumSerIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNumSerIngElectV.TabIndex = 44;
            // 
            // txtModeloIngElectV
            // 
            this.txtModeloIngElectV.Location = new System.Drawing.Point(140, 60);
            this.txtModeloIngElectV.Name = "txtModeloIngElectV";
            this.txtModeloIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtModeloIngElectV.TabIndex = 43;
            // 
            // txtNombreIngElectV
            // 
            this.txtNombreIngElectV.Location = new System.Drawing.Point(140, 23);
            this.txtNombreIngElectV.Name = "txtNombreIngElectV";
            this.txtNombreIngElectV.Size = new System.Drawing.Size(140, 20);
            this.txtNombreIngElectV.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Propietario Anterior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Número de Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.blanco3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(474, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 55;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IngresarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 235);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "IngresarCompra";
            this.Text = "Ingresar Electrodoméstico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMesesIngElectV;
        private System.Windows.Forms.ComboBox cbAñosIngElectV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDueñoAntIngElectV;
        private System.Windows.Forms.TextBox txtPrecioIngElectV;
        private System.Windows.Forms.TextBox txtNumSerIngElectV;
        private System.Windows.Forms.TextBox txtModeloIngElectV;
        private System.Windows.Forms.TextBox txtNombreIngElectV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;





    }
}