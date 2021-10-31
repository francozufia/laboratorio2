
namespace DesafioIntegrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTipoPrenda = new System.Windows.Forms.Label();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.radioButtonBermuda = new System.Windows.Forms.RadioButton();
            this.radioButtonMangaCorta = new System.Windows.Forms.RadioButton();
            this.labelCalidad = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.buttonCalcularPrecio = new System.Windows.Forms.Button();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.checkBoxPremium = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MoeumT R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Tomato;
            this.labelTitulo.Location = new System.Drawing.Point(96, 14);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(189, 19);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Ventas al Por Mayor";
            // 
            // labelTipoPrenda
            // 
            this.labelTipoPrenda.AutoSize = true;
            this.labelTipoPrenda.Font = new System.Drawing.Font("MoeumT R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelTipoPrenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTipoPrenda.Location = new System.Drawing.Point(110, 68);
            this.labelTipoPrenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoPrenda.Name = "labelTipoPrenda";
            this.labelTipoPrenda.Size = new System.Drawing.Size(141, 19);
            this.labelTipoPrenda.TabIndex = 1;
            this.labelTipoPrenda.Text = "Tipo de Prenda";
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPantalon.Location = new System.Drawing.Point(48, 131);
            this.radioButtonPantalon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(107, 24);
            this.radioButtonPantalon.TabIndex = 2;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalon";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.radioButtonPantalon_CheckedChanged);
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCamisa.Location = new System.Drawing.Point(48, 192);
            this.radioButtonCamisa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(97, 24);
            this.radioButtonCamisa.TabIndex = 3;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.radioButtonCamisa_CheckedChanged);
            // 
            // radioButtonBermuda
            // 
            this.radioButtonBermuda.AutoSize = true;
            this.radioButtonBermuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBermuda.Location = new System.Drawing.Point(189, 131);
            this.radioButtonBermuda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonBermuda.Name = "radioButtonBermuda";
            this.radioButtonBermuda.Size = new System.Drawing.Size(109, 24);
            this.radioButtonBermuda.TabIndex = 4;
            this.radioButtonBermuda.TabStop = true;
            this.radioButtonBermuda.Text = "Bermuda";
            this.radioButtonBermuda.UseVisualStyleBackColor = true;
            // 
            // radioButtonMangaCorta
            // 
            this.radioButtonMangaCorta.AutoSize = true;
            this.radioButtonMangaCorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMangaCorta.Location = new System.Drawing.Point(176, 192);
            this.radioButtonMangaCorta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonMangaCorta.Name = "radioButtonMangaCorta";
            this.radioButtonMangaCorta.Size = new System.Drawing.Size(141, 24);
            this.radioButtonMangaCorta.TabIndex = 5;
            this.radioButtonMangaCorta.TabStop = true;
            this.radioButtonMangaCorta.Text = "Manga Corta";
            this.radioButtonMangaCorta.UseVisualStyleBackColor = true;
            // 
            // labelCalidad
            // 
            this.labelCalidad.AutoSize = true;
            this.labelCalidad.Font = new System.Drawing.Font("MoeumT R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCalidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCalidad.Location = new System.Drawing.Point(130, 266);
            this.labelCalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalidad.Name = "labelCalidad";
            this.labelCalidad.Size = new System.Drawing.Size(68, 19);
            this.labelCalidad.TabIndex = 6;
            this.labelCalidad.Text = "Calidad";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(62, 422);
            this.textBoxPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(70, 26);
            this.textBoxPrecio.TabIndex = 9;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(213, 422);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(70, 26);
            this.textBoxCantidad.TabIndex = 10;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("MoeumT R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrecio.Location = new System.Drawing.Point(58, 376);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(62, 19);
            this.labelPrecio.TabIndex = 11;
            this.labelPrecio.Text = "Precio";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("MoeumT R", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCantidad.Location = new System.Drawing.Point(209, 376);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(79, 19);
            this.labelCantidad.TabIndex = 12;
            this.labelCantidad.Text = "Cantidad";
            // 
            // buttonCalcularPrecio
            // 
            this.buttonCalcularPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularPrecio.ForeColor = System.Drawing.Color.Tomato;
            this.buttonCalcularPrecio.Location = new System.Drawing.Point(75, 495);
            this.buttonCalcularPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalcularPrecio.Name = "buttonCalcularPrecio";
            this.buttonCalcularPrecio.Size = new System.Drawing.Size(178, 45);
            this.buttonCalcularPrecio.TabIndex = 13;
            this.buttonCalcularPrecio.Text = "Calcular Precio";
            this.buttonCalcularPrecio.UseVisualStyleBackColor = true;
            this.buttonCalcularPrecio.Click += new System.EventHandler(this.buttonCalcularPrecio_Click);
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStandard.Location = new System.Drawing.Point(48, 321);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(117, 26);
            this.checkBoxStandard.TabIndex = 14;
            this.checkBoxStandard.Text = "Standard";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            // 
            // checkBoxPremium
            // 
            this.checkBoxPremium.AutoSize = true;
            this.checkBoxPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPremium.Location = new System.Drawing.Point(189, 321);
            this.checkBoxPremium.Name = "checkBoxPremium";
            this.checkBoxPremium.Size = new System.Drawing.Size(113, 26);
            this.checkBoxPremium.TabIndex = 15;
            this.checkBoxPremium.Text = "Premium";
            this.checkBoxPremium.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 566);
            this.Controls.Add(this.checkBoxPremium);
            this.Controls.Add(this.checkBoxStandard);
            this.Controls.Add(this.buttonCalcularPrecio);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.labelCalidad);
            this.Controls.Add(this.radioButtonMangaCorta);
            this.Controls.Add(this.radioButtonBermuda);
            this.Controls.Add(this.radioButtonCamisa);
            this.Controls.Add(this.radioButtonPantalon);
            this.Controls.Add(this.labelTipoPrenda);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "TuPrenda.com.ar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTipoPrenda;
        private System.Windows.Forms.RadioButton radioButtonPantalon;
        private System.Windows.Forms.RadioButton radioButtonCamisa;
        private System.Windows.Forms.RadioButton radioButtonBermuda;
        private System.Windows.Forms.RadioButton radioButtonMangaCorta;
        private System.Windows.Forms.Label labelCalidad;
       // private System.Windows.Forms.RadioButton radioButtonStandard;
        //private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Button buttonCalcularPrecio;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.CheckBox checkBoxPremium;
    }
}

