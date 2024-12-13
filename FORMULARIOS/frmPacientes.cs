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
    public partial class frmPacientes : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmPacientes()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }
        void cargarGenero()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Genero";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidGenero.DisplayMember = "Nombre";
            cbidGenero.ValueMember = "id";
            cbidGenero.DataSource = dt;
        }

        void cargarEnfermedad()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Enfermedad";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidEnfermedad.DisplayMember = "Nombre";
            cbidEnfermedad.ValueMember = "id";
            cbidEnfermedad.DataSource = dt;
        }

        void cargarMedico()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Medico";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidMedico.DisplayMember = "Nombre";
            cbidMedico.ValueMember = "id";
            cbidMedico.DataSource = dt;
        }

        void cargarCita()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Citas";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidCitaM.DisplayMember = "Fecha";
            cbidCitaM.ValueMember = "id";
            cbidCitaM.DataSource = dt;
        }

        void cargarMedi()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Medicamentos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidMedicamento.DisplayMember = "Nombre";
            cbidMedicamento.ValueMember = "id";
            cbidMedicamento.DataSource = dt;
        }

        void limpiar()
        {
            txtNombre.Clear();
            txtA_Paterno.Clear();
            txtA_Materno.Clear();
            txtEdad.Clear();
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Pacientes where id = {id}";
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
            CLASES.Pacientes x = new CLASES.Pacientes();
            x.id = int.Parse(txtid.Text);
            x.Nombre = txtNombre.Text;
            x.A_Paterno = txtA_Paterno.Text;
            x.A_Materno = txtA_Materno.Text;
            x.FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy/MM/dd");
            x.edad = int.Parse(txtEdad.Text);
            x.idGenero = int.Parse(cbidGenero.SelectedValue.ToString());
            x.idEnfermedad = int.Parse(cbidEnfermedad.SelectedValue.ToString());
            x.idMedico = int.Parse(cbidMedico.SelectedValue.ToString());
            x.idCitaM = int.Parse(cbidCitaM.SelectedValue.ToString());
            x.idMedicamento = int.Parse(cbidMedicamento.SelectedValue.ToString());
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
            string consulta = $"select * from Pacientes where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombre"].ToString();
                txtA_Paterno.Text = reader["A_Paterno"].ToString();
                txtA_Materno.Text = reader["A_Materno"].ToString();

                txtEdad.Text = reader["Edad"].ToString();
                cbidGenero.SelectedValue = int.Parse(reader["id_Genero"].ToString());
                cbidEnfermedad.SelectedValue = int.Parse(reader["id_Enfermedad"].ToString());
                cbidMedico.SelectedValue = int.Parse(reader["id_Medico"].ToString());
                cbidCitaM.SelectedValue = int.Parse(reader["id_CitaM"].ToString());
                cbidMedicamento.SelectedValue = int.Parse(reader["id_Medicamento"].ToString());
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
            CLASES.Pacientes x = new CLASES.Pacientes();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaPacientes x = new BUSQUEDAS.frmBusquedaPacientes();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgPacientes.SelectedRows[0].Cells["id"].Value.ToString();
                txtNombre.Text = x.dgPacientes.SelectedRows[0].Cells["Nombre"].Value.ToString();
            }
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Pacientes").ToString();

            cargarGenero();
            cargarEnfermedad();
            cargarMedico();
            cargarCita();
            cargarMedi();
        }
    }
}
