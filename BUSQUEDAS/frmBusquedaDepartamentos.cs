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
    public partial class frmBusquedaDepartamentos : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaDepartamentos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargardg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Departamentos where Nombre LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgDepartamentos.DataSource = dt;
            con.Close();
            try
            {
                dgDepartamentos.Rows[0].Selected = true;
            }
            catch
            {

            }
        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargardg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargardg();
        }

        private void frmBusquedaDepartamentos_Load(object sender, EventArgs e)
        {
            try
            {
                dgDepartamentos.Rows[0].Selected = true;

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

        private void dgDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgDepartamentos.CurrentRow.Index;
            dgDepartamentos.Rows[i].Selected = true;
        }
    }
}
