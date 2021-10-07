
namespace Inmueble2
{
    partial class Form1
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
            this.labelTipoInmueble = new System.Windows.Forms.Label();
            this.radioButtonPiso = new System.Windows.Forms.RadioButton();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.labelNumeroVentanas = new System.Windows.Forms.Label();
            this.labelPisoNro = new System.Windows.Forms.Label();
            this.textBoxNumeroPiso = new System.Windows.Forms.TextBox();
            this.textBoxNumeroVentana = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelSuperficie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.textBoxAntiguedad = new System.Windows.Forms.TextBox();
            this.textBoxSuperficie = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTipoInmueble
            // 
            this.labelTipoInmueble.AutoSize = true;
            this.labelTipoInmueble.Location = new System.Drawing.Point(313, 18);
            this.labelTipoInmueble.Name = "labelTipoInmueble";
            this.labelTipoInmueble.Size = new System.Drawing.Size(105, 20);
            this.labelTipoInmueble.TabIndex = 0;
            this.labelTipoInmueble.Text = "Tipo Inmurble";
            // 
            // radioButtonPiso
            // 
            this.radioButtonPiso.AutoSize = true;
            this.radioButtonPiso.Location = new System.Drawing.Point(269, 71);
            this.radioButtonPiso.Name = "radioButtonPiso";
            this.radioButtonPiso.Size = new System.Drawing.Size(64, 24);
            this.radioButtonPiso.TabIndex = 1;
            this.radioButtonPiso.TabStop = true;
            this.radioButtonPiso.Text = "Piso";
            this.radioButtonPiso.UseVisualStyleBackColor = true;
            this.radioButtonPiso.CheckedChanged += new System.EventHandler(this.radioButtonPiso_CheckedChanged);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(368, 71);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(72, 24);
            this.radioButtonLocal.TabIndex = 2;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonLocal_CheckedChanged);
            // 
            // labelNumeroVentanas
            // 
            this.labelNumeroVentanas.AutoSize = true;
            this.labelNumeroVentanas.Location = new System.Drawing.Point(381, 118);
            this.labelNumeroVentanas.Name = "labelNumeroVentanas";
            this.labelNumeroVentanas.Size = new System.Drawing.Size(173, 30);
            this.labelNumeroVentanas.TabIndex = 3;
            this.labelNumeroVentanas.Text = "Num Ventanas";
            // 
            // labelPisoNro
            // 
            this.labelPisoNro.AutoSize = true;
            this.labelPisoNro.Location = new System.Drawing.Point(245, 118);
            this.labelPisoNro.Name = "labelPisoNro";
            this.labelPisoNro.Size = new System.Drawing.Size(114, 30);
            this.labelPisoNro.TabIndex = 4;
            this.labelPisoNro.Text = "Num Piso";
            // 
            // textBoxNumeroPiso
            // 
            this.textBoxNumeroPiso.Location = new System.Drawing.Point(241, 162);
            this.textBoxNumeroPiso.Name = "textBoxNumeroPiso";
            this.textBoxNumeroPiso.Size = new System.Drawing.Size(92, 26);
            this.textBoxNumeroPiso.TabIndex = 5;
            // 
            // textBoxNumeroVentana
            // 
            this.textBoxNumeroVentana.Location = new System.Drawing.Point(385, 162);
            this.textBoxNumeroVentana.Name = "textBoxNumeroVentana";
            this.textBoxNumeroVentana.Size = new System.Drawing.Size(92, 26);
            this.textBoxNumeroVentana.TabIndex = 6;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(313, 220);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(75, 20);
            this.labelDireccion.TabIndex = 7;
            this.labelDireccion.Text = "Direccion";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(241, 253);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(236, 26);
            this.textBoxDireccion.TabIndex = 8;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(221, 448);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(94, 20);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio Base";
            // 
            // labelSuperficie
            // 
            this.labelSuperficie.AutoSize = true;
            this.labelSuperficie.Location = new System.Drawing.Point(221, 320);
            this.labelSuperficie.Name = "labelSuperficie";
            this.labelSuperficie.Size = new System.Drawing.Size(112, 20);
            this.labelSuperficie.TabIndex = 11;
            this.labelSuperficie.Text = "Superficie(m2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Antiguedad(años)";
            // 
            // textBoxPrecioBase
            // 
            this.textBoxPrecioBase.Location = new System.Drawing.Point(368, 442);
            this.textBoxPrecioBase.Name = "textBoxPrecioBase";
            this.textBoxPrecioBase.Size = new System.Drawing.Size(92, 26);
            this.textBoxPrecioBase.TabIndex = 13;
            // 
            // textBoxAntiguedad
            // 
            this.textBoxAntiguedad.Location = new System.Drawing.Point(368, 388);
            this.textBoxAntiguedad.Name = "textBoxAntiguedad";
            this.textBoxAntiguedad.Size = new System.Drawing.Size(92, 26);
            this.textBoxAntiguedad.TabIndex = 14;
            // 
            // textBoxSuperficie
            // 
            this.textBoxSuperficie.Location = new System.Drawing.Point(368, 320);
            this.textBoxSuperficie.Name = "textBoxSuperficie";
            this.textBoxSuperficie.Size = new System.Drawing.Size(92, 26);
            this.textBoxSuperficie.TabIndex = 15;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(284, 503);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(134, 44);
            this.buttonCalcular.TabIndex = 16;
            this.buttonCalcular.Text = "Calcular Precio";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 609);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxSuperficie);
            this.Controls.Add(this.textBoxAntiguedad);
            this.Controls.Add(this.textBoxPrecioBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSuperficie);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxNumeroVentana);
            this.Controls.Add(this.textBoxNumeroPiso);
            this.Controls.Add(this.labelPisoNro);
            this.Controls.Add(this.labelNumeroVentanas);
            this.Controls.Add(this.radioButtonLocal);
            this.Controls.Add(this.radioButtonPiso);
            this.Controls.Add(this.labelTipoInmueble);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipoInmueble;
        private System.Windows.Forms.RadioButton radioButtonPiso;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.Label labelNumeroVentanas;
        private System.Windows.Forms.Label labelPisoNro;
        private System.Windows.Forms.TextBox textBoxNumeroPiso;
        private System.Windows.Forms.TextBox textBoxNumeroVentana;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelSuperficie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecioBase;
        private System.Windows.Forms.TextBox textBoxAntiguedad;
        private System.Windows.Forms.TextBox textBoxSuperficie;
        private System.Windows.Forms.Button buttonCalcular;
    }
}

