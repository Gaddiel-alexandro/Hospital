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
    public partial class frmDetalleCitas : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmDetalleCitas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarcbcita()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Citas";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidCita.DisplayMember = "Horario";
            cbidCita.ValueMember = "id";
            cbidCita.DataSource = dt;
        }

        void cargarcbtrata()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Tratamientos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidTratamiento.DisplayMember = "Descripcion";
            cbidTratamiento.ValueMember = "id";
            cbidTratamiento.DataSource = dt;
        }


        void cargarcbesta()
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
            string cadena = $"select * from Detalle_Citas where id = {id}";
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
            CLASES.DetalleCita x = new CLASES.DetalleCita();
            x.id = int.Parse(txtid.Text);
            x.cita = int.Parse(cbidCita.SelectedValue.ToString());
            x.tratamiento = int.Parse(cbidTratamiento.SelectedValue.ToString());
            x.estado = int.Parse(cbidEstado.SelectedValue.ToString());
            if (encontro() == true)
            {
                MessageBox.Show(x.actualizar());
            }
            else
            {
                //agregacion de valores
                MessageBox.Show(x.guardar());
            }
        }

        void obtener()
        {
            string consulta = $"select * from Detalle_Citas where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtid.Text = reader["id"].ToString();
                cbidCita.SelectedValue = int.Parse(reader["id_Cita"].ToString());
                cbidTratamiento.SelectedValue = int.Parse(reader["id_Tratamiento"].ToString());
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

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.DetalleCita x = new CLASES.DetalleCita();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
        }

        private void frmDetalleCitas_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Detalle_Citas").ToString();

            cargarcbcita();
            cargarcbesta();
            cargarcbtrata();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaDetalleCita x = new BUSQUEDAS.frmBusquedaDetalleCita();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgDetalleCitas.SelectedRows[0].Cells["id"].Value.ToString();
                //txtHorario.Text = x.dgDetalleCitas.SelectedRows[0].Cells["Horario"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INFORMES.frmR_Citas n = new INFORMES.frmR_Citas();
            n.ShowDialog();
        }
    }
}
