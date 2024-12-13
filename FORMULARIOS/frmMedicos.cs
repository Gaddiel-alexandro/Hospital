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
    public partial class frmMedicos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmMedicos()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargardep()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Departamentos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbid_Departamento.DisplayMember = "Nombre";
            cbid_Departamento.ValueMember = "id";
            cbid_Departamento.DataSource = dt;
        }

        void  limpiar()
        {
            txtNombre.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Medico where id = {id}";
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
            CLASES.Medicos x = new CLASES.Medicos();
            x.id = int.Parse(txtid.Text);
            x.Nombre = txtNombre.Text;
            x.Especialidad = txtEspecialidad.Text;
            x.Uni = txtUniversidad.Text;
            x.Telefono = txtTelefono.Text;
            x.idDepartamento = int.Parse(cbid_Departamento.SelectedValue.ToString());
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
            string consulta = $"select * from Medico where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtEspecialidad.Text = reader["Especialidad"].ToString();
                txtTelefono.Text = reader["Telefono"].ToString();
                txtUniversidad.Text = reader["Egre_Uni"].ToString();
            }

            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun lado");
            }
            con.Close();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.Medicos x = new CLASES.Medicos();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
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

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaMedicos x = new BUSQUEDAS.frmBusquedaMedicos();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgMedicos.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgMedicos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtEspecialidad.Text = x.dgMedicos.SelectedRows[0].Cells["Especialidad"].ToString();
                txtTelefono.Text = x.dgMedicos.SelectedRows[0].Cells["Telefono"].ToString();
                txtUniversidad.Text = x.dgMedicos.SelectedRows[0].Cells["Egre_Uni"].ToString();
            }
        }

        private void frmMedicos_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Medico").ToString();

            cargardep();
        }
    }
}
