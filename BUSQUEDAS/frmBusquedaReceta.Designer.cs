namespace Hospital.BUSQUEDAS
{
    partial class frmBusquedaReceta
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
            this.dgReceta = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgDetalleR = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleR)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReceta
            // 
            this.dgReceta.AllowUserToAddRows = false;
            this.dgReceta.AllowUserToDeleteRows = false;
            this.dgReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceta.Location = new System.Drawing.Point(39, 70);
            this.dgReceta.Name = "dgReceta";
            this.dgReceta.ReadOnly = true;
            this.dgReceta.RowHeadersWidth = 62;
            this.dgReceta.RowTemplate.Height = 28;
            this.dgReceta.Size = new System.Drawing.Size(1031, 228);
            this.dgReceta.TabIndex = 19;
            this.dgReceta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReceta_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(998, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(873, 547);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 38);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(39, 38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(692, 26);
            this.txtFiltro.TabIndex = 15;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Hospital.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(1064, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 73);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgDetalleR
            // 
            this.dgDetalleR.AllowUserToAddRows = false;
            this.dgDetalleR.AllowUserToDeleteRows = false;
            this.dgDetalleR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleR.Location = new System.Drawing.Point(39, 313);
            this.dgDetalleR.Name = "dgDetalleR";
            this.dgDetalleR.ReadOnly = true;
            this.dgDetalleR.RowHeadersWidth = 62;
            this.dgDetalleR.RowTemplate.Height = 28;
            this.dgDetalleR.Size = new System.Drawing.Size(1031, 228);
            this.dgDetalleR.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "CARGAR  DETALLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBusquedaReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDetalleR);
            this.Controls.Add(this.dgReceta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmBusquedaReceta";
            this.Text = "frmBusquedaReceta";
            this.Load += new System.EventHandler(this.frmBusquedaReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgReceta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.DataGridView dgDetalleR;
        private System.Windows.Forms.Button button1;
    }
}