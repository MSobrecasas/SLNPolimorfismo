namespace WindowsFormsPolimorfismo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearAvionCarga = new System.Windows.Forms.Button();
            this.btnCrearAvionComercial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearAvionCarga
            // 
            this.btnCrearAvionCarga.Location = new System.Drawing.Point(280, 81);
            this.btnCrearAvionCarga.Name = "btnCrearAvionCarga";
            this.btnCrearAvionCarga.Size = new System.Drawing.Size(191, 23);
            this.btnCrearAvionCarga.TabIndex = 0;
            this.btnCrearAvionCarga.Text = "Crear Avion Carga";
            this.btnCrearAvionCarga.UseVisualStyleBackColor = true;
            this.btnCrearAvionCarga.Click += new System.EventHandler(this.btnCrearAvionCarga_Click);
            // 
            // btnCrearAvionComercial
            // 
            this.btnCrearAvionComercial.Location = new System.Drawing.Point(280, 196);
            this.btnCrearAvionComercial.Name = "btnCrearAvionComercial";
            this.btnCrearAvionComercial.Size = new System.Drawing.Size(191, 23);
            this.btnCrearAvionComercial.TabIndex = 1;
            this.btnCrearAvionComercial.Text = "Crear Avion Comercial";
            this.btnCrearAvionComercial.UseVisualStyleBackColor = true;
            this.btnCrearAvionComercial.Click += new System.EventHandler(this.btnCrearAvionComercial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearAvionComercial);
            this.Controls.Add(this.btnCrearAvionCarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearAvionCarga;
        private System.Windows.Forms.Button btnCrearAvionComercial;
    }
}

