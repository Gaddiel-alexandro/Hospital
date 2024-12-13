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

namespace Hospital.BUSQUEDAS
{
    public partial class frmBusquedaReceta : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaReceta()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargandg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Receta where id_Medicamento LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgReceta.DataSource = dt;
            con.Close();
            try
            {
                dgReceta.Rows[0].Selected = true;
            }
            catch
            {

            }
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargandg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargandg();
        }

        private void frmBusquedaReceta_Load(object sender, EventArgs e)
        {
            try
            {
                dgReceta.Rows[0].Selected = true;

            }
            catch
            {

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgReceta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgReceta.CurrentRow.Index;
            dgReceta.Rows[i].Selected = true;
        }

        void cargarrdetalle()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from vReceta where Nombre LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgDetalleR.DataSource = dt;
            con.Close();
            try
            {
                dgDetalleR.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargarrdetalle();
        }
    }
}
