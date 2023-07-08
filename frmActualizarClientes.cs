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
    public partial class frmActualizarClientes : Form
    {
        public frmActualizarClientes()
        {
            InitializeComponent();
        }

        private void frmActualizarClientes_Load(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                cadenaSQL = "SELECT DISTINCT Num_Clie FROM Clientes";
                BindingSource bindingSource = objeto.LeerDatos(cadenaSQL);
                comNumCli.DataSource = bindingSource;
                comNumCli.DisplayMember = "Num_Clie";
                comNumCli.ValueMember = "Num_Clie";
                txtEmpresa.Text = "";
                txtNumRep.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private void comNumCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();
                if (comNumCli.SelectedValue != null)
                {
                    if (comNumCli.SelectedValue is int numcliente)
                    {
                        cadenaSQL = "SELECT Num_Rep FROM Clientes WHERE Num_Clie = " + numcliente + " ORDER BY Num_Rep";
                        BindingSource bindingSource = objeto.LeerDatos(cadenaSQL);
                        txtNumRep.DataSource = bindingSource;
                        txtNumRep.DisplayMember = "Num_Rep";
                        txtNumRep.ValueMember = "Num_Rep";
                    }
                }
                else
                {
                    txtNumRep.DataSource = null;
                    txtNumRep.DisplayMember = "Selecciona un Representante";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message);
            }
        }
        private void txtNumRep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaSQL = "";
            try
            {
                BaseSQL objeto = new BaseSQL();

                if (comNumCli.SelectedValue != null && txtNumRep.SelectedValue != null)
                {
                    if (comNumCli.SelectedValue is int numcliente && txtNumRep.SelectedValue is int numrep)
                    {
                        cadenaSQL = "SELECT Empresa, Num_Rep, Lim_Cred, StatusClie FROM Clientes WHERE Num_Clie = " + numcliente + " AND Num_Rep = " + numrep;
                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            txtEmpresa.Text = dr["Empresa"].ToString();
                            numLimiCre.Value = (decimal)dr["Lim_Cred"];
                            if (Convert.ToBoolean(dr["StatusClie"]))
                            {
                                StatusCli.Text = "Activo";
                                StatusCli.ForeColor = Color.Green;
                            }
                            else
                            {
                                StatusCli.Text = "Descontinuado";
                                StatusCli.ForeColor = Color.Red;
                            }
                            StatusCli.Font = new Font(StatusCli.Font.FontFamily, 14f, FontStyle.Bold);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comNumCli.SelectedValue is int numcliente && txtNumRep.SelectedValue is int numrep)
                {
                    
                    
                        SqlCommand command = new SqlCommand("DesaClie");
                        command.CommandType = CommandType.StoredProcedure;

                        // Agrega los parámetros necesarios
                        command.Parameters.AddWithValue("@Num_Cle", numcliente);
                        command.Parameters.AddWithValue("@Num_Rep", numrep);
                        command.Parameters.AddWithValue("@Empresa", txtEmpresa.Text);
                        //command.Parameters.AddWithValue("@Estatus", Convert.ToBoolean(StatusCli.Text == "Activo"));
                        command.Parameters.AddWithValue("@Lim_Cred", numLimiCre.Value);
                       
                        command.ExecuteNonQuery();

                        // Consulta los datos actualizados
                        string cadenaSQL = "SELECT * FROM Clientes WHERE Num_Clie = " + numcliente + " AND Num_Rep = " + numrep;
                        BaseSQL objeto = new BaseSQL();
                        SqlDataReader dr = objeto.ConsultaSQL(cadenaSQL);

                        if (dr.Read())
                        {
                            txtEmpresa.Text = dr["Empresa"].ToString();
                            numLimiCre.Value = (decimal)dr["Lim_Cred"];
                            if (Convert.ToBoolean(dr["StatusClie"]))
                            {
                                StatusCli.Text = "Activo";
                                StatusCli.ForeColor = Color.Green;
                            }
                            else
                            {
                                StatusCli.Text = "Descontinuado";
                                StatusCli.ForeColor = Color.Red;
                            }
                            StatusCli.Font = new Font(StatusCli.Font.FontFamily, 14f, FontStyle.Bold);
                        }

                        MessageBox.Show("Cliente Actualizado");
                    
                }
                else
                {
                    MessageBox.Show("Selecciona un cliente y un representante válidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta SQL: " + ex.Message);
            }
        }
    }
}
