namespace Sistema_Gestion_Peliculas.Views
{
    partial class frm_Actores
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
            this.lbl_Actores = new System.Windows.Forms.Label();
            this.lbl_Nacionalidad = new System.Windows.Forms.Label();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.dtp_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_Nacionalidad = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.lst_Actores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(661, 97);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(128, 20);
            this.lbl_Lista.TabIndex = 32;
            this.lbl_Lista.Text = "Lista de Actores:";
            // 
            // lbl_Actores
            // 
            this.lbl_Actores.AutoSize = true;
            this.lbl_Actores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Actores.Location = new System.Drawing.Point(225, 47);
            this.lbl_Actores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Actores.Name = "lbl_Actores";
            this.lbl_Actores.Size = new System.Drawing.Size(136, 29);
            this.lbl_Actores.TabIndex = 31;
            this.lbl_Actores.Text = "ACTORES";
            // 
            // lbl_Nacionalidad
            // 
            this.lbl_Nacionalidad.AutoSize = true;
            this.lbl_Nacionalidad.Location = new System.Drawing.Point(120, 301);
            this.lbl_Nacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nacionalidad.Name = "lbl_Nacionalidad";
            this.lbl_Nacionalidad.Size = new System.Drawing.Size(104, 20);
            this.lbl_Nacionalidad.TabIndex = 30;
            this.lbl_Nacionalidad.Text = "Nacionalidad:";
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(61, 244);
            this.lbl_FechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(163, 20);
            this.lbl_FechaNacimiento.TabIndex = 29;
            this.lbl_FechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(155, 184);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(69, 20);
            this.lbl_Apellido.TabIndex = 28;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(155, 122);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(69, 20);
            this.lbl_Nombre.TabIndex = 27;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // dtp_FechaNacimiento
            // 
            this.dtp_FechaNacimiento.Location = new System.Drawing.Point(230, 239);
            this.dtp_FechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            this.dtp_FechaNacimiento.Size = new System.Drawing.Size(390, 26);
            this.dtp_FechaNacimiento.TabIndex = 26;
            // 
            // txt_Nacionalidad
            // 
            this.txt_Nacionalidad.Location = new System.Drawing.Point(230, 298);
            this.txt_Nacionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nacionalidad.Name = "txt_Nacionalidad";
            this.txt_Nacionalidad.Size = new System.Drawing.Size(390, 26);
            this.txt_Nacionalidad.TabIndex = 25;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(230, 181);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(390, 26);
            this.txt_Apellido.TabIndex = 24;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(230, 122);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(390, 26);
            this.txt_Nombre.TabIndex = 23;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(861, 386);
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
            this.btn_Cancelar.Location = new System.Drawing.Point(702, 386);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(548, 386);
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
            this.btn_Modificar.Location = new System.Drawing.Point(394, 386);
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
            this.btn_Grabar.Location = new System.Drawing.Point(230, 386);
            this.btn_Grabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(137, 65);
            this.btn_Grabar.TabIndex = 18;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // lst_Actores
            // 
            this.lst_Actores.FormattingEnabled = true;
            this.lst_Actores.ItemHeight = 20;
            this.lst_Actores.Location = new System.Drawing.Point(665, 122);
            this.lst_Actores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Actores.Name = "lst_Actores";
            this.lst_Actores.Size = new System.Drawing.Size(333, 204);
            this.lst_Actores.TabIndex = 17;
            this.lst_Actores.SelectedIndexChanged += new System.EventHandler(this.lst_Actores_SelectedIndexChanged);
            this.lst_Actores.DoubleClick += new System.EventHandler(this.lst_Actores_DoubleClick);
            // 
            // frm_Actores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 499);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Actores);
            this.Controls.Add(this.lbl_Nacionalidad);
            this.Controls.Add(this.lbl_FechaNacimiento);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.dtp_FechaNacimiento);
            this.Controls.Add(this.txt_Nacionalidad);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.lst_Actores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Actores";
            this.Text = "frm_Actores";
            this.Load += new System.EventHandler(this.frm_Actores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lista;
        private System.Windows.Forms.Label lbl_Actores;
        private System.Windows.Forms.Label lbl_Nacionalidad;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimiento;
        private System.Windows.Forms.TextBox txt_Nacionalidad;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ListBox lst_Actores;
    }
}