﻿using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGPublicacionesCientificas.CapaNegocio;

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

       /* public static ICollection<AutorUniversidad> BuscarAutorUniversidadPorNombre(string nombre)
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
        }*/

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