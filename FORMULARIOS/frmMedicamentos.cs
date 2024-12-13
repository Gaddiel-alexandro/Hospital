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
    public partial class frmMedicamentos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmMedicamentos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {
            txtid.Clear();
            txtNombre.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Medicamentos where id = {id}";
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
            CLASES.Medicamentos x = new CLASES.Medicamentos();
            x.id = int.Parse(txtid.Text);
            x.Nombre = txtNombre.Text;
            x.Tipo = txtTipo.Text;
            x.Cantidad = int.Parse(txtCantidad.Text);
            x.Precio = int.Parse(txtPrecio.Text);
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
            string consulta = $"select * from Medicamentos where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtTipo.Text = reader["Tipo"].ToString();
                txtCantidad.Text = reader["Cantidad"].ToString();
                txtPrecio.Text = reader["Precio"].ToString();
            }

            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun lado");
            }
            con.Close();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaMedicamento x = new BUSQUEDAS.frmBusquedaMedicamento();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgMedicamentos.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgMedicamentos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
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
            CLASES.Medicamentos x = new CLASES.Medicamentos();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Medicamentos").ToString();
        }
    }
}
