namespace Presentacion
{
    partial class FPrestamosAtrasados
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
            this.lstAtrasados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAtrasados
            // 
            this.lstAtrasados.FormattingEnabled = true;
            this.lstAtrasados.ItemHeight = 16;
            this.lstAtrasados.Location = new System.Drawing.Point(102, 79);
            this.lstAtrasados.Name = "lstAtrasados";
            this.lstAtrasados.Size = new System.Drawing.Size(383, 228);
            this.lstAtrasados.TabIndex = 0;
            this.lstAtrasados.SelectedIndexChanged += new System.EventHandler(this.lstAtrasados_SelectedIndexChanged);
            // 
            // FPrestamosAtrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAtrasados);
            this.Name = "FPrestamosAtrasados";
            this.Text = "FPrestamosAtrasados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAtrasados;
    }
}