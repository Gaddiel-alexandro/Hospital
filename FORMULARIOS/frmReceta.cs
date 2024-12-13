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
    public partial class frmReceta : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmReceta()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarpaciente()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Pacientes";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidPaciente.DisplayMember = "Nombre";
            cbidPaciente.ValueMember = "id";
            cbidPaciente.DataSource = dt;
        }

        void cargarmedicamento()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Medicamentos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidMedicamento.DisplayMember = "Nombre";
            cbidMedicamento.ValueMember = "id";
            cbidMedicamento.DataSource = dt;
        }

        void cargarfactura()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Facturas";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidFactura.DisplayMember = "Fecha_Factura";
            cbidFactura.ValueMember = "id";
            cbidFactura.DataSource = dt;
        }

        void cargardecita()
        {
            DataTable dt = new DataTable();
            string consulta = $"select * from Tratamientos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidCita.DisplayMember = "Descripcion";
            cbidCita.ValueMember = "id";
            cbidCita.DataSource = dt;
        }

        void limpiar()
        {
            txtid.Clear();
        }

        public bool encontro()

        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Receta where id = {id}";
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



        private void button1_Click(object sender, EventArgs e)
        {
            INFORMES.frmR_Receta p = new INFORMES.frmR_Receta();
            p.ShowDialog();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CLASES.Receta x = new CLASES.Receta();
            x.id = int.Parse(txtid.Text);
            x.medicamento = int.Parse(cbidMedicamento.SelectedValue.ToString());
            x.paciente = int.Parse(cbidPaciente.SelectedValue.ToString());
            x.factura = int.Parse(cbidFactura.SelectedValue.ToString());
            x.cita = int.Parse(cbidCita.SelectedValue.ToString());
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

        private void frmReceta_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Receta").ToString();

            cargardecita();
            cargarfactura();
            cargarmedicamento();
            cargarpaciente();
        }

        private void tsLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        void obtener()
        {
            string consulta = $"select * from Receta where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtid.Text = reader["id"].ToString();
                cbidMedicamento.SelectedValue = int.Parse(reader["id_Medicamento"].ToString());
                cbidPaciente.SelectedValue = int.Parse(reader["id_Paciente"].ToString());
                cbidFactura.SelectedValue = int.Parse(reader["id_Factura"].ToString());
                cbidCita.SelectedValue = int.Parse(reader["id_DetalleC"].ToString());
            }

            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun lado");
            }
            con.Close();
        }
        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.Receta x = new CLASES.Receta();
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
            BUSQUEDAS.frmBusquedaReceta x = new BUSQUEDAS.frmBusquedaReceta();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgReceta.SelectedRows[0].Cells["id"].Value.ToString();
                
            }
        }
    }
}
