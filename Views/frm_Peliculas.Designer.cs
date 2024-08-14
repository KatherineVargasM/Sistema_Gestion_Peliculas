namespace Sistema_Gestion_Peliculas.Views
{
    partial class frm_Peliculas
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
            this.lst_Peliculas = new System.Windows.Forms.ListBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Genero = new System.Windows.Forms.TextBox();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.dtp_Anio = new System.Windows.Forms.DateTimePicker();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.lbl_Anio = new System.Windows.Forms.Label();
            this.lbl_Director = new System.Windows.Forms.Label();
            this.lbl_Peliculas = new System.Windows.Forms.Label();
            this.lbl_Lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Peliculas
            // 
            this.lst_Peliculas.FormattingEnabled = true;
            this.lst_Peliculas.ItemHeight = 20;
            this.lst_Peliculas.Location = new System.Drawing.Point(626, 126);
            this.lst_Peliculas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Peliculas.Name = "lst_Peliculas";
            this.lst_Peliculas.Size = new System.Drawing.Size(333, 204);
            this.lst_Peliculas.TabIndex = 0;
            this.lst_Peliculas.SelectedIndexChanged += new System.EventHandler(this.lst_Peliculas_SelectedIndexChanged);
            this.lst_Peliculas.DoubleClick += new System.EventHandler(this.lst_Peliculas_DoubleClick);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(191, 390);
            this.btn_Grabar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(137, 65);
            this.btn_Grabar.TabIndex = 1;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(355, 390);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(137, 65);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(509, 390);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(137, 65);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(663, 390);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(137, 65);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(822, 390);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(137, 65);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(191, 126);
            this.txt_Titulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(390, 26);
            this.txt_Titulo.TabIndex = 6;
            // 
            // txt_Genero
            // 
            this.txt_Genero.Location = new System.Drawing.Point(191, 185);
            this.txt_Genero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Genero.Name = "txt_Genero";
            this.txt_Genero.Size = new System.Drawing.Size(390, 26);
            this.txt_Genero.TabIndex = 7;
            // 
            // txt_Director
            // 
            this.txt_Director.Location = new System.Drawing.Point(191, 302);
            this.txt_Director.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(390, 26);
            this.txt_Director.TabIndex = 9;
            // 
            // dtp_Anio
            // 
            this.dtp_Anio.Location = new System.Drawing.Point(191, 243);
            this.dtp_Anio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_Anio.Name = "dtp_Anio";
            this.dtp_Anio.Size = new System.Drawing.Size(390, 26);
            this.dtp_Anio.TabIndex = 10;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(132, 126);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(51, 20);
            this.lbl_Titulo.TabIndex = 11;
            this.lbl_Titulo.Text = "Titulo:";
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(116, 188);
            this.lbl_Genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(67, 20);
            this.lbl_Genero.TabIndex = 12;
            this.lbl_Genero.Text = "Genero:";
            // 
            // lbl_Anio
            // 
            this.lbl_Anio.AutoSize = true;
            this.lbl_Anio.Location = new System.Drawing.Point(138, 243);
            this.lbl_Anio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Anio.Name = "lbl_Anio";
            this.lbl_Anio.Size = new System.Drawing.Size(45, 20);
            this.lbl_Anio.TabIndex = 13;
            this.lbl_Anio.Text = "Anio:";
            // 
            // lbl_Director
            // 
            this.lbl_Director.AutoSize = true;
            this.lbl_Director.Location = new System.Drawing.Point(114, 302);
            this.lbl_Director.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Director.Name = "lbl_Director";
            this.lbl_Director.Size = new System.Drawing.Size(69, 20);
            this.lbl_Director.TabIndex = 14;
            this.lbl_Director.Text = "Director:";
            // 
            // lbl_Peliculas
            // 
            this.lbl_Peliculas.AutoSize = true;
            this.lbl_Peliculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peliculas.Location = new System.Drawing.Point(186, 51);
            this.lbl_Peliculas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Peliculas.Name = "lbl_Peliculas";
            this.lbl_Peliculas.Size = new System.Drawing.Size(151, 29);
            this.lbl_Peliculas.TabIndex = 15;
            this.lbl_Peliculas.Text = "PELICULAS";
            // 
            // lbl_Lista
            // 
            this.lbl_Lista.AutoSize = true;
            this.lbl_Lista.Location = new System.Drawing.Point(622, 101);
            this.lbl_Lista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lista.Name = "lbl_Lista";
            this.lbl_Lista.Size = new System.Drawing.Size(135, 20);
            this.lbl_Lista.TabIndex = 16;
            this.lbl_Lista.Text = "Lista de Peliculas:";
            // 
            // frm_Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 501);
            this.Controls.Add(this.lbl_Lista);
            this.Controls.Add(this.lbl_Peliculas);
            this.Controls.Add(this.lbl_Director);
            this.Controls.Add(this.lbl_Anio);
            this.Controls.Add(this.lbl_Genero);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.dtp_Anio);
            this.Controls.Add(this.txt_Director);
            this.Controls.Add(this.txt_Genero);
            this.Controls.Add(this.txt_Titulo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.lst_Peliculas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Peliculas";
            this.Text = "frm_Peliculas";
            this.Load += new System.EventHandler(this.frm_Peliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Peliculas;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Genero;
        private System.Windows.Forms.TextBox txt_Director;
        private System.Windows.Forms.DateTimePicker dtp_Anio;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Label lbl_Anio;
        private System.Windows.Forms.Label lbl_Director;
        private System.Windows.Forms.Label lbl_Peliculas;
        private System.Windows.Forms.Label lbl_Lista;
    }
}