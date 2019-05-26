using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class AutorExternoDAO
    {
        public static ICollection<AutorExterno> MostrarTodo()
        {
            ICollection<AutorExterno> ListaAutoresExternos = new List<AutorExterno>();
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido FROM autores WHERE autores.deUniversidad=0;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AutorExterno autor = new AutorExterno(reader.GetString(1), reader.GetString(2));
                    autor.ID = reader.GetInt32(0);
                    ListaAutoresExternos.Add(autor);
                }
            }
            reader.Close();
            return ListaAutoresExternos;
        }

        public static ICollection<AutorExterno> MostrarExternosInternos()
        {
            ICollection<AutorExterno> Lista = new List<AutorExterno>();
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido FROM autores;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AutorExterno autor = new AutorExterno(reader.GetString(1), reader.GetString(2));
                    autor.ID = reader.GetInt32(0);
                    Lista.Add(autor);
                }
            }
            reader.Close();
            return Lista;
        }

        /// <summary>
        /// Funcion que accede a la tabla autores y localiza el valor máximo de ID para utilizarlo como contador de IDs en los constructores
        /// de autor
        /// </summary>
        /// <returns>Entero que cuyo valor es el último ID de autores</returns>
        public static int IDactual()
        {
            int ID = 0;
            MySqlCommand comando = new MySqlCommand("SELECT MAX(autores.ID) FROM autores;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows && reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            reader.Close();
            return ID;
        }

        public static ICollection<AutorExterno> BuscarAutorExternoPorNombre(string nombre)
        {
            ICollection<AutorExterno> ListaAutoresExternos = new List<AutorExterno>();
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido FROM autores WHERE autores.deUniversidad=0 && autores.nombre=@nombre;");
            comando.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AutorExterno autor = new AutorExterno(reader.GetString(1), reader.GetString(2));
                    autor.ID = reader.GetInt32(0);
                    ListaAutoresExternos.Add(autor);
                }
            }
            reader.Close();
            return ListaAutoresExternos;
        }

        public static AutorExterno BuscarAutorExternoPorID(int id)
        {
            AutorExterno autor = null;
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido FROM autores WHERE autores.deUniversidad=0 && autores.ID=@ID;");
            comando.Parameters.AddWithValue("@ID", id);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows && reader.Read())
            {
                autor = new AutorExterno(reader.GetString(1), reader.GetString(2));
                autor.ID = reader.GetInt32(0);
            }
            reader.Close();
            return autor;
        }

        /// <summary>
        /// Metodo que busca por id la informacion de los autores
        /// </summary>
        /// <param name="id">Entero ID que filtra el listado de la tabla autores</param>
        /// <returns></returns>
        public static AutorExterno BuscarAutorPorID(int id)
        {
            AutorExterno autor = null;
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido FROM autores WHERE autores.ID=@ID;");
            comando.Parameters.AddWithValue("@ID", id);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows && reader.Read())
            {
                autor = new AutorExterno(reader.GetString(1), reader.GetString(2));
                autor.ID = reader.GetInt32(0);
            }
            reader.Close();
            return autor;
        }

        public static bool ActualizarRegistro(AutorExterno autor)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE autores SET nombre=@nombre, apellido=@apellido WHERE ID=@ID;");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            comando.Parameters.AddWithValue("@nombre", autor.Nombre);
            comando.Parameters.AddWithValue("@apellido", autor.Apellido);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;

        }

        public static bool Insertar(AutorExterno autor)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO gestorpublicaciones.autores VALUES (@ID, @nombre, @apellido, @deUniversidad);");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            comando.Parameters.AddWithValue("@nombre", autor.Nombre);
            comando.Parameters.AddWithValue("@apellido", autor.Apellido);
            comando.Parameters.AddWithValue("@deUniversidad", autor.deUniversidad);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool BorrarRegistro(AutorExterno autor)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM autores WHERE autores.ID=@ID");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }
    }
}
