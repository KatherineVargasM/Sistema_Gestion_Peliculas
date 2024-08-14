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
    public partial class frm_Actores : Form
    {
        ActoresController actoresController = new ActoresController();
        public string ActorId = null;

        public frm_Actores()
        {
            InitializeComponent();
        }

        private void frm_Actores_Load(object sender, EventArgs e)
        {
            CargarLista();
        }
        public void CargarLista()
        {
            lst_Actores.DataSource = actoresController.Todos();
            lst_Actores.DisplayMember = "NombreCompleto";
            lst_Actores.ValueMember = "ActorId";
        }
        private void lst_Actores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lst_Actores_DoubleClick(object sender, EventArgs e)
        {
            if (lst_Actores.SelectedItem != null)
            {
                ActoresModel actorSeleccionado = (ActoresModel)lst_Actores.SelectedItem;
                string mensaje = $"Nombre:    {actorSeleccionado.Nombre}\n" +
                                 $"Apellido:  {actorSeleccionado.Apellido}\n" +
                                 $"Fecha Nacimiento: {actorSeleccionado.FechaNacimiento.ToShortDateString()}\n" +
                                 $"Nacionalidad: {actorSeleccionado.Nacionalidad}";

                MessageBox.Show(mensaje, "Informacion del Actor");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (lst_Actores.SelectedItem != null)
            {
                ActorId = lst_Actores.SelectedValue.ToString();
                ActoresModel actor = actoresController.Obtener(Convert.ToInt32(ActorId));
                if (actor != null)
                {
                    txt_Nombre.Text = actor.Nombre;
                    txt_Apellido.Text = actor.Apellido;
                    dtp_FechaNacimiento.Value = actor.FechaNacimiento;
                    txt_Nacionalidad.Text = actor.Nacionalidad;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un actor de la lista.");
            }
        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            ActoresModel actor = new ActoresModel
            {
                ActorId = Convert.ToInt32(ActorId),
                Nombre = txt_Nombre.Text,
                Apellido = txt_Apellido.Text,
                FechaNacimiento = dtp_FechaNacimiento.Value,
                Nacionalidad = txt_Nacionalidad.Text
            };

            if (Convert.ToInt32(ActorId) > 0)
            {
                respuesta = actoresController.Editar(actor);
            }
            else
            {
                respuesta = actoresController.Insertar(actor);
            }

            if (respuesta == "ok")
            {
                ActorId = null;
                CargarLista();
                MessageBox.Show("Se guardó con éxito");
            }
            else
            {
                ActorId = null;
                MessageBox.Show("Error al guardar");
            }
            LimpiarCampos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lst_Actores.SelectedItem != null)
            {
                ActoresModel actor = new ActoresModel
                {
                    ActorId = Convert.ToInt32(lst_Actores.SelectedValue)
                };
                string respuesta = actoresController.Eliminar(actor);

                if (respuesta == "ok")
                {
                    CargarLista();
                    MessageBox.Show("Actor eliminado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el actor.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un actor de la lista.");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txt_Nombre.Text = string.Empty;
            txt_Apellido.Text = string.Empty;
            dtp_FechaNacimiento.Value = DateTime.Now;
            txt_Nacionalidad.Text = string.Empty;
            ActorId = null;
            lst_Actores.ClearSelected();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
