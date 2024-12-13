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
    public partial class frmR_Pagos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmR_Pagos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarfechafact()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from vPagos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidFechaFact.DisplayMember = "FechaFactura";
            cbidFechaFact.ValueMember = "IdPaciente";
            cbidFechaFact.DataSource = dt;  
        }

        void cargareporte()
        {
            DataTable dt = new DataTable();
            string consulta = "";
            if (ChTodo.Checked == true)
            {
                consulta = "select * from vPagos";
                ChTodo.Checked = false;
            }
            else if (ChTodo.Checked == false)
            {
                consulta = $"select * from vPagos where idPaciente = '{cbidFechaFact.SelectedValue.ToString()}'";

            }
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();

            this.rVPagos.LocalReport.DataSources.Clear();
            this.rVPagos.LocalReport.ReportEmbeddedResource = "Hospital.INFORMES.RPagos.rdlc";
            ReportDataSource r = new ReportDataSource("dtsPagos", dt);
            this.rVPagos.LocalReport.DataSources.Add(r);
            this.rVPagos.RefreshReport();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargareporte();
        }

        private void frmR_Pagos_Load(object sender, EventArgs e)
        {
            cargarfechafact();
        }
    }
}
