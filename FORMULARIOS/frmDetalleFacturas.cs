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
    public partial class frmDetalleFacturas : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmDetalleFacturas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarfact()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Facturas";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidFactura.DisplayMember = "Nombre";
            cbidFactura.ValueMember = "id";
            cbidFactura.DataSource = dt;
        }

        void cargartrat()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Tratamientos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidTratamiento.DisplayMember = "Duracion";
            cbidTratamiento.ValueMember = "id";
            cbidTratamiento.DataSource = dt;

        }

        public bool encontro()

        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Detalle_Factura where id = {id}";
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
            CLASES.DetalleFactura x = new CLASES.DetalleFactura();
            x.id = int.Parse(txtid.Text);
            x.idfactura = int.Parse(cbidFactura.SelectedValue.ToString());
            x.idtratamientos = int.Parse(cbidTratamiento.SelectedValue.ToString());
            x.cantidad = int.Parse(txtCantidad.Text);
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

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            CLASES.DetalleFactura x = new CLASES.DetalleFactura();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
        }

        void obtener()
        {
            string consulta = $"select * from Detalle_Factura where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtCantidad.Text = reader["cantidad"].ToString();
                cbidFactura.SelectedValue = int.Parse(reader["id_Factura"].ToString());
                cbidTratamiento.SelectedValue = int.Parse(reader["id_Tratamientos"].ToString());
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

        private void frmDetalleFacturas_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Detalle_Factura").ToString();

            cargarfact();
            cargartrat();
        }
    }
    
}
