using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Gestion_Peliculas.Models;

namespace Sistema_Gestion_Peliculas.Controllers
{
    internal class Rol_ActorController
    {
        private Rol_ActorModel rolActorModel = new Rol_ActorModel();

        public List<Rol_ActorModel> Todos()
        {
            return rolActorModel.Todos();
        }

        public Rol_ActorModel Obtener(int rolId)
        {
            return rolActorModel.Obtener(rolId);
        }

        public string Insertar(Rol_ActorModel rol)
        {
            return rolActorModel.Insertar(rol);
        }

        public string Editar(Rol_ActorModel rol)
        {
            return rolActorModel.Editar(rol);
        }

        public string Eliminar(Rol_ActorModel rol)
        {
            return rolActorModel.Eliminar(rol);
        }
    }
}
