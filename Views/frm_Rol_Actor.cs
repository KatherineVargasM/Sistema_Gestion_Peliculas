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
    public partial class frm_Rol_Actor : Form
    {
        Rol_ActorController rolActorController = new Rol_ActorController();
        PeliculasController peliculasController = new PeliculasController();
        ActoresController actoresController = new ActoresController();
        public string RolId = null;

        public frm_Rol_Actor()
        {
            InitializeComponent();
        }

        private void frm_Rol_Actor_Load(object sender, EventArgs e)
        {
            cargarListas();
        }

        private void cargarListas()
        {
            lst_Rol_Actor.DataSource = rolActorController.Todos();
            lst_Rol_Actor.DisplayMember = "Papel";
            lst_Rol_Actor.ValueMember = "RolId";

            cmb_Pelicula.DataSource = peliculasController.todos();
            cmb_Pelicula.DisplayMember = "Titulo";
            cmb_Pelicula.ValueMember = "PeliculaId";

            cmb_Actor.DataSource = actoresController.Todos();
            cmb_Actor.DisplayMember = "NombreCompleto";
            cmb_Actor.ValueMember = "ActorId";
        }

        private void lst_Rol_Actor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Rol_Actor.SelectedItem != null)
            {
                RolId = lst_Rol_Actor.SelectedValue.ToString();
                Rol_ActorModel rolActor = rolActorController.Obtener(Convert.ToInt32(RolId));
                if (rolActor != null)
                {
                    cmb_Pelicula.SelectedValue = rolActor.PeliculaId;
                    cmb_Actor.SelectedValue = rolActor.ActorId;
                    txt_Papel.Text = rolActor.Papel;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol de la lista.");
            }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            Rol_ActorModel rolActor = new Rol_ActorModel
            {
                RolId = string.IsNullOrEmpty(RolId) ? 0 : Convert.ToInt32(RolId),
                PeliculaId = Convert.ToInt32(cmb_Pelicula.SelectedValue),
                ActorId = Convert.ToInt32(cmb_Actor.SelectedValue),
                Papel = txt_Papel.Text
            };

            if (rolActor.RolId > 0)
            {
                respuesta = rolActorController.Editar(rolActor);
            }
            else
            {
                respuesta = rolActorController.Insertar(rolActor);
            }

            if (respuesta == "ok")
            {
                RolId = null;
                cargarListas();
                MessageBox.Show("Se guardo con exito");
            }
            else
            {
                RolId = null;
                MessageBox.Show("Error al guardar");
            }
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Rol_Actor.SelectedItem != null)
            {
                Rol_ActorModel rolActor = new Rol_ActorModel
                {
                    RolId = Convert.ToInt32(lst_Rol_Actor.SelectedValue)
                };
                string respuesta = rolActorController.Eliminar(rolActor);

                if (respuesta == "ok")
                {
                    cargarListas();
                    MessageBox.Show("Rol eliminado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el rol.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un rol de la lista.");
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
            cmb_Pelicula.SelectedIndex = -1;
            cmb_Actor.SelectedIndex = -1;
            txt_Papel.Text = string.Empty;
            RolId = null;
            lst_Rol_Actor.ClearSelected();
        }
    }
}
