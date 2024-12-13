namespace Hospital.FORMULARIOS
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsLimpiar = new System.Windows.Forms.ToolStripButton();
            this.tsEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbidGenero = new System.Windows.Forms.ComboBox();
            this.cbidEnfermedad = new System.Windows.Forms.ComboBox();
            this.cbidMedico = new System.Windows.Forms.ComboBox();
            this.cbidCitaM = new System.Windows.Forms.ComboBox();
            this.cbidMedicamento = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtA_Paterno = new System.Windows.Forms.TextBox();
            this.txtA_Materno = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(51, 66);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 26);
            this.txtid.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardar,
            this.tsBuscar,
            this.tsLimpiar,
            this.tsEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsGuardar
            // 
            this.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(34, 28);
            this.tsGuardar.Text = "toolStripButton1";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsBuscar.Image")));
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(34, 28);
            this.tsBuscar.Text = "toolStripButton2";
            this.tsBuscar.Click += new System.EventHandler(this.tsBuscar_Click);
            // 
            // tsLimpiar
            // 
            this.tsLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("tsLimpiar.Image")));
            this.tsLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLimpiar.Name = "tsLimpiar";
            this.tsLimpiar.Size = new System.Drawing.Size(34, 28);
            this.tsLimpiar.Text = "toolStripButton1";
            this.tsLimpiar.Click += new System.EventHandler(this.tsLimpiar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsEliminar.Image")));
            this.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(34, 28);
            this.tsEliminar.Text = "toolStripButton1";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Hospital.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(697, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 52);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "ENFERMEDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "MEDICO EN TURNO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 46;
            this.label7.Text = "APELLIDO MATERNO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "FECHA CITA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "MEDICAMENTO RECETADO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "GENERO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 50;
            this.label11.Text = "EDAD";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(489, 72);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(151, 26);
            this.dtpFechaNacimiento.TabIndex = 51;
            // 
            // cbidGenero
            // 
            this.cbidGenero.FormattingEnabled = true;
            this.cbidGenero.Location = new System.Drawing.Point(105, 377);
            this.cbidGenero.Name = "cbidGenero";
            this.cbidGenero.Size = new System.Drawing.Size(121, 28);
            this.cbidGenero.TabIndex = 52;
            // 
            // cbidEnfermedad
            // 
            this.cbidEnfermedad.FormattingEnabled = true;
            this.cbidEnfermedad.Location = new System.Drawing.Point(564, 132);
            this.cbidEnfermedad.Name = "cbidEnfermedad";
            this.cbidEnfermedad.Size = new System.Drawing.Size(174, 28);
            this.cbidEnfermedad.TabIndex = 53;
            // 
            // cbidMedico
            // 
            this.cbidMedico.FormattingEnabled = true;
            this.cbidMedico.Location = new System.Drawing.Point(584, 198);
            this.cbidMedico.Name = "cbidMedico";
            this.cbidMedico.Size = new System.Drawing.Size(154, 28);
            this.cbidMedico.TabIndex = 54;
            // 
            // cbidCitaM
            // 
            this.cbidCitaM.FormattingEnabled = true;
            this.cbidCitaM.Location = new System.Drawing.Point(540, 259);
            this.cbidCitaM.Name = "cbidCitaM";
            this.cbidCitaM.Size = new System.Drawing.Size(178, 28);
            this.cbidCitaM.TabIndex = 55;
            // 
            // cbidMedicamento
            // 
            this.cbidMedicamento.FormattingEnabled = true;
            this.cbidMedicamento.Location = new System.Drawing.Point(646, 320);
            this.cbidMedicamento.Name = "cbidMedicamento";
            this.cbidMedicamento.Size = new System.Drawing.Size(121, 28);
            this.cbidMedicamento.TabIndex = 56;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 26);
            this.txtNombre.TabIndex = 57;
            // 
            // txtA_Paterno
            // 
            this.txtA_Paterno.Location = new System.Drawing.Point(207, 223);
            this.txtA_Paterno.Name = "txtA_Paterno";
            this.txtA_Paterno.Size = new System.Drawing.Size(160, 26);
            this.txtA_Paterno.TabIndex = 58;
            // 
            // txtA_Materno
            // 
            this.txtA_Materno.Location = new System.Drawing.Point(207, 274);
            this.txtA_Materno.Name = "txtA_Materno";
            this.txtA_Materno.Size = new System.Drawing.Size(160, 26);
            this.txtA_Materno.TabIndex = 59;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(90, 339);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 26);
            this.txtEdad.TabIndex = 60;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtA_Materno);
            this.Controls.Add(this.txtA_Paterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbidMedicamento);
            this.Controls.Add(this.cbidCitaM);
            this.Controls.Add(this.cbidMedico);
            this.Controls.Add(this.cbidEnfermedad);
            this.Controls.Add(this.cbidGenero);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPacientes";
            this.Text = "frmPacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripButton tsLimpiar;
        private System.Windows.Forms.ToolStripButton tsEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbidGenero;
        private System.Windows.Forms.ComboBox cbidEnfermedad;
        private System.Windows.Forms.ComboBox cbidMedico;
        private System.Windows.Forms.ComboBox cbidCitaM;
        private System.Windows.Forms.ComboBox cbidMedicamento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtA_Paterno;
        private System.Windows.Forms.TextBox txtA_Materno;
        private System.Windows.Forms.TextBox txtEdad;
    }
}