using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Gestion_Peliculas.Controllers;
using Sistema_Gestion_Peliculas.Models;

namespace Sistema_Gestion_Peliculas.Views
{
    public partial class frm_Peliculas : Form
    {
        PeliculasController peliculasController = new PeliculasController();
        public string PeliculaId = null;

        public frm_Peliculas()
        {
            InitializeComponent();
        }

        private void frm_Peliculas_Load(object sender, EventArgs e)
        {
            cargaLista();

        }
        
        public void cargaLista()
        {
            lst_Peliculas.DataSource = peliculasController.todos();
            lst_Peliculas.DisplayMember = "titulo";
            lst_Peliculas.ValueMember = "peliculaid";
        }
        private void lst_Peliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Peliculas_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Peliculas.SelectedItem != null)
            {
                PeliculaModel peliculaSeleccionada = (PeliculaModel)lst_Peliculas.SelectedItem;
                string mensaje = $"Titulo:    {peliculaSeleccionada.Titulo}\n" +
                                 $"Genero:    {peliculaSeleccionada.Genero}\n" +
                                 $"Anio:       {peliculaSeleccionada.Anio.Year}\n" +
                                 $"Director:  {peliculaSeleccionada.Director}";

                MessageBox.Show(mensaje, "Informacion de la Pelicula");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Peliculas.SelectedItem != null)
            {
                PeliculaId = lst_Peliculas.SelectedValue.ToString();
                PeliculaModel pelicula = peliculasController.obtener(Convert.ToInt32(PeliculaId));
                if (pelicula != null)
                {
                    txt_Titulo.Text = pelicula.Titulo;
                    txt_Genero.Text = pelicula.Genero;
                    dtp_Anio.Value = pelicula.Anio;
                    txt_Director.Text = pelicula.Director;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una pelicula de la lista.");
            }
        }
        
        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            PeliculaModel pelicula = new PeliculaModel
            {
                PeliculaId = Convert.ToInt32(PeliculaId),
                Titulo = txt_Titulo.Text,
                Genero = txt_Genero.Text,
                Anio = dtp_Anio.Value,
                Director = txt_Director.Text
            };

            if (Convert.ToInt32(PeliculaId) > 0)
            {
                respuesta = peliculasController.editar(pelicula);
            }
            else
            {
                respuesta = peliculasController.insertar(pelicula);
            }

            if (respuesta == "ok")
            {
                PeliculaId = null;
                cargaLista();
                MessageBox.Show("Se guardo con exito");
            }
            else
            {
                PeliculaId = null;
                MessageBox.Show("Error al guardar");
            }
            LimpiarCampos();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Peliculas.SelectedItem != null)
            {
                PeliculaModel pelicula = new PeliculaModel
                {
                    PeliculaId = Convert.ToInt32(lst_Peliculas.SelectedValue)
                };
                string respuesta = peliculasController.eliminar(pelicula);

                if (respuesta == "ok")
                {
                    cargaLista();
                    MessageBox.Show("Pelicula eliminada con exito.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar la pelicula.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una pelicula de la lista.");
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_Titulo.Text = string.Empty;
            txt_Genero.Text = string.Empty;
            dtp_Anio.Value = DateTime.Now;
            txt_Director.Text = string.Empty;
            PeliculaId = null;
            lst_Peliculas.ClearSelected();
        }

    }
}
