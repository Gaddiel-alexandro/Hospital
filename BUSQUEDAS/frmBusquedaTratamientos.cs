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
    public partial class frmBusquedaTratamientos : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaTratamientos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargandg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Tratamientos where Descripcion LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgTratamientos.DataSource = dt;
            con.Close();
            try
            {
                dgTratamientos.Rows[0].Selected = true;
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

        private void frmBusquedaTratamientos_Load(object sender, EventArgs e)
        {
            try
            {
                dgTratamientos.Rows[0].Selected = true;

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

        private void dgTratamientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgTratamientos.CurrentRow.Index;
            dgTratamientos.Rows[i].Selected = true;
        }
    }
}
