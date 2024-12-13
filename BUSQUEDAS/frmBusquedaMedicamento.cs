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
    public partial class frmBusquedaMedicamento : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaMedicamento()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargandg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Medicamentos where Nombre LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgMedicamentos.DataSource = dt;
            con.Close();
            try
            {
                dgMedicamentos.Rows[0].Selected = true;
            }
            catch
            {

            }
        }
            private void txtFiltro_TextChanged(object sender, EventArgs e)
            {
                cargandg();
            }

        private void frmBusquedaMedicamento_Load(object sender, EventArgs e)
        {
            try
            {
                dgMedicamentos.Rows[0].Selected = true;

            }
            catch
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargandg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void dgMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgMedicamentos.CurrentRow.Index;
            dgMedicamentos.Rows[i].Selected = true;
        }
    }
    }

