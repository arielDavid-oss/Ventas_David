using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ventas_David
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            // Establecer el formulario principal como contenedor  MDI 
            this.IsMdiContainer = true;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciamos el formulario para usarlo 
            FrmAltasProductos f = new FrmAltasProductos();
            // le indicamos que correra dentro del contenedor 
            //Le indicamos que corra
            f.MdiParent = this;
            f.Show();
        }

        private void descontinuarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescontinuarProd f = new frmDescontinuarProd();
            f.MdiParent = this;
            f.Show();

        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProducto frm = new FrmActualizarProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar eli = new frmEliminar();
            eli.MdiParent = this;
            eli.Show();
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryProductos f = new FrmQueryProductos();
            f.MdiParent = this;
            f.Show();
        }

        private void consultaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frm = new frmConsultaClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void descontinuarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDescontinuarClientes frm = new frmDescontinuarClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarCliente frm = new frmEliminarCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actualizarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarClientes frm = new frmActualizarClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltasClientes frm = new AltasClientes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
