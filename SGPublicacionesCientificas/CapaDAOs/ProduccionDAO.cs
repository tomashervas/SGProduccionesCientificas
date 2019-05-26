using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPublicacionesCientificas.CapaNegocio;
using MySql.Data.MySqlClient;

namespace SGPublicacionesCientificas.CapaDAOs
{
    class ProduccionDAO
    {
        public static ICollection<ProduccionCientifica> BuscarProduccionPorAutor(string nombre)
        {
            ICollection<ProduccionCientifica> ListaProducciones = new List<ProduccionCientifica>();
            MySqlCommand comando = new MySqlCommand("SELECT produccioncientifica.ID, produccioncientifica.titulo, produccioncientifica.año, produccioncientifica.tipo FROM produccioncientifica INNER JOIN publica ON produccioncientifica.ID= publica.id_produccion INNER JOIN autores ON publica.id_autor= autores.ID WHERE autores.nombre=@nombre;");
            comando.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProduccionCientifica produccion = new ProduccionCientifica(reader.GetString(1),reader.GetInt32(2));
                    produccion.ID = reader.GetInt32(0);
                    produccion.Tipo = reader.GetString(3);
                    ListaProducciones.Add(produccion);
                }
            }
            reader.Close();
            return ListaProducciones;
        }

        public static ICollection<ProduccionCientifica> BuscarProduccionPorTipo(string tipo, string nombre)
        {
            ICollection<ProduccionCientifica> ListaProducciones = new List<ProduccionCientifica>();
            MySqlCommand comando = new MySqlCommand("SELECT produccioncientifica.ID, produccioncientifica.titulo, produccioncientifica.año, produccioncientifica.tipo FROM produccioncientifica INNER JOIN publica ON produccioncientifica.ID= publica.id_produccion INNER JOIN autores ON publica.id_autor= autores.ID WHERE autores.nombre=@nombre AND produccioncientifica.tipo=@tipo");
            comando.Parameters.AddWithValue("@tipo", tipo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            MySqlDataReader reader = BBDD.ExecuteQuery(comando);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProduccionCientifica produccion = new ProduccionCientifica(reader.GetString(1), reader.GetInt32(2));
                    produccion.ID = reader.GetInt32(0);
                    produccion.Tipo = reader.GetString(3);
                    ListaProducciones.Add(produccion);
                }
            }
            reader.Close();
            return ListaProducciones;
        }

    }
}
