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

namespace Ventas_David
{
    public partial class FrmActualizarProducto : Form
    {
        public FrmActualizarProducto()
        {
            InitializeComponent();
        }

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            //Si la ejecución se lleva a cabo correctamente 
            try
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT ID_Fab FROM Productos";
                this.cmbIDFab.DataSource = objeto.LeerDatos(cadenaSQL);
                cmbIDFab.DisplayMember = "Id_Fab";
                cmbIDFab.ValueMember = "Id_Fab";
                // Limpia los valores de los labels 
                txtDes.Text = "";
                nudPre.Text = "";
                nudExi.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void cmbIDFab_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //Si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                // Verifica si se ha seleccionado un elemento en el ComboBox cmbIDFab 
                if (cmbIDFab.SelectedValue != null)
                {
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
                    // Si no se ha seleccionado ningún elemento, realiza alguna acción apropiada 
                    // por ejemplo, puedes limpiar el ComboBox cmbIDProd o mostrar un mensaje al usuario. 
                    cmbIDProd.DisplayMember = "Selecciona un fabricante";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbIDProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try //si la ejecución se lleva a cabo correctamente
            {
                BaseSQL objeto = new BaseSQL();
                if (cmbIDFab.SelectedValue != null)
                {
                    if (cmbIDProd.SelectedValue != null)
                    {
                        //llena el comboBox cabIDProd por medio de la clase leerDatos. 

                        cadenaSQL = "SELECT Descripcion, Precio, Existencias, StatusProd FROM Productos WHERE Id_Fab = '" + cmbIDFab.SelectedValue + "' AND Id_Producto = '" + cmbIDProd.SelectedValue + "'";

                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            txtDes.Text = dr["Descripcion"].ToString();
                            nudPre.Value = (decimal)dr["Precio"];
                            nudExi.Value = (int)dr["Existencias"];
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
                            lblStatus.Font = new Font(lblStatus.Font.FontFamily, 14f, FontStyle.Bold); // Establecer una Fuente más grande y en negrita
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra el error en el mensaje para ver el error
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message + "" + cadenaSQL);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIDFab.SelectedValue != null && cmbIDProd.SelectedValue != null)
                {
                    BaseSQL objeto = new BaseSQL();
                    string idFab = cmbIDFab.SelectedValue.ToString();
                    string idProd = cmbIDProd.SelectedValue.ToString();
                    string descripcion = txtDes.Text;
                    decimal precio = nudPre.Value;
                    int existencias = (int)nudExi.Value;

                    string cadenaSQL = "exec ActualizarProductos '" + idFab + "','" + idProd + "','" + descripcion + "'," + precio + "," + existencias;
                    objeto.ejecutar(cadenaSQL);
                    MessageBox.Show("Producto actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Selecciona un fabricante y un producto válidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message);
            }

        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
