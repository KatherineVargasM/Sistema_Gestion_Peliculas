using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Gestion_Peliculas.Views;

namespace Sistema_Gestion_Peliculas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Peliculas frm_Peliculas = new frm_Peliculas();
            frm_Peliculas.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Actores frm_Actores = new frm_Actores();
            frm_Actores.Show();
        }

        private void rolActorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Rol_Actor frm_Rol_Actor = new frm_Rol_Actor();
            frm_Rol_Actor.Show();
        }
    }
}
