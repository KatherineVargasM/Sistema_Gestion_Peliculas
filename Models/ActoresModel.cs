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
    internal class ActoresModel
    {
        public int ActorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();

        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }

        public List<ActoresModel> Todos()
        {
            string cadena = "select * from Actores";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);

            List<ActoresModel> listaActores = new List<ActoresModel>();

            foreach (DataRow fila in data.Rows)
            {
                ActoresModel actor = new ActoresModel
                {
                    ActorId = Convert.ToInt32(fila["actor_id"]),
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["apellido"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(fila["fecha_nacimiento"]),
                    Nacionalidad = fila["nacionalidad"].ToString()
                };
                listaActores.Add(actor);
            }

            conexionBDD.CerrarConexion();
            return listaActores;
        }

        public ActoresModel Obtener(int actorId)
        {
            string cadena = "select * from Actores where actor_id = @ActorId";
            SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
            cmd.Parameters.AddWithValue("@ActorId", actorId);
            SqlDataReader lector = cmd.ExecuteReader();

            ActoresModel actor = null;
            if (lector.Read())
            {
                actor = new ActoresModel
                {
                    ActorId = Convert.ToInt32(lector["actor_id"]),
                    Nombre = lector["nombre"].ToString(),
                    Apellido = lector["apellido"].ToString(),
                    FechaNacimiento = Convert.ToDateTime(lector["fecha_nacimiento"]),
                    Nacionalidad = lector["nacionalidad"].ToString()
                };
            }
            lector.Close();
            conexionBDD.CerrarConexion();
            return actor;
        }

        public string Insertar(ActoresModel actor)
        {
            try
            {
                string cadena = "insert into Actores (nombre, apellido, fecha_nacimiento, nacionalidad) values (@Nombre, @Apellido, @FechaNacimiento, @Nacionalidad)";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", actor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", actor.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", actor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Nacionalidad", actor.Nacionalidad);
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

        public string Editar(ActoresModel actor)
        {
            try
            {
                string cadena = "update Actores set nombre = @Nombre, apellido = @Apellido, fecha_nacimiento = @FechaNacimiento, nacionalidad = @Nacionalidad where actor_id = @ActorId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@Nombre", actor.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", actor.Apellido);
                cmd.Parameters.AddWithValue("@FechaNacimiento", actor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Nacionalidad", actor.Nacionalidad);
                cmd.Parameters.AddWithValue("@ActorId", actor.ActorId);
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

        public string Eliminar(ActoresModel actor)
        {
            try
            {
                string cadena = "delete from Actores where actor_id = @ActorId";
                SqlCommand cmd = new SqlCommand(cadena, conexionBDD.AbrirConexion());
                cmd.Parameters.AddWithValue("@ActorId", actor.ActorId);
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
