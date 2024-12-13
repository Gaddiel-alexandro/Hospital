using Hospital.CLASES;
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
    public partial class frmBusquedaPagos : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaPagos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;

            
        }

        void cargandg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Pagos where monto LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgPagos.DataSource = dt;
            con.Close();
            try
            {
                dgPagos.Rows[0].Selected = true;
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

        private void frmBusquedaPagos_Load(object sender, EventArgs e)
        {
            try
            {
                dgPagos.Rows[0].Selected = true;

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

        private void dgPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgPagos.CurrentRow.Index;
            dgPagos.Rows[i].Selected = true;
        }

        private void dgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgDetalleP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void cargap()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from vPagos where MontoPago LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgDetalleP.DataSource = dt;
            con.Close();
            try
            {
                dgDetalleP.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            cargap();
        }
    }
}
