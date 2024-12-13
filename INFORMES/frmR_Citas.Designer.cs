namespace Hospital.INFORMES
{
    partial class frmR_Citas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dtsDetallesCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDetallesCita = new Hospital.dtsDetallesCita();
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbidNombreMedicos = new System.Windows.Forms.ComboBox();
            this.rvDetalleCitas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDetallesCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDetallesCita)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsDetallesCitaBindingSource
            // 
            this.dtsDetallesCitaBindingSource.DataSource = this.dtsDetallesCita;
            this.dtsDetallesCitaBindingSource.Position = 0;
            // 
            // dtsDetallesCita
            // 
            this.dtsDetallesCita.DataSetName = "dtsDetallesCita";
            this.dtsDetallesCita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(118, 51);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(80, 24);
            this.ChTodo.TabIndex = 9;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(536, 41);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 42);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbidNombreMedicos
            // 
            this.cbidNombreMedicos.FormattingEnabled = true;
            this.cbidNombreMedicos.Location = new System.Drawing.Point(282, 39);
            this.cbidNombreMedicos.Name = "cbidNombreMedicos";
            this.cbidNombreMedicos.Size = new System.Drawing.Size(183, 28);
            this.cbidNombreMedicos.TabIndex = 7;
            this.cbidNombreMedicos.SelectedIndexChanged += new System.EventHandler(this.cbidNombreMedicos_SelectedIndexChanged);
            // 
            // rvDetalleCitas
            // 
            reportDataSource1.Name = "dtsDetallesC";
            reportDataSource1.Value = this.dtsDetallesCitaBindingSource;
            this.rvDetalleCitas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvDetalleCitas.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.R_DetalleCitas.rdlc";
            this.rvDetalleCitas.Location = new System.Drawing.Point(29, 114);
            this.rvDetalleCitas.Name = "rvDetalleCitas";
            this.rvDetalleCitas.ServerReport.BearerToken = null;
            this.rvDetalleCitas.Size = new System.Drawing.Size(1121, 297);
            this.rvDetalleCitas.TabIndex = 10;
            // 
            // frmR_Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 510);
            this.Controls.Add(this.rvDetalleCitas);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbidNombreMedicos);
            this.Name = "frmR_Citas";
            this.Text = "frmR_Citas";
            this.Load += new System.EventHandler(this.frmR_Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsDetallesCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDetallesCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChTodo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbidNombreMedicos;
        private Microsoft.Reporting.WinForms.ReportViewer rvDetalleCitas;
        private System.Windows.Forms.BindingSource dtsDetallesCitaBindingSource;
        private dtsDetallesCita dtsDetallesCita;
    }
}