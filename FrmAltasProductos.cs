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
    public partial class FrmAltasProductos : Form
    {
        public FrmAltasProductos()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";
            decimal precio = nudPre.Value;
            try
            {
                cadenaSQL = "INSERT INTO PRODUCTOS(ID_FAB,ID_PRODUCTO,DESCRIPCION,PRECIO,EXISTENCIAS) Values";
                cadenaSQL = cadenaSQL + "('" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDes.Text + "','" + precio.ToString("0.00") + "','" + nudExi.Value + "');";
                objeto.ejecutar(cadenaSQL);
                MessageBox.Show("Producto guardado correctamente");

                txtIDFab.Text = "";
                txtIDProd.Text = "";
                txtDes.Text = "";
                nudPre.Value = 0;
                nudExi.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL:" + ex.Message + cadenaSQL);
            }
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";

            cadenaSQL = "AltasProductos '" + txtIDFab.Text + "','" + txtIDProd.Text + "','" + txtDes.Text + "'," + nudPre.Value + "," + nudExi.Value + "";

            try //Si la ejecuci�n se lleva a cabo correctamente
            {
                objeto.ejecutar(cadenaSQL);

                // Se despliega el mensaje para indicar que el registro del producto se guard� correctamente
                MessageBox.Show("Producto guardado correctamente");
            }
            catch (Exception ex)
            {

                // Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL:" + ex.Message + cadenaSQL);

                // Se limpian los objetos
                txtIDFab.Text = "";
                txtIDProd.Text = "";
                txtDes.Text = " ";
                nudPre.Value = 0;
                nudExi.Value = 0;
            }
        }

        private void FrmAltasProductos_Load(object sender, EventArgs e)
        {

        }

        private void nudPre_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}