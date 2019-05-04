using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class BBDD
    {
        private static MySqlConnection conexion;

        public static void Conectar(string usuario/*, string password*/)
        {
            string cadenaConexion = "server=127.0.0.1;user=" + usuario + ";password=;database=biblio";
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
        }
        public static void Desconectar()
        {
            conexion.Close();
        }
        public static MySqlDataReader ExecuteQuery(MySqlCommand comando)
        {
            comando.Connection = conexion;
            comando.Prepare();
            return comando.ExecuteReader();
        }
        public static int ExecuteNonQuery(MySqlCommand comando)
        {
            comando.Connection = conexion;
            comando.Prepare();
            return comando.ExecuteNonQuery();
        }

        // a partir de aqui iría en la clase DAO del elemento a procesar, curso... estudiante... patente... articulo...
        public static List<string[]> MuestraTodo()
        {
            List<string[]> ListaPersonas = new List<string[]>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM personas");
            MySqlDataReader reader = ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] registro = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                    ListaPersonas.Add(registro);
                }
            }
            reader.Close();
            return ListaPersonas;
        }

        public static bool ActualizarNombre(string nombre)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE personas SET Nombre=@nombre where Nombre='Marcel'");
            comando.Parameters.AddWithValue("@nombre", nombre);
            int filas = ExecuteNonQuery(comando);
            return filas >= 1;

        }

        public static bool Insertar()
        {
            //OJOOOOOOOOOOOOO parametrizar!!!!!!!!!!!!!!!!!
            MySqlCommand comando = new MySqlCommand("INSERT INTO personas (`cod_persona`, `DNI`, `Nombre`, `Apellidos`, `direccion`, `telefono`) VALUES (NULL, '45123654Q', 'Marcel', 'Hervas', 'C/ Albacete 27 6', '626654789')");
            int filas = ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool BorrarRegistro(int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM personas WHERE cod_persona=@id");
            comando.Parameters.AddWithValue("@id", id);
            int filas = ExecuteNonQuery(comando);
            return filas >= 1;
        }
    }
}
