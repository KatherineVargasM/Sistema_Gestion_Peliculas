using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Gestion_Peliculas.Models;

namespace Sistema_Gestion_Peliculas.Controllers
{
    internal class ActoresController
    {
        private ActoresModel actoresModel = new ActoresModel();

        public List<ActoresModel> Todos()
        {
            return actoresModel.Todos();
        }

        public ActoresModel Obtener(int actorId)
        {
            return actoresModel.Obtener(actorId);
        }

        public string Insertar(ActoresModel actor)
        {
            return actoresModel.Insertar(actor);
        }

        public string Editar(ActoresModel actor)
        {
            return actoresModel.Editar(actor);
        }

        public string Eliminar(ActoresModel actor)
        {
            return actoresModel.Eliminar(actor);
        }
    }
}
