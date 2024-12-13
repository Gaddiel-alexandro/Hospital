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
    public partial class frmDepartamentos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmDepartamentos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void limpiar()
        {
            txtid.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Departamentos where id = {id}";
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
            CLASES.Departamentos x = new CLASES.Departamentos();
            x.id = int.Parse(txtid.Text);
            x.Nombre = txtNombre.Text;
            x.Descripcion = txtDescripcion.Text;
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
            string consulta = $"select * from Departamentos where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtDescripcion.Text = reader["Descripcion"].ToString();
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

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.Departamentos x = new CLASES.Departamentos();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaDepartamentos x = new BUSQUEDAS.frmBusquedaDepartamentos();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgDepartamentos.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgDepartamentos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = x.dgDepartamentos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            }
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Departamentos").ToString();
        }
    }
}
