namespace Hospital.BUSQUEDAS
{
    partial class frmBusquedaPagos
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
            this.dgPagos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgDetalleP = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPagos
            // 
            this.dgPagos.AllowUserToAddRows = false;
            this.dgPagos.AllowUserToDeleteRows = false;
            this.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPagos.Location = new System.Drawing.Point(35, 83);
            this.dgPagos.Name = "dgPagos";
            this.dgPagos.ReadOnly = true;
            this.dgPagos.RowHeadersWidth = 62;
            this.dgPagos.RowTemplate.Height = 28;
            this.dgPagos.Size = new System.Drawing.Size(993, 231);
            this.dgPagos.TabIndex = 19;
            this.dgPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagos_CellClick);
            this.dgPagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPagos_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(946, 595);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 38);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(786, 595);
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
            this.txtFiltro.Size = new System.Drawing.Size(608, 26);
            this.txtFiltro.TabIndex = 15;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Hospital.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(986, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 73);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgDetalleP
            // 
            this.dgDetalleP.AllowUserToAddRows = false;
            this.dgDetalleP.AllowUserToDeleteRows = false;
            this.dgDetalleP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleP.Location = new System.Drawing.Point(35, 332);
            this.dgDetalleP.Name = "dgDetalleP";
            this.dgDetalleP.ReadOnly = true;
            this.dgDetalleP.RowHeadersWidth = 62;
            this.dgDetalleP.RowTemplate.Height = 28;
            this.dgDetalleP.Size = new System.Drawing.Size(993, 252);
            this.dgDetalleP.TabIndex = 20;
            this.dgDetalleP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalleP_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "CARGAR DETALLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBusquedaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDetalleP);
            this.Controls.Add(this.dgPagos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "frmBusquedaPagos";
            this.Text = "frmBusquedaPagos";
            this.Load += new System.EventHandler(this.frmBusquedaPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgPagos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgDetalleP;
        private System.Windows.Forms.Button button1;
    }
}