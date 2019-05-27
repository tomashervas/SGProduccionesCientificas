using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGPublicacionesCientificas.CapaNegocio;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class ConferenciaDAO
    {
        //En esta clase creamos los métodos de acceso a datos para tratar el tipo de dato "conferencia", desarrollamos un métrodo
        //MostrarTodo para que importe los datos de las conferencias, uno para actualizarlas, uno para insetar nuevos registros
        // uno para borrar registros y uno para actualizar la relación autor-articulo de conferencia
        public static ICollection<Conferencia> MostrarTodo()
        {
            ICollection<Conferencia> Lista = new List<Conferencia>();
            MySqlCommand comando = new MySqlCommand("SELECT produccioncientifica.ID, produccioncientifica.titulo,produccioncientifica.año,articulocientifico.numPaginas, articulocientifico.numCitas,articulocientifico.DOI,articulocientifico.nombreConferencia,articulocientifico.lugar, articulocientifico.categoría FROM produccioncientifica INNER JOIN articulocientifico ON produccioncientifica.ID=articulocientifico.id_produccion AND produccioncientifica.tipo='conferencia';");
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Conferencia conferencia = new Conferencia(reader.GetString(1), reader.GetInt32(2),reader.GetInt32(3), reader.GetInt32(4),reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                    conferencia.ID = reader.GetInt32(0);
                    Lista.Add(conferencia);
                }
            }
            reader.Close();
            return Lista;
        }

        public static bool ActualizarRegistro(Conferencia conferencia)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE produccioncientifica SET titulo=@titulo, año=@año WHERE ID=@ID;" +
                                                    " UPDATE `articulocientifico` SET `numPaginas`=@paginas, `numCitas`=@citas, `DOI`=@doi, `nombreConferencia`=@nombre, `lugar`=@lugar, `categoría`=@categoria WHERE id_produccion=@id_produccion");
            comando.Parameters.AddWithValue("@ID", conferencia.ID);
            comando.Parameters.AddWithValue("@titulo", conferencia.Titulo);
            comando.Parameters.AddWithValue("@año", conferencia.Año);
            comando.Parameters.AddWithValue("@id_produccion", conferencia.ID);
            comando.Parameters.AddWithValue("@paginas", conferencia.Paginas);
            comando.Parameters.AddWithValue("@citas", conferencia.Citas);
            comando.Parameters.AddWithValue("@doi", conferencia.DOI);
            comando.Parameters.AddWithValue("@nombre", conferencia.NombreConferencia);
            comando.Parameters.AddWithValue("@lugar", conferencia.Lugar);
            comando.Parameters.AddWithValue("@categoria", conferencia.Categoria);

            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool InsertarPublicaConferencia(int id_autor, int id_publi)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `publica` (`id_autor`, `id_produccion`) VALUES (@id_autor, @id);");
            comando.Parameters.AddWithValue("@id", id_publi);
            comando.Parameters.AddWithValue("@id_autor", id_autor);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool Insertar(Conferencia conferencia)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO produccioncientifica VALUES (@ID, @titulo, @año, @tipo);" +
                                                    " INSERT INTO articulocientifico VALUES (@id_produccion, @paginas, @citas, @doi ,@tipo , @nombre, @lugar, @categoria, NULL, NULL, NULL );");
            comando.Parameters.AddWithValue("@ID", conferencia.ID);
            comando.Parameters.AddWithValue("@titulo", conferencia.Titulo);
            comando.Parameters.AddWithValue("@año", conferencia.Año);
            comando.Parameters.AddWithValue("@id_produccion", conferencia.ID);
            comando.Parameters.AddWithValue("@tipo", conferencia.Tipo);
            comando.Parameters.AddWithValue("@paginas", conferencia.Paginas);
            comando.Parameters.AddWithValue("@citas", conferencia.Citas);
            comando.Parameters.AddWithValue("@doi", conferencia.DOI);
            comando.Parameters.AddWithValue("@nombre", conferencia.NombreConferencia);
            comando.Parameters.AddWithValue("@lugar", conferencia.Lugar);
            comando.Parameters.AddWithValue("@categoria", conferencia.Categoria);

            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }

        public static bool BorrarRegistro(Conferencia conferencia)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM produccioncientifica WHERE produccioncientifica.ID=@ID");
            comando.Parameters.AddWithValue("@ID", conferencia.ID);
            int filas = BBDD.ExecuteNonQuery(comando);
            return filas >= 1;
        }
    }
}
