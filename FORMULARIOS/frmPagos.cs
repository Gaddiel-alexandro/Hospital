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
    public partial class frmPagos : Form
    {
        ConexionSQL x = new ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmPagos()
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
            cbidFactura.DisplayMember = "Fecha_Factura";
            cbidFactura.ValueMember = "id";
            cbidFactura.DataSource = dt;
        }

        void limpiar()
        {
            txtMonto.Clear();
            txtid.Clear();
        }

        public bool encontro()

        {
            bool a = false;
            int id = int.Parse(txtid.Text);
            string cadena = $"select * from Pagos where id = {id}";
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
            CLASES.Pagos x = new CLASES.Pagos();
            x.id = int.Parse(txtid.Text);
            x.idfactura = int.Parse(cbidFactura.SelectedValue.ToString());
            x.fechapago = dtpFechaPago.Value.ToString("yyyy/MM/dd");
            x.monto = int.Parse(txtMonto.Text);
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
            string consulta = $"select * from Pagos where id = {txtid.Text}";
            con.Open();
            SqlCommand cmd = new SqlCommand(consulta, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMonto.Text = reader["monto"].ToString();
                cbidFactura.SelectedValue = int.Parse(reader["id_Factura"].ToString());

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
            CLASES.Pagos x = new CLASES.Pagos();
            x.id = int.Parse(txtid.Text);
            MessageBox.Show(x.eliminar());
            limpiar();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            CLASES.Herramientas P = new Herramientas();
            txtid.Text = P.consecutuvivo("id", "Pagos").ToString();

            cargarfact();
        }

        private void tsBuscar_Click(object sender, EventArgs e)
        {
            BUSQUEDAS.frmBusquedaPagos x = new BUSQUEDAS.frmBusquedaPagos();
            x.ShowDialog();
            if (x.DialogResult == DialogResult.OK)
            {
                txtid.Text = x.dgPagos.SelectedRows[0].Cells["id"].Value.ToString();
                txtMonto.Text = x.dgPagos.SelectedRows[0].Cells["monto"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INFORMES.frmR_Pagos w = new INFORMES.frmR_Pagos();
            w.ShowDialog();
        }
    }
}
