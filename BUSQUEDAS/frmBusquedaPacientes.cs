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
    public partial class frmBusquedaPacientes : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaPacientes()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargardg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Pacientes where Nombre LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgPacientes.DataSource = dt;
            con.Close();
            try
            {
                dgPacientes.Rows[0].Selected = true;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgPacientes.CurrentRow.Index;
            dgPacientes.Rows[i].Selected = true;
        }

        private void frmBusquedaPacientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgPacientes.Rows[0].Selected = true;

            }
            catch
            {

            }
        }
    }
}
