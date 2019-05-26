using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class AutorUniversidadDAO
    {
        public static ICollection<AutorUniversidad> MostrarTodo()
        {
            ICollection<AutorUniversidad> ListaAutoresUniversidad = new List<AutorUniversidad>();
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido,autoresuniversidad.DNI,autoresuniversidad.edad,autoresuniversidad.departamento" +
                " FROM autores INNER JOIN autoresuniversidad ON autores.ID=autoresuniversidad.id_autor;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AutorUniversidad autor = new AutorUniversidad(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));
                    autor.ID = reader.GetInt32(0);
                    ListaAutoresUniversidad.Add(autor);
                }
            }
            reader.Close();
            return ListaAutoresUniversidad;
        }

       public static ICollection<AutorUniversidad> BuscarAutorUniversidadPorNombre(string nombre)
        {
            ICollection<AutorUniversidad> ListaAutoresUniversidad = new List<AutorUniversidad>();
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido,autoresuniversidad.DNI,autoresuniversidad.edad,autoresuniversidad.departamento" +
                " FROM autores INNER JOIN autoresuniversidad ON autores.ID=autoresuniversidad.id_autor WHERE autores.nombre=@nombre;");
            comando.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AutorUniversidad autor = new AutorUniversidad(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));
                    autor.ID = reader.GetInt32(0);
                    ListaAutoresUniversidad.Add(autor);
                }
            }
            reader.Close();
            return ListaAutoresUniversidad;
        }

        public static AutorUniversidad BuscarAutorUniversidadPorID(int id)
        {
            AutorUniversidad autor = null;
            MySqlCommand comando = new MySqlCommand("SELECT autores.ID,autores.nombre,autores.apellido,autoresuniversidad.DNI,autoresuniversidad.edad,autoresuniversidad.departamento" +
                " FROM autores INNER JOIN autoresuniversidad ON autores.ID=autoresuniversidad.id_autor WHERE autores.ID=@ID;");
            comando.Parameters.AddWithValue("@ID", id);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if(reader.HasRows && reader.Read())
            {
                autor = new AutorUniversidad(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));
                autor.ID = reader.GetInt32(0);
            }
            reader.Close();
            return autor;
        }

        public static bool ActualizarRegistro(AutorUniversidad autor)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE autores SET nombre=@nombre, apellido=@apellido WHERE ID=@ID;" +
                " UPDATE autoresuniversidad SET DNI=@DNI, edad=@edad, departamento=@departamento WHERE id_autor=@id_autor");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            comando.Parameters.AddWithValue("@nombre", autor.Nombre);
            comando.Parameters.AddWithValue("@apellido", autor.Apellido);
            comando.Parameters.AddWithValue("@id_autor", autor.ID);
            comando.Parameters.AddWithValue("@DNI", autor.DNI);
            comando.Parameters.AddWithValue("@edad", autor.Edad);
            comando.Parameters.AddWithValue("@departamento", autor.Departamento);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;

        }

        public static bool Insertar(AutorUniversidad autor)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO gestorpublicaciones.autores VALUES (@ID, @nombre, @apellido, @deUniversidad);" +
                " INSERT INTO gestorpublicaciones.autoresuniversidad VALUES (@id_autor, @DNI, @edad, @departamento)");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            comando.Parameters.AddWithValue("@nombre", autor.Nombre);
            comando.Parameters.AddWithValue("@apellido", autor.Apellido);
            comando.Parameters.AddWithValue("@deUniversidad", autor.deUniversidad);
            comando.Parameters.AddWithValue("@id_autor", autor.ID);
            comando.Parameters.AddWithValue("@DNI", autor.DNI);
            comando.Parameters.AddWithValue("@edad", autor.Edad);
            comando.Parameters.AddWithValue("@departamento", autor.Departamento);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool BorrarRegistro(AutorUniversidad autor)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM autores WHERE autores.ID=@ID");
            comando.Parameters.AddWithValue("@ID", autor.ID);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }
    }
}
