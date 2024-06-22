namespace Presentacion
{
    partial class frmAgregarDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.numCantidadCanciones = new System.Windows.Forms.NumericUpDown();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilos = new System.Windows.Forms.ComboBox();
            this.lblFormatoEdicion = new System.Windows.Forms.Label();
            this.cboFormatoEdicion = new System.Windows.Forms.ComboBox();
            this.pbxImagenTapa = new System.Windows.Forms.PictureBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNuevoDisco = new System.Windows.Forms.Label();
            this.btnLevantarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(92, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(134, 64);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(14, 92);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(114, 13);
            this.lblFechaLanzamiento.TabIndex = 2;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(134, 88);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(210, 20);
            this.dtpFechaLanzamiento.TabIndex = 3;
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(9, 118);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(119, 13);
            this.lblCantidadCanciones.TabIndex = 4;
            this.lblCantidadCanciones.Text = "Cantidad de canciones:";
            // 
            // numCantidadCanciones
            // 
            this.numCantidadCanciones.Location = new System.Drawing.Point(134, 114);
            this.numCantidadCanciones.Name = "numCantidadCanciones";
            this.numCantidadCanciones.Size = new System.Drawing.Size(50, 20);
            this.numCantidadCanciones.TabIndex = 5;
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(92, 144);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(35, 13);
            this.lblEstilo.TabIndex = 6;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboEstilos
            // 
            this.cboEstilos.FormattingEnabled = true;
            this.cboEstilos.Location = new System.Drawing.Point(134, 140);
            this.cboEstilos.Name = "cboEstilos";
            this.cboEstilos.Size = new System.Drawing.Size(121, 21);
            this.cboEstilos.TabIndex = 7;
            // 
            // lblFormatoEdicion
            // 
            this.lblFormatoEdicion.AutoSize = true;
            this.lblFormatoEdicion.Location = new System.Drawing.Point(17, 171);
            this.lblFormatoEdicion.Name = "lblFormatoEdicion";
            this.lblFormatoEdicion.Size = new System.Drawing.Size(111, 13);
            this.lblFormatoEdicion.TabIndex = 8;
            this.lblFormatoEdicion.Text = "Formato de la edición:";
            // 
            // cboFormatoEdicion
            // 
            this.cboFormatoEdicion.FormattingEnabled = true;
            this.cboFormatoEdicion.Location = new System.Drawing.Point(134, 167);
            this.cboFormatoEdicion.Name = "cboFormatoEdicion";
            this.cboFormatoEdicion.Size = new System.Drawing.Size(121, 21);
            this.cboFormatoEdicion.TabIndex = 9;
            // 
            // pbxImagenTapa
            // 
            this.pbxImagenTapa.Location = new System.Drawing.Point(379, 64);
            this.pbxImagenTapa.Name = "pbxImagenTapa";
            this.pbxImagenTapa.Size = new System.Drawing.Size(220, 208);
            this.pbxImagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenTapa.TabIndex = 10;
            this.pbxImagenTapa.TabStop = false;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(19, 198);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(109, 13);
            this.lblUrlImagen.TabIndex = 11;
            this.lblUrlImagen.Text = "URL Imagen de tapa:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(134, 194);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(210, 20);
            this.txtUrlImagen.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(180, 249);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblNuevoDisco
            // 
            this.lblNuevoDisco.AutoSize = true;
            this.lblNuevoDisco.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoDisco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNuevoDisco.Location = new System.Drawing.Point(12, 9);
            this.lblNuevoDisco.Name = "lblNuevoDisco";
            this.lblNuevoDisco.Size = new System.Drawing.Size(259, 34);
            this.lblNuevoDisco.TabIndex = 15;
            this.lblNuevoDisco.Text = "Agregar nuevo disco";
            // 
            // btnLevantarImagen
            // 
            this.btnLevantarImagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevantarImagen.Location = new System.Drawing.Point(350, 193);
            this.btnLevantarImagen.Name = "btnLevantarImagen";
            this.btnLevantarImagen.Size = new System.Drawing.Size(23, 23);
            this.btnLevantarImagen.TabIndex = 16;
            this.btnLevantarImagen.Text = "+";
            this.btnLevantarImagen.UseVisualStyleBackColor = true;
            // 
            // frmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 297);
            this.Controls.Add(this.btnLevantarImagen);
            this.Controls.Add(this.lblNuevoDisco);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.pbxImagenTapa);
            this.Controls.Add(this.cboFormatoEdicion);
            this.Controls.Add(this.lblFormatoEdicion);
            this.Controls.Add(this.cboEstilos);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.numCantidadCanciones);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.NumericUpDown numCantidadCanciones;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilos;
        private System.Windows.Forms.Label lblFormatoEdicion;
        private System.Windows.Forms.ComboBox cboFormatoEdicion;
        private System.Windows.Forms.PictureBox pbxImagenTapa;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNuevoDisco;
        private System.Windows.Forms.Button btnLevantarImagen;
    }
}