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
    public partial class frmBusquedaCitas : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaCitas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargardg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Citas where Horario LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgCitas.DataSource = dt;
            con.Close();
            try
            {
                dgCitas.Rows[0].Selected = true;
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

        private void frmBusquedaCitas_Load(object sender, EventArgs e)
        {
            try
            {
                dgCitas.Rows[0].Selected = true;

            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgCitas.CurrentRow.Index;
            dgCitas.Rows[i].Selected = true;
        }
    }
}
