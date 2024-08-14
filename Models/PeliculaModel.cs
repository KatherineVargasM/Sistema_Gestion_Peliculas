using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_Gestion_Peliculas.Config;

namespace Sistema_Gestion_Peliculas.Models
{
    internal class PeliculaModel
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public DateTime Anio { get; set; }
        public string Director { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();

        public List<PeliculaModel> Todos()
        {
            string cadena = "select * from Peliculas";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);

            List<PeliculaModel> listaPeliculas = new List<PeliculaModel>();

            foreach (DataRow fila in data.Rows)
            {
                PeliculaModel pelicula = new PeliculaModel
                {
                    PeliculaId = Convert.ToInt32(fila["pelicula_id"]),
                    Titulo = fila["titulo"].ToString(),
                    Genero = fila["genero"].ToString(),
                    Anio = Convert.ToDateTime(fila["anio"]),
                    Director = fila["director"].ToString()
                };
                listaPeliculas.Add(pelicula);
            }

            conexionBDD.CerrarConexion();
            return listaPeliculas;
        }

        public PeliculaModel Obtener(int peliculaId)
        {
            string cadena = "select * from Peliculas where pelicula_id = @PeliculaId";
            SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
            cmd.Parameters.AddWithValue("@PeliculaId", peliculaId);
            SqlDataReader lector = cmd.ExecuteReader();

            PeliculaModel pelicula = null;
            if (lector.Read())
            {
                pelicula = new PeliculaModel
                {
                    PeliculaId = Convert.ToInt32(lector["pelicula_id"]),
                    Titulo = lector["titulo"].ToString(),
                    Genero = lector["genero"].ToString(),
                    Anio = Convert.ToDateTime(lector["anio"]),
                    Director = lector["director"].ToString()
                };
            }
            lector.Close();
            conexionBDD.CerrarConexion();
            return pelicula;
        }

        public string Insertar(PeliculaModel pelicula)
        {
            try
            {
                string cadena = "insert into Peliculas (titulo, genero, anio, director) values (@Titulo, @Genero, @Anio, @Director)";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@Titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@Genero", pelicula.Genero);
                cmd.Parameters.AddWithValue("@Anio", pelicula.Anio);
                cmd.Parameters.AddWithValue("@Director", pelicula.Director);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Editar(PeliculaModel pelicula)
        {
            try
            {
                string cadena = "update Peliculas set titulo = @Titulo, genero = @Genero, anio = @Anio, director = @Director where pelicula_id = @PeliculaId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@Titulo", pelicula.Titulo);
                cmd.Parameters.AddWithValue("@Genero", pelicula.Genero);
                cmd.Parameters.AddWithValue("@Anio", pelicula.Anio);
                cmd.Parameters.AddWithValue("@Director", pelicula.Director);
                cmd.Parameters.AddWithValue("@PeliculaId", pelicula.PeliculaId);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }

        public string Eliminar(PeliculaModel pelicula)
        {
            try
            {
                string cadena = "delete from Peliculas where pelicula_id = @PeliculaId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@PeliculaId", pelicula.PeliculaId);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
        }
    }
}

