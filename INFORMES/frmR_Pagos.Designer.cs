namespace Hospital.INFORMES
{
    partial class frmR_Pagos
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
            this.rVPagos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChTodo = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbidFechaFact = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rVPagos
            // 
            this.rVPagos.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.R_Receta.rdlc";
            this.rVPagos.Location = new System.Drawing.Point(23, 122);
            this.rVPagos.Name = "rVPagos";
            this.rVPagos.ServerReport.BearerToken = null;
            this.rVPagos.Size = new System.Drawing.Size(923, 294);
            this.rVPagos.TabIndex = 11;
            // 
            // ChTodo
            // 
            this.ChTodo.AutoSize = true;
            this.ChTodo.Location = new System.Drawing.Point(175, 48);
            this.ChTodo.Name = "ChTodo";
            this.ChTodo.Size = new System.Drawing.Size(80, 24);
            this.ChTodo.TabIndex = 10;
            this.ChTodo.Text = "TODO";
            this.ChTodo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(593, 38);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 42);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbidFechaFact
            // 
            this.cbidFechaFact.FormattingEnabled = true;
            this.cbidFechaFact.Location = new System.Drawing.Point(339, 36);
            this.cbidFechaFact.Name = "cbidFechaFact";
            this.cbidFechaFact.Size = new System.Drawing.Size(183, 28);
            this.cbidFechaFact.TabIndex = 8;
            // 
            // frmR_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.rVPagos);
            this.Controls.Add(this.ChTodo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbidFechaFact);
            this.Name = "frmR_Pagos";
            this.Text = "frmR_Pagos";
            this.Load += new System.EventHandler(this.frmR_Pagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rVPagos;
        private System.Windows.Forms.CheckBox ChTodo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbidFechaFact;
    }
}