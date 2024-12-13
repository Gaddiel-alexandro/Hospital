namespace Hospital.INFORMES
{
    partial class frmR_Receta
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
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbidNombreMedicos = new System.Windows.Forms.ComboBox();
            this.rVReceta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.consultorioDataSet = new Hospital.ConsultorioDataSet();
            this.vRecetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vRecetaTableAdapter = new Hospital.ConsultorioDataSetTableAdapters.vRecetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRecetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(326, 45);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(80, 24);
            this.ChTodo.TabIndex = 6;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(744, 35);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 42);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbidNombreMedicos
            // 
            this.cbidNombreMedicos.FormattingEnabled = true;
            this.cbidNombreMedicos.Location = new System.Drawing.Point(490, 33);
            this.cbidNombreMedicos.Name = "cbidNombreMedicos";
            this.cbidNombreMedicos.Size = new System.Drawing.Size(183, 28);
            this.cbidNombreMedicos.TabIndex = 4;
            this.cbidNombreMedicos.SelectedIndexChanged += new System.EventHandler(this.cbidNombre_SelectedIndexChanged);
            // 
            // rVReceta
            // 
            this.rVReceta.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.R_Receta.rdlc";
            this.rVReceta.Location = new System.Drawing.Point(34, 118);
            this.rVReceta.Name = "rVReceta";
            this.rVReceta.ServerReport.BearerToken = null;
            this.rVReceta.Size = new System.Drawing.Size(1035, 294);
            this.rVReceta.TabIndex = 7;
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vRecetaBindingSource
            // 
            this.vRecetaBindingSource.DataMember = "vReceta";
            this.vRecetaBindingSource.DataSource = this.consultorioDataSet;
            // 
            // vRecetaTableAdapter
            // 
            this.vRecetaTableAdapter.ClearBeforeFill = true;
            // 
            // frmR_Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.rVReceta);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbidNombreMedicos);
            this.Name = "frmR_Receta";
            this.Text = "frmR_Receta";
            this.Load += new System.EventHandler(this.frmR_Receta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vRecetaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChTodo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbidNombreMedicos;
        private Microsoft.Reporting.WinForms.ReportViewer rVReceta;
        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource vRecetaBindingSource;
        private ConsultorioDataSetTableAdapters.vRecetaTableAdapter vRecetaTableAdapter;
    }
}