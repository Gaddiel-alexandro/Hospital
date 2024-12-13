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
    public partial class frmR_Citas : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmR_Citas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarmedico()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from vDetalleCitas";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidNombreMedicos.DisplayMember = "NombrePaciente";
            cbidNombreMedicos.ValueMember = "PacienteId";
            cbidNombreMedicos.DataSource = dt;
        }

        void cargarreporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "select * from vDetalleCitas";
                ChTodo.Checked = false;
            }
            else if (ChTodo.Checked == false)
            {
                consulta = $"select * from vDetalleCitas where PacienteId = '{cbidNombreMedicos.SelectedValue.ToString()}'";

            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rvDetalleCitas.LocalReport.DataSources.Clear();
            this.rvDetalleCitas.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.RCitasM.rdlc";
            ReportDataSource r = new ReportDataSource("dtsCitaM", dt);
            this.rvDetalleCitas.LocalReport.DataSources.Add(r);
            this.rvDetalleCitas.RefreshReport();

        }

        private void frmR_Citas_Load(object sender, EventArgs e)
        {
            cargarmedico();
            //this.reportViewer1.RefreshReport();
        }

        private void cbidNombreMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarreporte();
        }
    }
}
