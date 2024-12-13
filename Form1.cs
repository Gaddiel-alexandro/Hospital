using Hospital.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mEDICAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicamentos w = new frmMedicamentos();
            w.ShowDialog();
        }

        private void tsMedico_Click(object sender, EventArgs e)
        {
            frmMedicos w = new frmMedicos();
            w.ShowDialog();

        }

        private void cITASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCitas p = new frmCitas();
            p.ShowDialog();

        }

        private void tsPaciente_Click(object sender, EventArgs e)
        {
            frmPacientes p = new frmPacientes();
            p.ShowDialog();
        }

        private void tRATAMIENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTratamientos w = new frmTratamientos();
            w.ShowDialog();
        }

        private void dETALLECITAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleCitas w = new frmDetalleCitas();
            w.ShowDialog();
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas w = new frmFacturas();
            w.ShowDialog();
        }

        private void pAGOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagos w = new frmPagos();
            w.ShowDialog();

        }

        private void tsReceta_Click(object sender, EventArgs e)
        {
            frmReceta w = new frmReceta();
            w.ShowDialog();
        }

        private void dETALLEFACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleFacturas w = new frmDetalleFacturas();
            w.ShowDialog();

        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamentos w = new frmDepartamentos();
            w.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMedicamentos w = new frmMedicamentos();
            w.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDepartamentos p = new frmDepartamentos();
            p.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCitas w = new frmCitas();
            w.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmTratamientos w = new frmTratamientos();
            w.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmFacturas w = new frmFacturas();
            w.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmPagos w = new frmPagos();
            w.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMedicos w = new frmMedicos();
            w.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmReceta p = new frmReceta();
            p.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmPacientes w = new frmPacientes();
            w.ShowDialog();
        }
    }
}
