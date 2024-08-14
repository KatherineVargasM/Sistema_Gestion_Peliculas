using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Gestion_Peliculas.Models;

namespace Sistema_Gestion_Peliculas.Controllers
{
    internal class PeliculasController
    {
        private PeliculaModel peliculasModel = new PeliculaModel();

        public List<PeliculaModel> todos()
        {
            return peliculasModel.Todos();
        }

        public PeliculaModel obtener(int peliculaId)
        {
            return peliculasModel.Obtener(peliculaId);
        }

        public string insertar(PeliculaModel pelicula)
        {
            return peliculasModel.Insertar(pelicula);
        }

        public string editar(PeliculaModel pelicula)
        {
            return peliculasModel.Editar(pelicula);
        }

        public string eliminar(PeliculaModel pelicula)
        {
            return peliculasModel.Eliminar(pelicula);
        }
    }
}
