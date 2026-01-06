namespace Presentacion
{
    partial class FListadoDocumentos
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
            this.lstDocumentos = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDocumentos
            // 
            this.lstDocumentos.FormattingEnabled = true;
            this.lstDocumentos.ItemHeight = 16;
            this.lstDocumentos.Location = new System.Drawing.Point(74, 47);
            this.lstDocumentos.Name = "lstDocumentos";
            this.lstDocumentos.Size = new System.Drawing.Size(190, 228);
            this.lstDocumentos.TabIndex = 0;
            this.lstDocumentos.SelectedIndexChanged += new System.EventHandler(this.lstDocumentos_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(339, 305);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FListadoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 377);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lstDocumentos);
            this.Name = "FListadoDocumentos";
            this.Text = "FListadoDocumentos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDocumentos;
        private System.Windows.Forms.Button btnCerrar;
    }
}