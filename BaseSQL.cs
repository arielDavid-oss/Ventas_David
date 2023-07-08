using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ventas_David
{
    class BaseSQL
    {
        private SqlConnection conn = new SqlConnection();

        public BaseSQL()
        {
            conectar();
        }

        void conectar()
        {
          
                conn.ConnectionString = "Data Source=EQUIPO-DAVED;Initial Catalog=Empresa_ArielHernandez;User ID=ArielHernandez;Password=D4v1dh3r1;Persist Security Info=True;";

            // Si el estado de la conexión de SQL Server está cerrado, se abre
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                //abre la conexión con el servidor SQL
                conn.Open();
            }
        }

        public void ejecutar(string Sqltexto)
        {
            SqlCommand comando = new SqlCommand(Sqltexto, conn); 
            comando.ExecuteNonQuery();
        }
        public SqlDataReader ConsultaSQL(String Sqltexto)
        {
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            return (SqlDataReader)command1.ExecuteReader();
        }
        public BindingSource LeerDatos(string Sqltexto)
        {
            BindingSource bindingSource1 = new BindingSource();
            // Se crea un nuevo objeto SqlCommand con la consulta SQL y la conexión establecida.
            SqlCommand command1 = new SqlCommand(Sqltexto, conn);
            // Se crea un objeto SqlDataAdapter para adaptar los resultados de la consulta.
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Se asigna el comando SqlCommand al objeto SqlDataAdapter.
            adapter.SelectCommand = command1;
            // Se crea un nuevo objeto DataTable para almacenar los resultados de la consulta.
            DataTable table = new DataTable();
            // Se establece la configuración regional del DataTable.
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            // Se llena el DataTable con los resultados de la consulta utilizando el objeto SqlDataAdapter.
            adapter.Fill(table);
            // Se asigna el DataTable al objeto BindingSource.
            bindingSource1.DataSource = table;
            // Se devuelve el objeto BindingSource con los resultados de la consulta.
            return bindingSource1;
        }
        // El método "LlenarCombo" se usa para leer datos de una consulta select y llenar un objeto ComboBox con los resultados
        public void LlenarCombo(string sqlTexto, ComboBox cmb)
        {

            cmb.DataSource = LeerDatos(sqlTexto);
           
        }

        public void LlenarGrid(string SqlTexto, DataGridView dg)
        {
            dg.DataSource = LeerDatos(SqlTexto);
        }
    }
}
