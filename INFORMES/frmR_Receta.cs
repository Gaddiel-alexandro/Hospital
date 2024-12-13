using Hospital.CLASES;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.INFORMES
{
    public partial class frmR_Receta : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmR_Receta()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarpaciente()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from vReceta";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidNombreMedicos.DisplayMember = "Pacientes";
            cbidNombreMedicos.ValueMember = "id";
            cbidNombreMedicos.DataSource = dt;
        }

        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "select * from vReceta";
                ChTodo.Checked = false;
            }
            else if (ChTodo.Checked == false)
            {
                consulta = $"select * from vReceta where idPaciente = '{cbidNombreMedicos.SelectedValue.ToString()}'";

            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rVReceta.LocalReport.DataSources.Clear();
            this.rVReceta.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.R_Receta.rdlc";
            ReportDataSource r = new ReportDataSource("DataSet1", dt);
            this.rVReceta.LocalReport.DataSources.Add(r);
            this.rVReceta.RefreshReport();

        }

        private void frmR_Receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'consultorioDataSet.vReceta' Puede moverla o quitarla según sea necesario.
            //this.vRecetaTableAdapter.Fill(this.consultorioDataSet.vReceta);

            //this.rVReceta.RefreshReport();
            cargarpaciente();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }

        private void cbidNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
