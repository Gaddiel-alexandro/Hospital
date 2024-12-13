﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.BUSQUEDAS
{
    public partial class frmBusquedaDetalleCita : Form
    {
        CLASES.ConexionSQL x = new CLASES.ConexionSQL();
        SqlConnection con = new SqlConnection();
        public frmBusquedaDetalleCita()
        {
            InitializeComponent();
            con.ConnectionString = x.Conexion;
        }

        void cargandg()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand($"select * from Detalle_Citas where id_Cita LIKE '%{txtFiltro.Text}%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dgDetalleCitas.DataSource = dt;
            con.Close();
            try
            {
                dgDetalleCitas.Rows[0].Selected = true;
            }
            catch
            {

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargandg();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargandg();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmBusquedaDetalleCita_Load(object sender, EventArgs e)
        {
            try
            {
                dgDetalleCitas.Rows[0].Selected = true;

            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void dgDetalleCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgDetalleCitas.CurrentRow.Index;
            dgDetalleCitas.Rows[i].Selected = true;
        }
    }
}
