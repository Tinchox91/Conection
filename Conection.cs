using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos_Conectada
{
    internal class Conection
    {
        public void conexion()
        {
            string servidor = "localhost";
            string usuario = "root";
            string puerto = "3306";
            string contraseña = "root";
            string baseDatos = "escuela";

            string cadenaConexion = $"server={servidor};port={puerto};user id={usuario};password={contraseña};database={baseDatos} ;";
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                conexionBD.Open();
                MessageBox.Show("Conexión establecida correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al establecer la conexión: " + ex.Message);
                conexionBD.Close();
            }
            finally
            {
                if (conexionBD.State == System.Data.ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
    }
}
