using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGPublicacionesCientificas.CapaNegocio;
using SGPublicacionesCientificas.CapaPresentacion;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class PatenteDAO
    {
        public static ICollection<Patente> MostrarTodo()
        {
            ICollection<Patente> Lista = new List<Patente>();
            MySqlCommand comando = new MySqlCommand("SELECT produccioncientifica.ID, produccioncientifica.titulo,produccioncientifica.año, patentes.cuantia, patentes.fechaVencimiento FROM produccioncientifica INNER JOIN patentes ON produccioncientifica.ID=patentes.id_produccion;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Patente patente = new Patente(reader.GetString(1), reader.GetInt32(2), reader.GetDateTime(4).Date, reader.GetDouble(3));
                    patente.ID = reader.GetInt32(0);
                    Lista.Add(patente);
                }
            }
            reader.Close();
            return Lista;
        }

        public static ICollection<int> MostrarAutoresPublicacion(int id)
        {
            ICollection<int> Lista = new List<int>();
            MySqlCommand comando = new MySqlCommand("SELECT publica.id_autor FROM publica WHERE publica.id_produccion=@id;");
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    Lista.Add(ID);
                }
            }
            reader.Close();
            return Lista;
        }

        public static bool ActualizarRegistro(Patente patente)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE produccioncientifica SET titulo=@titulo, año=@año WHERE ID=@ID;" +
                                                    " UPDATE patentes SET fechaVencimiento=@fechaVencimiento, cuantia=@cuantia WHERE id_produccion=@id_produccion");
            comando.Parameters.AddWithValue("@ID", patente.ID);
            comando.Parameters.AddWithValue("@titulo", patente.Titulo);
            comando.Parameters.AddWithValue("@año", patente.Año);
            comando.Parameters.AddWithValue("@id_produccion", patente.ID);
            comando.Parameters.AddWithValue("@fechaVencimiento", patente.FechaVencimiento);
            comando.Parameters.AddWithValue("@cuantia", patente.Cuantia);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;

        }

        public static bool InsertarPublicaPatente(int id_autor,int id_publi)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `publica` (`id_autor`, `id_produccion`) VALUES (@id_autor, @id);");
            comando.Parameters.AddWithValue("@id", id_publi);
            comando.Parameters.AddWithValue("@id_autor", id_autor);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }


        public static bool Insertar(Patente patente)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO produccioncientifica VALUES (@ID, @titulo, @año, @tipo);" +
                                                    " INSERT INTO patentes VALUES (@id_produccion, @cuantia, @fechaVencimiento);");
            comando.Parameters.AddWithValue("@ID", patente.ID);
            comando.Parameters.AddWithValue("@titulo", patente.Titulo);
            comando.Parameters.AddWithValue("@año", patente.Año);
            comando.Parameters.AddWithValue("@id_produccion", patente.ID);
            comando.Parameters.AddWithValue("@fechaVencimiento", patente.FechaVencimiento);
            comando.Parameters.AddWithValue("@cuantia", patente.Cuantia);
            comando.Parameters.AddWithValue("@tipo", patente.Tipo);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool BorrarRegistro(Patente patente)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM produccioncientifica WHERE produccioncientifica.ID=@ID");
            comando.Parameters.AddWithValue("@ID", patente.ID);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static int IDactual()
        {
            int ID = 0;
            MySqlCommand comando = new MySqlCommand("SELECT MAX(produccioncientifica.ID) FROM produccioncientifica;");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows && reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            reader.Close();
            return ID;
        }
    }
}