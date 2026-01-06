namespace Presentacion
{
    partial class FAltaPrestamo
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
            this.txtDniUsuario = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtCodigoEjemplar = new System.Windows.Forms.TextBox();
            this.lstEjemplares = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDniUsuario
            // 
            this.txtDniUsuario.Location = new System.Drawing.Point(64, 56);
            this.txtDniUsuario.Name = "txtDniUsuario";
            this.txtDniUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtDniUsuario.TabIndex = 0;
            this.txtDniUsuario.Text = "Dni";
            this.txtDniUsuario.TextChanged += new System.EventHandler(this.txtDniUsuario_TextChanged);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(292, 56);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 22);
            this.txtIsbn.TabIndex = 1;
            this.txtIsbn.Text = "ISBN";
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // txtCodigoEjemplar
            // 
            this.txtCodigoEjemplar.Location = new System.Drawing.Point(507, 56);
            this.txtCodigoEjemplar.Name = "txtCodigoEjemplar";
            this.txtCodigoEjemplar.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoEjemplar.TabIndex = 2;
            this.txtCodigoEjemplar.Text = "CodEjemplar";
            this.txtCodigoEjemplar.TextChanged += new System.EventHandler(this.txtCodigoEjemplar_TextChanged);
            // 
            // lstEjemplares
            // 
            this.lstEjemplares.FormattingEnabled = true;
            this.lstEjemplares.ItemHeight = 16;
            this.lstEjemplares.Location = new System.Drawing.Point(206, 285);
            this.lstEjemplares.Name = "lstEjemplares";
            this.lstEjemplares.Size = new System.Drawing.Size(227, 116);
            this.lstEjemplares.TabIndex = 3;
            this.lstEjemplares.SelectedIndexChanged += new System.EventHandler(this.lstEjemplares_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(156, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 65);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Añadir a la lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(382, 119);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(139, 65);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Confirmar Préstamo";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstEjemplares);
            this.Controls.Add(this.txtCodigoEjemplar);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtDniUsuario);
            this.Name = "FAltaPrestamo";
            this.Text = "FAltaPrestamo";
            this.Load += new System.EventHandler(this.FAltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniUsuario;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtCodigoEjemplar;
        private System.Windows.Forms.ListBox lstEjemplares;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}