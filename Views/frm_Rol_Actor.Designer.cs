namespace Sistema_Gestion_Peliculas.Views
{
    partial class frm_Rol_Actor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.lbl_Rol_Actor = new System.Windows.Forms.Label();
            this.lbl_Papel = new System.Windows.Forms.Label();
            this.txt_Papel = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.lst_Rol_Actor = new System.Windows.Forms.ListBox();
            this.cmb_Pelicula = new System.Windows.Forms.ComboBox();
            this.cmb_Actor = new System.Windows.Forms.ComboBox();
            this.lbl_Actor = new System.Windows.Forms.Label();
            this.lbl_Pelicula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(565, 96);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(114, 20);
            this.lbl_Lista.TabIndex = 32;
            this.lbl_Lista.Text = "Lista de Roles:";
            // 
            // lbl_Rol_Actor
            // 
            this.lbl_Rol_Actor.AutoSize = true;
            this.lbl_Rol_Actor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol_Actor.Location = new System.Drawing.Point(165, 58);
            this.lbl_Rol_Actor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Rol_Actor.Name = "lbl_Rol_Actor";
            this.lbl_Rol_Actor.Size = new System.Drawing.Size(237, 29);
            this.lbl_Rol_Actor.TabIndex = 31;
            this.lbl_Rol_Actor.Text = "ROL DE ACTORES";
            // 
            // lbl_Papel
            // 
            this.lbl_Papel.AutoSize = true;
            this.lbl_Papel.Location = new System.Drawing.Point(153, 253);
            this.lbl_Papel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Papel.Name = "lbl_Papel";
            this.lbl_Papel.Size = new System.Drawing.Size(53, 20);
            this.lbl_Papel.TabIndex = 27;
            this.lbl_Papel.Text = "Papel:";
            // 
            // txt_Papel
            // 
            this.txt_Papel.Location = new System.Drawing.Point(214, 253);
            this.txt_Papel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Papel.Name = "txt_Papel";
            this.txt_Papel.Size = new System.Drawing.Size(321, 26);
            this.txt_Papel.TabIndex = 23;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(785, 371);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(137, 65);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(626, 371);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(137, 65);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(472, 371);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(137, 65);
            this.btn_Eliminar.TabIndex = 20;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(318, 371);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(137, 65);
            this.btn_Modificar.TabIndex = 19;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(154, 371);
            this.btn_Grabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(137, 65);
            this.btn_Grabar.TabIndex = 18;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // lst_Rol_Actor
            // 
            this.lst_Rol_Actor.FormattingEnabled = true;
            this.lst_Rol_Actor.ItemHeight = 20;
            this.lst_Rol_Actor.Location = new System.Drawing.Point(569, 138);
            this.lst_Rol_Actor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Rol_Actor.Name = "lst_Rol_Actor";
            this.lst_Rol_Actor.Size = new System.Drawing.Size(353, 204);
            this.lst_Rol_Actor.TabIndex = 17;
            this.lst_Rol_Actor.SelectedIndexChanged += new System.EventHandler(this.lst_Rol_Actor_SelectedIndexChanged);
            // 
            // cmb_Pelicula
            // 
            this.cmb_Pelicula.FormattingEnabled = true;
            this.cmb_Pelicula.Location = new System.Drawing.Point(214, 138);
            this.cmb_Pelicula.Name = "cmb_Pelicula";
            this.cmb_Pelicula.Size = new System.Drawing.Size(321, 28);
            this.cmb_Pelicula.TabIndex = 33;
            // 
            // cmb_Actor
            // 
            this.cmb_Actor.FormattingEnabled = true;
            this.cmb_Actor.Location = new System.Drawing.Point(214, 192);
            this.cmb_Actor.Name = "cmb_Actor";
            this.cmb_Actor.Size = new System.Drawing.Size(321, 28);
            this.cmb_Actor.TabIndex = 34;
            // 
            // lbl_Actor
            // 
            this.lbl_Actor.AutoSize = true;
            this.lbl_Actor.Location = new System.Drawing.Point(156, 192);
            this.lbl_Actor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Actor.Name = "lbl_Actor";
            this.lbl_Actor.Size = new System.Drawing.Size(51, 20);
            this.lbl_Actor.TabIndex = 35;
            this.lbl_Actor.Text = "Actor:";
            // 
            // lbl_Pelicula
            // 
            this.lbl_Pelicula.AutoSize = true;
            this.lbl_Pelicula.Location = new System.Drawing.Point(140, 140);
            this.lbl_Pelicula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pelicula.Name = "lbl_Pelicula";
            this.lbl_Pelicula.Size = new System.Drawing.Size(67, 20);
            this.lbl_Pelicula.TabIndex = 36;
            this.lbl_Pelicula.Text = "Pelicula:";
            // 
            // frm_Rol_Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 492);
            this.Controls.Add(this.lbl_Pelicula);
            this.Controls.Add(this.lbl_Actor);
            this.Controls.Add(this.cmb_Actor);
            this.Controls.Add(this.cmb_Pelicula);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Rol_Actor);
            this.Controls.Add(this.lbl_Papel);
            this.Controls.Add(this.txt_Papel);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.lst_Rol_Actor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Rol_Actor";
            this.Text = "frm_Rol_Actor";
            this.Load += new System.EventHandler(this.frm_Rol_Actor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Rol_Actor;
        private System.Windows.Forms.Label lbl_Papel;
        private System.Windows.Forms.TextBox txt_Papel;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ListBox lst_Rol_Actor;
        private System.Windows.Forms.ComboBox cmb_Pelicula;
        private System.Windows.Forms.ComboBox cmb_Actor;
        private System.Windows.Forms.Label lbl_Actor;
        private System.Windows.Forms.Label lbl_Pelicula;
    }
}