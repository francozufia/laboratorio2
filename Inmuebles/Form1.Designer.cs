
namespace Inmuebles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTipoInmueble = new System.Windows.Forms.Label();
            this.radioButtonPiso = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.labelNumeroVentanas = new System.Windows.Forms.Label();
            this.labelNumeroPiso = new System.Windows.Forms.Label();
            this.textBoxNumeroPiso = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxNumeroVentanas = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelSuperficie = new System.Windows.Forms.Label();
            this.labelAntiguedad = new System.Windows.Forms.Label();
            this.labelPrecioBase = new System.Windows.Forms.Label();
            this.textBoxSuperficie = new System.Windows.Forms.TextBox();
            this.textBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.buttonCalcularPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTipoInmueble
            // 
            this.labelTipoInmueble.AutoSize = true;
            this.labelTipoInmueble.Location = new System.Drawing.Point(215, 9);
            this.labelTipoInmueble.Name = "labelTipoInmueble";
            this.labelTipoInmueble.Size = new System.Drawing.Size(74, 13);
            this.labelTipoInmueble.TabIndex = 0;
            this.labelTipoInmueble.Text = "Tipo Inmueble";
            // 
            // radioButtonPiso
            // 
            this.radioButtonPiso.AutoSize = true;
            this.radioButtonPiso.Location = new System.Drawing.Point(163, 42);
            this.radioButtonPiso.Name = "radioButtonPiso";
            this.radioButtonPiso.Size = new System.Drawing.Size(45, 17);
            this.radioButtonPiso.TabIndex = 1;
            this.radioButtonPiso.TabStop = true;
            this.radioButtonPiso.Text = "Piso";
            this.radioButtonPiso.UseVisualStyleBackColor = true;
            this.radioButtonPiso.CheckedChanged += new System.EventHandler(this.radioButtonPiso_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(283, 42);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLocal.TabIndex = 2;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // labelNumeroVentanas
            // 
            this.labelNumeroVentanas.AutoSize = true;
            this.labelNumeroVentanas.Location = new System.Drawing.Point(280, 93);
            this.labelNumeroVentanas.Name = "labelNumeroVentanas";
            this.labelNumeroVentanas.Size = new System.Drawing.Size(70, 13);
            this.labelNumeroVentanas.TabIndex = 3;
            this.labelNumeroVentanas.Text = "N º Ventanas";
            // 
            // labelNumeroPiso
            // 
            this.labelNumeroPiso.AutoSize = true;
            this.labelNumeroPiso.Location = new System.Drawing.Point(160, 93);
            this.labelNumeroPiso.Name = "labelNumeroPiso";
            this.labelNumeroPiso.Size = new System.Drawing.Size(45, 13);
            this.labelNumeroPiso.TabIndex = 4;
            this.labelNumeroPiso.Text = "N º Piso";
            // 
            // textBoxNumeroPiso
            // 
            this.textBoxNumeroPiso.Location = new System.Drawing.Point(163, 119);
            this.textBoxNumeroPiso.Name = "textBoxNumeroPiso";
            this.textBoxNumeroPiso.Size = new System.Drawing.Size(45, 20);
            this.textBoxNumeroPiso.TabIndex = 5;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(218, 178);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(137, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // textBoxNumeroVentanas
            // 
            this.textBoxNumeroVentanas.Location = new System.Drawing.Point(283, 119);
            this.textBoxNumeroVentanas.Name = "textBoxNumeroVentanas";
            this.textBoxNumeroVentanas.Size = new System.Drawing.Size(67, 20);
            this.textBoxNumeroVentanas.TabIndex = 7;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(160, 181);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 8;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelSuperficie
            // 
            this.labelSuperficie.AutoSize = true;
            this.labelSuperficie.Location = new System.Drawing.Point(160, 231);
            this.labelSuperficie.Name = "labelSuperficie";
            this.labelSuperficie.Size = new System.Drawing.Size(74, 13);
            this.labelSuperficie.TabIndex = 9;
            this.labelSuperficie.Text = "Superficie(m2)";
            // 
            // labelAntiguedad
            // 
            this.labelAntiguedad.AutoSize = true;
            this.labelAntiguedad.Location = new System.Drawing.Point(160, 275);
            this.labelAntiguedad.Name = "labelAntiguedad";
            this.labelAntiguedad.Size = new System.Drawing.Size(90, 13);
            this.labelAntiguedad.TabIndex = 10;
            this.labelAntiguedad.Text = "Antiguedad(años)";
            // 
            // labelPrecioBase
            // 
            this.labelPrecioBase.AutoSize = true;
            this.labelPrecioBase.Location = new System.Drawing.Point(160, 312);
            this.labelPrecioBase.Name = "labelPrecioBase";
            this.labelPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.labelPrecioBase.TabIndex = 11;
            this.labelPrecioBase.Text = "Precio Base";
            // 
            // textBoxSuperficie
            // 
            this.textBoxSuperficie.Location = new System.Drawing.Point(288, 228);
            this.textBoxSuperficie.Name = "textBoxSuperficie";
            this.textBoxSuperficie.Size = new System.Drawing.Size(67, 20);
            this.textBoxSuperficie.TabIndex = 12;
            // 
            // textBoxAntiguedad
            // 
            this.textBoxAntiguedad.Location = new System.Drawing.Point(288, 268);
            this.textBoxAntiguedad.Name = "textBoxAntiguedad";
            this.textBoxAntiguedad.Size = new System.Drawing.Size(67, 20);
            this.textBoxAntiguedad.TabIndex = 13;
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(288, 309);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.Size = new System.Drawing.Size(67, 20);
            this.textBoxPrecioBase.TabIndex = 14;
            // 
            // buttonCalcularPrecio
            // 
            this.buttonCalcularPrecio.Location = new System.Drawing.Point(187, 353);
            this.buttonCalcularPrecio.Name = "buttonCalcularPrecio";
            this.buttonCalcularPrecio.Size = new System.Drawing.Size(125, 28);
            this.buttonCalcularPrecio.TabIndex = 15;
            this.buttonCalcularPrecio.Text = "Calcular Precio";
            this.buttonCalcularPrecio.UseVisualStyleBackColor = true;
            this.buttonCalcularPrecio.Click += new System.EventHandler(this.buttonCalcularPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(542, 426);
            this.Controls.Add(this.buttonCalcularPrecio);
            this.Controls.Add(this.textBoxPrecioBase);
            this.Controls.Add(this.textBoxAntiguedad);
            this.Controls.Add(this.textBoxSuperficie);
            this.Controls.Add(this.labelPrecioBase);
            this.Controls.Add(this.labelAntiguedad);
            this.Controls.Add(this.labelSuperficie);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxNumeroVentanas);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxNumeroPiso);
            this.Controls.Add(this.labelNumeroPiso);
            this.Controls.Add(this.labelNumeroVentanas);
            this.Controls.Add(this.radioButtonLocal);
            this.Controls.Add(this.radioButtonPiso);
            this.Controls.Add(this.labelTipoInmueble);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Venta inmuebles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelTipoInmueble;
        private System.Windows.Forms.RadioButton radioButtonPiso;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.Label labelNumeroVentanas;
        private System.Windows.Forms.Label labelNumeroPiso;
        private System.Windows.Forms.TextBox textBoxNumeroPiso;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNumeroVentanas;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelSuperficie;
        private System.Windows.Forms.Label labelAntiguedad;
        private System.Windows.Forms.Label labelPrecioBase;
        private System.Windows.Forms.TextBox textBoxSuperficie;
        private System.Windows.Forms.TextBox textBoxAntiguedad;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.Button buttonCalcularPrecio;
    }
}

