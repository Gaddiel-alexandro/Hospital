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
    public partial class frmCitas : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmCitas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarmed()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Medico";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidMedico.DisplayMember = "Nombre";
            cbidMedico.ValueMember = "id";
            cbidMedico.DataSource = dt;
        }

        void cargardep()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Departamentos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidDepartamento.DisplayMember = "Nombre";
            cbidDepartamento.ValueMember = "id";
            cbidDepartamento.DataSource = dt;
        }

        void limpiar()
        {
            txtHorario.Clear();
            txtid.Clear();
        }

        public bool encontro()
        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Citas where id = {id}";
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
            CLASES.Cita x = new CLASES.Cita();
            x.id = int.Parse(txtid.Text);
            x.Fecha = dtpFecha.Value.ToString("yyyy/MM/dd");
            x.Horario = txtHorario.Text;
            x.idMedico = int.Parse(cbidMedico.SelectedValue.ToString());
            x.idDepartamento = int.Parse(cbidDepartamento.SelectedValue.ToString());
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
            string consulta = $"select * from Citas where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtHorario.Text = reader["Horario"].ToString();
                cbidMedico.SelectedValue = int.Parse(reader["id_Medico"].ToString());
                cbidDepartamento.SelectedValue = int.Parse(reader["id_Dep"].ToString());
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
            CLASES.Cita x = new CLASES.Cita();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Citas").ToString();

            cargarmed();
            cargardep();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaCitas x = new BUSQUEDAS.frmBusquedaCitas();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgCitas.SelectedRows[0].Cells["id"].Value.ToString();
                txtHorario.Text = x.dgCitas.SelectedRows[0].Cells["Horario"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleCitas w = new frmDetalleCitas();
            w.ShowDialog();
        }
    }
}
