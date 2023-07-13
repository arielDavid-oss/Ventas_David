using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ventas_David
{
    public partial class frmDescontinuarProd : Form
    {
        public frmDescontinuarProd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();

                cadenaSQL = "SELECT DISTINCT ID_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";
                // Limpia los valores de los labels
                lblDescripcion.Text = "";
                lblPrecio.Text = "";
                lblCantidad.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";

            try
            {
                BaseSQL objeto = new BaseSQL();
                if (cmbIDFab.SelectedValue != null)
                {
                    //Si la ejecución se lleva a cabo correctamente
                    // Verifica si se ha seleccionado un elemento en el ComboBox cmbIDFab 
                    // Obtiene el ID_Fab seleccionado
                    string idFab = (string)cmbIDFab.SelectedValue;
                    // Llena el comboBox cmbIDProd por medio de la clase leerDatos.
                    cadenaSQL = "SELECT Id_Producto FROM Productos WHERE Id_Fab = '" + idFab + "' order by Id_Fab";

                    this.cmbIDProd.DataSource = objeto.LeerDatos(cadenaSQL);
                    // Despliega los valores en el comboBox
                    cmbIDProd.DisplayMember = "Id_Producto";
                    cmbIDProd.ValueMember = "Id_Producto";
                }
                else
                {
                    // Si no se ha seleccionado ningún elemento, realiza alguna acción apropiada // por ejemplo, puedes limpiar el ComboBox cmbIDProd o mostrar un mensaje al usuario.
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();

                if (cmbIDFab.SelectedValue != null && cmbIDProd.SelectedValue != null)
                {
                    cadenaSQL = "SELECT Descripcion, Precio, Existencias, StatusProd FROM Productos WHERE Id_Fab = '" + cmbIDFab.SelectedValue + "' AND Id_Producto = '" + cmbIDProd.SelectedValue + "'";
                    SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);
                    if (dr.Read())
                    {
                        lblDescripcion.Text = dr["Descripcion"].ToString();
                        lblPrecio.Text = dr["Precio"].ToString();
                        lblCantidad.Text = dr["Existencias"].ToString();

                        if (Convert.ToBoolean(dr["StatusProd"]))
                        {
                            lblStatus.Text = "Activo";
                            lblStatus.ForeColor = Color.Green; // Color verde
                        }
                        else
                        {
                            lblStatus.Text = "Descontinuado";
                            lblStatus.ForeColor = Color.Red; // Color rojo
                        }

                        lblStatus.Font = new Font(lblStatus.Font.FontFamily, 14f, FontStyle.Bold); // Establecer una fuente más grande y en negrita
                    }
                }
                else
                {
                    // Limpiar los labels si no hay selecciones válidas en los ComboBox
                    lblDescripcion.Text = "";
                    lblPrecio.Text = "";
                    lblCantidad.Text = "";
                    lblStatus.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + " " + cadenaSQL);
            }
        }

        private void btnDescontinuar_Click(object sender, EventArgs e)
        {
            BaseSQL objeto = new BaseSQL();
            string cadenaSQL = "";

            cadenaSQL = "EXEC [dbo].[DescProd] '" + cmbIDFab.SelectedValue + "','" + cmbIDProd.SelectedValue + "'";

            try
            { //Si la ejecución se lleva a cabo correctamente
                objeto.ejecutar(cadenaSQL);
                // Se despliega el mensaje para indicar que el registro del producto se guardó correctamente
                MessageBox.Show("Producto DESCONTINUADO");
            }
            catch (Exception ex)
            {
                // Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL:" + ex.Message + cadenaSQL);
            }
        }
    }
}


