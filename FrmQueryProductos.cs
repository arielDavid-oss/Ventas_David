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
    public partial class FrmQueryProductos : Form
    {
        public FrmQueryProductos()
        {
            InitializeComponent();
        }



        private void FrmQueryProductos_Load(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            //llenar el combo de Productos del Fabricante
            comFab.DataSource = objeto.LeerDatos("Select distinct Id_fab from Productos");
            comFab.DisplayMember = "Id_Fab";

            //llenar el combo de Total de Inventario por proveedor 
            cmbInvProv.DataSource = objeto.LeerDatos("Select distinct Id_fab from Productos");
            cmbInvProv.DisplayMember = "Id_Fab";

            // Agregar los operadores utilizando el método AddRange() 
            cmbOperadores.Items.AddRange(new string[] { "=", "<", "<=", ">", ">=" });

            // 0 agregar los operadores uno por uno 
            // cmbOperadores.Items.Add("=");
            // cmbOperadores.Items.Add("<");
            // cmbOperadores.Items.Add("<=");
            // cmbOperadores.Items.Add(">");
            // cmbOperadores.Items.Add(">=");

            // Establecer un valor predeterminado seleccionado
            cmbOperadores.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rbtnListaProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT id_fab, id_producto, descripcion, precio, existencias FROM Productos";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnListaProd.Checked = false;
                rbtnListaProd.Enabled = true;
            }
            else if (rbtnProdFab.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select * from Productos where id_fab='" + comFab.Text + "'";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnProdFab.Checked = false;
                rbtnProdFab.Enabled = true;
            }
            else if (rbtnProdConExi.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select * from Productos where existencias " + cmbOperadores.Text + " '" + txtProdExi.Text + "'";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnProdConExi.Checked = false;
                rbtnProdConExi.Enabled = true;
            }
            else if (rbtnTotInv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT id_fab, id_producto, descripcion, precio, existencias, precio existencias as Total FROM Productos";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnTotInv.Checked = false;
                rbtnTotInv.Enabled = true;
            }
            else if (rbtnTotInvProv.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "select id_fab, id_producto, descripcion, precio, existencias, precio*existencias as Total from Productos where id_fab = " + cmbInvProv.Text + "'";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnTotInvProv.Checked = false;
                rbtnTotInvProv.Enabled = true;
            }
            else if (rbtnEdoProd.Checked)
            {
                BaseSQL objeto = new BaseSQL();
                string cadenaSQL = "SELECT id_producto,descripcion, CASE WHEN [Status Prod]=1 THEN 'Activo' WHEN [StatusProd]=2 THEN 'Descontinuado' ELSE 'Dañado' END as Estado FROM Productos";
                objeto.LlenarGrid(cadenaSQL, dataGridView1);
                rbtnEdoProd.Checked = false;
                rbtnEdoProd.Enabled = true;
            }



        }

        private void comFab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
