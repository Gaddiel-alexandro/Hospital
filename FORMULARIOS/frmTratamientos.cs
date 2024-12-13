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

namespace Hospital.FORMULARIOS
{
    public partial class frmTratamientos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmTratamientos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {
            txtDescripcion.Clear();
            txtDuracion.Clear();
        }

        void cargarcb()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from estado_t";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidEstado.DisplayMember = "estado";
            cbidEstado.ValueMember = "id";
            cbidEstado.DataSource = dt;
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Tratamientos where id = {id}";
            con.Open();
            SqlCommand cmd = new SqlCommand(cadena, con);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                a = true;
            }
            else
            {
                a = false;
            }
            con.Close();
            return a;

        }



        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CLASES.Tratamientos x = new CLASES.Tratamientos();
            x.id = int.Parse(txtid.Text);
            x.Descripcion = txtDescripcion.Text;
            x.Duracion = int.Parse(txtDuracion.Text);
            x.idEstado = int.Parse(cbidEstado.SelectedValue.ToString());
            if (encontro() == true)
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                //agregacion de valores
                MessageBox.Show(x.guardar());
            }
            limpiar();
        }

        void obtener()
        {
            string consulta = $"select * from Tratamientos where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtDescripcion.Text = reader["Descripcion"].ToString();
                txtDuracion.Text = reader["Duracion"].ToString();
                cbidEstado.SelectedValue = int.Parse(reader["id_estado"].ToString());
            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun lado");
            }
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "0" || txtid.Text == "")
            {
                MessageBox.Show("ID no valido. ");
            }
            else
            {
                obtener();
            }
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.Tratamientos x = new CLASES.Tratamientos();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void frmTratamientos_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Tratamientos").ToString();

            cargarcb();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaTratamientos x = new BUSQUEDAS.frmBusquedaTratamientos();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgTratamientos.SelectedRows[0].Cells["id"].Value.ToString();
                txtDescripcion.Text = x.dgTratamientos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
