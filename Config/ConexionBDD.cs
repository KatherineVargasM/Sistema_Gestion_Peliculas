﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_Gestion_Peliculas.Config
{
    internal class ConexionBDD
    {
        private SqlConnection con = new SqlConnection("Server=.;database=Peliculas;uid=sa;pwd=corpad17k");

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}
