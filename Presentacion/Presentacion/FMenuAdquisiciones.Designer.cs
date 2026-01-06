namespace Presentacion
{
    partial class FMenuAdquisiciones
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
            this.btnAltaDocumento = new System.Windows.Forms.Button();
            this.btnAltaEjemplar = new System.Windows.Forms.Button();
            this.btnBajaEjemplar = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaDocumento
            // 
            this.btnAltaDocumento.Location = new System.Drawing.Point(87, 92);
            this.btnAltaDocumento.Name = "btnAltaDocumento";
            this.btnAltaDocumento.Size = new System.Drawing.Size(154, 60);
            this.btnAltaDocumento.TabIndex = 0;
            this.btnAltaDocumento.Text = "Nuevo Libro/AudioLibro";
            this.btnAltaDocumento.UseVisualStyleBackColor = true;
            this.btnAltaDocumento.Click += new System.EventHandler(this.btnAltaDocumento_Click);
            // 
            // btnAltaEjemplar
            // 
            this.btnAltaEjemplar.Location = new System.Drawing.Point(291, 92);
            this.btnAltaEjemplar.Name = "btnAltaEjemplar";
            this.btnAltaEjemplar.Size = new System.Drawing.Size(94, 60);
            this.btnAltaEjemplar.TabIndex = 1;
            this.btnAltaEjemplar.Text = "Nuevo Ejemplar";
            this.btnAltaEjemplar.UseVisualStyleBackColor = true;
            this.btnAltaEjemplar.Click += new System.EventHandler(this.btnAltaEjemplar_Click);
            // 
            // btnBajaEjemplar
            // 
            this.btnBajaEjemplar.Location = new System.Drawing.Point(453, 92);
            this.btnBajaEjemplar.Name = "btnBajaEjemplar";
            this.btnBajaEjemplar.Size = new System.Drawing.Size(92, 60);
            this.btnBajaEjemplar.TabIndex = 2;
            this.btnBajaEjemplar.Text = "Baja Ejemplar";
            this.btnBajaEjemplar.UseVisualStyleBackColor = true;
            this.btnBajaEjemplar.Click += new System.EventHandler(this.btnBajaEjemplar_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.Location = new System.Drawing.Point(596, 92);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(98, 60);
            this.btnGestionUsuarios.TabIndex = 3;
            this.btnGestionUsuarios.Text = "Gestión de Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(104, 221);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(116, 53);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock (Disponibilidad)";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FMenuAdquisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnBajaEjemplar);
            this.Controls.Add(this.btnAltaEjemplar);
            this.Controls.Add(this.btnAltaDocumento);
            this.Name = "FMenuAdquisiciones";
            this.Text = "FMenuAdquisiciones";
            this.Load += new System.EventHandler(this.FMenuAdquisiciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaDocumento;
        private System.Windows.Forms.Button btnAltaEjemplar;
        private System.Windows.Forms.Button btnBajaEjemplar;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnStock;
    }
}