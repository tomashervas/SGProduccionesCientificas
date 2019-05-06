﻿using System;
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
            string cadenaConexion = "server=127.0.0.1;user=" + usuario + ";password=;database=gestorpublicaciones";
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
    }
}
