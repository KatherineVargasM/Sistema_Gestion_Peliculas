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
    internal class Rol_ActorModel
    {
        public int RolId { get; set; }
        public int PeliculaId { get; set; }
        public int ActorId { get; set; }
        public string Papel { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();

        public List<Rol_ActorModel> Todos()
        {
            string cadena = "select * from Rol_Actor";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);

            List<Rol_ActorModel> listaRoles = new List<Rol_ActorModel>();

            foreach (DataRow fila in data.Rows)
            {
                Rol_ActorModel rol = new Rol_ActorModel
                {
                    RolId = Convert.ToInt32(fila["rol_id"]),
                    PeliculaId = Convert.ToInt32(fila["pelicula_id"]),
                    ActorId = Convert.ToInt32(fila["actor_id"]),
                    Papel = fila["papel"].ToString()
                };
                listaRoles.Add(rol);
            }

            conexionBDD.CerrarConexion();
            return listaRoles;
        }

        public Rol_ActorModel Obtener(int rolId)
        {
            string cadena = "select * from Rol_Actor where rol_id = @RolId";
            SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
            cmd.Parameters.AddWithValue("@RolId", rolId);
            SqlDataReader lector = cmd.ExecuteReader();

            Rol_ActorModel rol = null;
            if (lector.Read())
            {
                rol = new Rol_ActorModel
                {
                    RolId = Convert.ToInt32(lector["rol_id"]),
                    PeliculaId = Convert.ToInt32(lector["pelicula_id"]),
                    ActorId = Convert.ToInt32(lector["actor_id"]),
                    Papel = lector["papel"].ToString()
                };
            }
            lector.Close();
            conexionBDD.CerrarConexion();
            return rol;
        }

        public string Insertar(Rol_ActorModel rol)
        {
            try
            {
                string cadena = "insert into Rol_Actor (pelicula_id, actor_id, papel) values (@PeliculaId, @ActorId, @Papel)";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@PeliculaId", rol.PeliculaId);
                cmd.Parameters.AddWithValue("@ActorId", rol.ActorId);
                cmd.Parameters.AddWithValue("@Papel", rol.Papel);
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

        public string Editar(Rol_ActorModel rol)
        {
            try
            {
                string cadena = "update Rol_Actor set pelicula_id = @PeliculaId, actor_id = @ActorId, papel = @Papel where rol_id = @RolId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@PeliculaId", rol.PeliculaId);
                cmd.Parameters.AddWithValue("@ActorId", rol.ActorId);
                cmd.Parameters.AddWithValue("@Papel", rol.Papel);
                cmd.Parameters.AddWithValue("@RolId", rol.RolId);
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

        public string Eliminar(Rol_ActorModel rol)
        {
            try
            {
                string cadena = "delete from Rol_Actor where rol_id = @RolId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@RolId", rol.RolId);
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
