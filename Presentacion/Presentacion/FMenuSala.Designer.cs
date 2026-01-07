namespace Presentacion
{
    partial class FMenuSala
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
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMisPrestamos = new System.Windows.Forms.Button();
            this.btnAtrasados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(163, 134);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(115, 45);
            this.btnNuevoPrestamo.TabIndex = 0;
            this.btnNuevoPrestamo.Text = "Nuevo Préstamo";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Location = new System.Drawing.Point(367, 134);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(108, 45);
            this.btnDevolucion.TabIndex = 1;
            this.btnDevolucion.Text = "Devolver Libro";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(550, 134);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(103, 45);
            this.btnGestionUsuarios.TabIndex = 2;
            this.btnGestionUsuarios.Text = "Gestión Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(578, 313);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMisPrestamos
            // 
            this.btnMisPrestamos.Location = new System.Drawing.Point(163, 227);
            this.btnMisPrestamos.Name = "btnMisPrestamos";
            this.btnMisPrestamos.Size = new System.Drawing.Size(115, 45);
            this.btnMisPrestamos.TabIndex = 4;
            this.btnMisPrestamos.Text = "Ver Mis Préstamos";
            this.btnMisPrestamos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMisPrestamos.UseVisualStyleBackColor = true;
            this.btnMisPrestamos.Click += new System.EventHandler(this.btnMisPrestamos_Click);
            // 
            // btnAtrasados
            // 
            this.btnAtrasados.Location = new System.Drawing.Point(367, 227);
            this.btnAtrasados.Name = "btnAtrasados";
            this.btnAtrasados.Size = new System.Drawing.Size(108, 45);
            this.btnAtrasados.TabIndex = 5;
            this.btnAtrasados.Text = "Préstamos Atrasados";
            this.btnAtrasados.UseVisualStyleBackColor = true;
            this.btnAtrasados.Click += new System.EventHandler(this.btnAtrasados_Click);
            // 
            // FMenuSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrasados);
            this.Controls.Add(this.btnMisPrestamos);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnNuevoPrestamo);
            this.Name = "FMenuSala";
            this.Text = "FMenuSala";
            this.Load += new System.EventHandler(this.FMenuSala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnMisPrestamos;
        private System.Windows.Forms.Button btnAtrasados;
    }
}