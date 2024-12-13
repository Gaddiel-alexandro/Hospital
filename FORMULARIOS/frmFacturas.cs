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
    public partial class frmFacturas : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmFacturas()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargarpc()
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

        void cargarprodc()
        {
            DataTable dt = new DataTable();
            string consulta = "select * from Medicamentos";
            SqlDataAdapter da = new SqlDataAdapter(consulta, con);
            con.Open();
            da.Fill(dt);
            con.Close();
            cbidProducto.DisplayMember = "Nombre";
            cbidProducto.ValueMember = "id";
            cbidProducto.DataSource = dt;
        }

        void limpiar()
        {
            txtDescripcion.Clear();
            txtTotal.Clear();
            txtid.Clear();
        }

        public bool encontro()

        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Facturas where id = {id}";
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



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            CLASES.Facturas p = new CLASES.Facturas();
            p.id = int.Parse(txtid.Text);
            p.idpaciente = int.Parse(cbidPaciente.SelectedValue.ToString());
            p.fechafactura = dtpFechaFactura.Value.ToString("yyyy/MM/dd");
            p.total = int.Parse(txtTotal.Text);
            p.idproducto = int.Parse(cbidProducto.SelectedValue.ToString());
            p.descripcion = txtDescripcion.Text;
            p.cantidad = int.Parse(txtCantidad.Text);
            if (encontro() == true)
            {
                MessageBox.Show(p.actualizar());
            }
            else
            {
                //agregacion de valores
                MessageBox.Show(p.guardar());
            }
            limpiar();
        }

        void obtener()
        {
            string consulta = $"select * from Facturas where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtDescripcion.Text = reader["Descripcion"].ToString();
                cbidPaciente.SelectedValue = int.Parse(reader["id_Pacientes"].ToString());
                cbidProducto.SelectedValue = int.Parse(reader["idProducto"].ToString());
                txtTotal.Text = reader["total"].ToString();
                txtDescripcion.Text = reader["Descripcion"].ToString();
                txtCantidad.Text = reader["Cantidad"].ToString();

            }
            else
            {
                MessageBox.Show("El ID ingresado no le corresponde a ningun lado");
            }
            con.Close();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Facturas").ToString();

            cargarpc();
            cargarprodc();
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
            CLASES.Facturas x = new CLASES.Facturas();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaFactura x = new BUSQUEDAS.frmBusquedaFactura();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgFacturas.SelectedRows[0].Cells["id"].Value.ToString();
                txtDescripcion.Text = x.dgFacturas.SelectedRows[0].Cells["Desccripcion"].Value.ToString();
            }
        }

        decimal obtenerprecio()
        {
            decimal precio = 0;
            string idmedicamento = cbidProducto.SelectedValue.ToString();

            string consulta = $"select Precio from Medicamentos where  id = {idmedicamento}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                precio = (decimal)reader["Precio"];
            }
            con.Close();
            return precio;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            txtTotal.Text = (int.Parse(txtCantidad.Text) * obtenerprecio()).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDetalleFacturas n = new frmDetalleFacturas();
            n.ShowDialog();

        }
    }
}