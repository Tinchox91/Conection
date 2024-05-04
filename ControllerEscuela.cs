using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos_Conectada
{
    internal class ControllerEscuela: Conection
    {
        public object MySqlComand { get; private set; }

        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null)
            {
                sql = "SELECT dni,nombre FROM alumno ORDER BY nombre ASC";
            }
            else
            {
                sql = "SELECT dni,nombre FROM alumno WHERE dni LIKE '%"+dato+"%' OR nombre LIKE '%"+dato+"%'  ORDER BY nombre ASC";
            }
            try
            {
                MySqlConnection con = base.conexion();
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Escuela _escuela = new Escuela();
                    _escuela.Dni = int.Parse(reader.GetString(0));
                    _escuela.Nombre = reader.GetString(1);
                    lista.Add(_escuela);
                }
            }catch (MySqlException ex)
            {
Console.WriteLine(ex.Message.ToString());

            }
            return lista;
           
        }
    }
}
