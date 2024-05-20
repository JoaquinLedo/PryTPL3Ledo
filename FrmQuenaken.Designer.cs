namespace PryTPL3Ledo
{
    partial class FrmQuenaken
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblAsiento = new System.Windows.Forms.Label();
            this.TxtAsiento = new System.Windows.Forms.TextBox();
            this.TxtFila = new System.Windows.Forms.TextBox();
            this.BtnReservar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitulo2 = new System.Windows.Forms.Label();
            this.LblAzul = new System.Windows.Forms.Label();
            this.LblV = new System.Windows.Forms.Label();
            this.chbSectorVerde = new System.Windows.Forms.CheckBox();
            this.chbSectorAzul = new System.Windows.Forms.CheckBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.LblN = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnTobas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOnas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(169, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(171, 13);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Reserva de Ubicacion de Asientos";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // LblAsiento
            // 
            this.LblAsiento.AutoSize = true;
            this.LblAsiento.Location = new System.Drawing.Point(163, 304);
            this.LblAsiento.Name = "LblAsiento";
            this.LblAsiento.Size = new System.Drawing.Size(26, 13);
            this.LblAsiento.TabIndex = 1;
            this.LblAsiento.Text = "Fila:";
            // 
            // TxtAsiento
            // 
            this.TxtAsiento.Location = new System.Drawing.Point(207, 331);
            this.TxtAsiento.Name = "TxtAsiento";
            this.TxtAsiento.Size = new System.Drawing.Size(153, 20);
            this.TxtAsiento.TabIndex = 3;
            // 
            // TxtFila
            // 
            this.TxtFila.Location = new System.Drawing.Point(207, 301);
            this.TxtFila.Name = "TxtFila";
            this.TxtFila.Size = new System.Drawing.Size(153, 20);
            this.TxtFila.TabIndex = 4;
            // 
            // BtnReservar
            // 
            this.BtnReservar.Location = new System.Drawing.Point(25, 388);
            this.BtnReservar.Name = "BtnReservar";
            this.BtnReservar.Size = new System.Drawing.Size(451, 46);
            this.BtnReservar.TabIndex = 7;
            this.BtnReservar.Text = "RESERVAR";
            this.BtnReservar.UseVisualStyleBackColor = true;
            this.BtnReservar.Click += new System.EventHandler(this.BtnReservar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Asiento:";
            // 
            // LblTitulo2
            // 
            this.LblTitulo2.AutoSize = true;
            this.LblTitulo2.Location = new System.Drawing.Point(227, 44);
            this.LblTitulo2.Name = "LblTitulo2";
            this.LblTitulo2.Size = new System.Drawing.Size(43, 13);
            this.LblTitulo2.TabIndex = 12;
            this.LblTitulo2.Text = "TOBAS";
            // 
            // LblAzul
            // 
            this.LblAzul.AutoSize = true;
            this.LblAzul.Location = new System.Drawing.Point(79, 88);
            this.LblAzul.Name = "LblAzul";
            this.LblAzul.Size = new System.Drawing.Size(64, 13);
            this.LblAzul.TabIndex = 15;
            this.LblAzul.Text = "Sector Azul:";
            // 
            // LblV
            // 
            this.LblV.AutoSize = true;
            this.LblV.Location = new System.Drawing.Point(353, 88);
            this.LblV.Name = "LblV";
            this.LblV.Size = new System.Drawing.Size(72, 13);
            this.LblV.TabIndex = 16;
            this.LblV.Text = "Sector Verde:";
            // 
            // chbSectorVerde
            // 
            this.chbSectorVerde.AutoSize = true;
            this.chbSectorVerde.Location = new System.Drawing.Point(356, 183);
            this.chbSectorVerde.Name = "chbSectorVerde";
            this.chbSectorVerde.Size = new System.Drawing.Size(88, 17);
            this.chbSectorVerde.TabIndex = 17;
            this.chbSectorVerde.Text = "Sector Verde";
            this.chbSectorVerde.UseVisualStyleBackColor = true;
            // 
            // chbSectorAzul
            // 
            this.chbSectorAzul.AutoSize = true;
            this.chbSectorAzul.Location = new System.Drawing.Point(82, 183);
            this.chbSectorAzul.Name = "chbSectorAzul";
            this.chbSectorAzul.Size = new System.Drawing.Size(80, 17);
            this.chbSectorAzul.TabIndex = 18;
            this.chbSectorAzul.Text = "Sector Azul";
            this.chbSectorAzul.UseVisualStyleBackColor = true;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(163, 271);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(29, 13);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "DNI:";
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(207, 271);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(153, 20);
            this.TxtDni.TabIndex = 20;
            // 
            // LblN
            // 
            this.LblN.AutoSize = true;
            this.LblN.Location = new System.Drawing.Point(145, 242);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(47, 13);
            this.LblN.TabIndex = 21;
            this.LblN.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(207, 239);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(153, 20);
            this.TxtNombre.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PryTPL3Ledo.Properties.Resources.aaaa;
            this.pictureBox3.Location = new System.Drawing.Point(285, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 53);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryTPL3Ledo.Properties.Resources.aaaa;
            this.pictureBox1.Location = new System.Drawing.Point(25, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 53);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnTobas
            // 
            this.BtnTobas.Location = new System.Drawing.Point(124, 510);
            this.BtnTobas.Name = "BtnTobas";
            this.BtnTobas.Size = new System.Drawing.Size(75, 23);
            this.BtnTobas.TabIndex = 23;
            this.BtnTobas.Text = "Tobas";
            this.BtnTobas.UseVisualStyleBackColor = true;
            this.BtnTobas.Click += new System.EventHandler(this.BtnTobas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cambiar de Sucursal";
            // 
            // BtnOnas
            // 
            this.BtnOnas.Location = new System.Drawing.Point(327, 510);
            this.BtnOnas.Name = "BtnOnas";
            this.BtnOnas.Size = new System.Drawing.Size(75, 23);
            this.BtnOnas.TabIndex = 25;
            this.BtnOnas.Text = "Onas";
            this.BtnOnas.UseVisualStyleBackColor = true;
            this.BtnOnas.Click += new System.EventHandler(this.BtnOnas_Click);
            // 
            // FrmQuenaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 565);
            this.Controls.Add(this.BtnOnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnTobas);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblN);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.chbSectorAzul);
            this.Controls.Add(this.chbSectorVerde);
            this.Controls.Add(this.LblV);
            this.Controls.Add(this.LblAzul);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.LblTitulo2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReservar);
            this.Controls.Add(this.TxtFila);
            this.Controls.Add(this.TxtAsiento);
            this.Controls.Add(this.LblAsiento);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmQuenaken";
            this.Text = "Reserva de Ubicacion de Asientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblAsiento;
        private System.Windows.Forms.TextBox TxtAsiento;
        private System.Windows.Forms.TextBox TxtFila;
        private System.Windows.Forms.Button BtnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LblAzul;
        private System.Windows.Forms.Label LblV;
        private System.Windows.Forms.CheckBox chbSectorVerde;
        private System.Windows.Forms.CheckBox chbSectorAzul;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label LblN;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnTobas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOnas;
    }
}

