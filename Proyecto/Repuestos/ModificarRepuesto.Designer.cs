﻿namespace Proyecto.Repuestos
{
    partial class ModificarRepuesto
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNumSerie = new System.Windows.Forms.TextBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.radioButNumSerie = new System.Windows.Forms.RadioButton();
            this.radioButModelo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBEstado = new System.Windows.Forms.ComboBox();
            this.textPrVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCant = new System.Windows.Forms.TextBox();
            this.textPrCompra = new System.Windows.Forms.TextBox();
            this.textNumSer = new System.Windows.Forms.TextBox();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Image = global::Proyecto.Properties.Resources.cancel1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(487, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 32);
            this.button3.TabIndex = 44;
            this.button3.Text = "Cerrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxNumSerie);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.radioButNumSerie);
            this.groupBox1.Controls.Add(this.radioButModelo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 86);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // button1
            // 
            this.button1.Image = global::Proyecto.Properties.Resources.buscar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNumSerie
            // 
            this.textBoxNumSerie.Location = new System.Drawing.Point(190, 52);
            this.textBoxNumSerie.Name = "textBoxNumSerie";
            this.textBoxNumSerie.ReadOnly = true;
            this.textBoxNumSerie.Size = new System.Drawing.Size(187, 20);
            this.textBoxNumSerie.TabIndex = 3;
            this.textBoxNumSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumSerie_KeyPress);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(190, 25);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.ReadOnly = true;
            this.textBoxModelo.Size = new System.Drawing.Size(187, 20);
            this.textBoxModelo.TabIndex = 2;
            // 
            // radioButNumSerie
            // 
            this.radioButNumSerie.AutoSize = true;
            this.radioButNumSerie.Location = new System.Drawing.Point(36, 53);
            this.radioButNumSerie.Name = "radioButNumSerie";
            this.radioButNumSerie.Size = new System.Drawing.Size(58, 17);
            this.radioButNumSerie.TabIndex = 1;
            this.radioButNumSerie.TabStop = true;
            this.radioButNumSerie.Text = "Código";
            this.radioButNumSerie.UseVisualStyleBackColor = true;
            this.radioButNumSerie.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButModelo
            // 
            this.radioButModelo.AutoSize = true;
            this.radioButModelo.Location = new System.Drawing.Point(36, 26);
            this.radioButModelo.Name = "radioButModelo";
            this.radioButModelo.Size = new System.Drawing.Size(60, 17);
            this.radioButModelo.TabIndex = 0;
            this.radioButModelo.TabStop = true;
            this.radioButModelo.Text = "Modelo";
            this.radioButModelo.UseVisualStyleBackColor = true;
            this.radioButModelo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBEstado);
            this.groupBox2.Controls.Add(this.textPrVenta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textCant);
            this.groupBox2.Controls.Add(this.textPrCompra);
            this.groupBox2.Controls.Add(this.textNumSer);
            this.groupBox2.Controls.Add(this.textModelo);
            this.groupBox2.Controls.Add(this.textNombre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 162);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // cBEstado
            // 
            this.cBEstado.FormattingEnabled = true;
            this.cBEstado.Items.AddRange(new object[] {
            "Agotado",
            "Disponible"});
            this.cBEstado.Location = new System.Drawing.Point(389, 132);
            this.cBEstado.Name = "cBEstado";
            this.cBEstado.Size = new System.Drawing.Size(137, 21);
            this.cBEstado.Sorted = true;
            this.cBEstado.TabIndex = 21;
            // 
            // textPrVenta
            // 
            this.textPrVenta.Location = new System.Drawing.Point(116, 132);
            this.textPrVenta.MaxLength = 7;
            this.textPrVenta.Name = "textPrVenta";
            this.textPrVenta.Size = new System.Drawing.Size(137, 20);
            this.textPrVenta.TabIndex = 18;
            this.textPrVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrVenta_KeyPress);
            this.textPrVenta.Leave += new System.EventHandler(this.textPrVenta_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Precio de Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Estado";
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(389, 95);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(137, 20);
            this.textCant.TabIndex = 20;
            this.textCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCant_KeyPress);
            // 
            // textPrCompra
            // 
            this.textPrCompra.Location = new System.Drawing.Point(116, 98);
            this.textPrCompra.MaxLength = 7;
            this.textPrCompra.Name = "textPrCompra";
            this.textPrCompra.Size = new System.Drawing.Size(137, 20);
            this.textPrCompra.TabIndex = 17;
            this.textPrCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrCompra_KeyPress);
            this.textPrCompra.Leave += new System.EventHandler(this.textPrCompra_Leave);
            // 
            // textNumSer
            // 
            this.textNumSer.Location = new System.Drawing.Point(389, 31);
            this.textNumSer.MaxLength = 15;
            this.textNumSer.Name = "textNumSer";
            this.textNumSer.ReadOnly = true;
            this.textNumSer.Size = new System.Drawing.Size(137, 20);
            this.textNumSer.TabIndex = 19;
            this.textNumSer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumSer_KeyPress);
            this.textNumSer.Leave += new System.EventHandler(this.textNumSer_Leave);
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(116, 65);
            this.textModelo.MaxLength = 30;
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(410, 20);
            this.textModelo.TabIndex = 16;
            this.textModelo.Leave += new System.EventHandler(this.textModelo_Leave);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(116, 31);
            this.textNombre.MaxLength = 20;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(137, 20);
            this.textNombre.TabIndex = 15;
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Precio de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Image = global::Proyecto.Properties.Resources.Notepad;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(401, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "ModificarRepuesto";
            this.Text = "Modificar Repuesto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNumSerie;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.RadioButton radioButNumSerie;
        private System.Windows.Forms.RadioButton radioButModelo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textPrVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.TextBox textPrCompra;
        private System.Windows.Forms.TextBox textNumSer;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cBEstado;
    }
}