namespace Segundo_Examen_Parcial
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
            this.botonreporte = new System.Windows.Forms.Button();
            this.botonprestamos = new System.Windows.Forms.Button();
            this.botonlectores = new System.Windows.Forms.Button();
            this.botonlibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonreporte
            // 
            this.botonreporte.BackColor = System.Drawing.Color.Pink;
            this.botonreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonreporte.Location = new System.Drawing.Point(105, 173);
            this.botonreporte.Margin = new System.Windows.Forms.Padding(2);
            this.botonreporte.Name = "botonreporte";
            this.botonreporte.Size = new System.Drawing.Size(119, 56);
            this.botonreporte.TabIndex = 7;
            this.botonreporte.Text = "Reporte";
            this.botonreporte.UseVisualStyleBackColor = false;
            // 
            // botonprestamos
            // 
            this.botonprestamos.BackColor = System.Drawing.Color.Pink;
            this.botonprestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonprestamos.Location = new System.Drawing.Point(105, 233);
            this.botonprestamos.Margin = new System.Windows.Forms.Padding(2);
            this.botonprestamos.Name = "botonprestamos";
            this.botonprestamos.Size = new System.Drawing.Size(119, 56);
            this.botonprestamos.TabIndex = 6;
            this.botonprestamos.Text = "Prestamos";
            this.botonprestamos.UseVisualStyleBackColor = false;
            // 
            // botonlectores
            // 
            this.botonlectores.BackColor = System.Drawing.Color.Pink;
            this.botonlectores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlectores.Location = new System.Drawing.Point(105, 108);
            this.botonlectores.Margin = new System.Windows.Forms.Padding(2);
            this.botonlectores.Name = "botonlectores";
            this.botonlectores.Size = new System.Drawing.Size(119, 56);
            this.botonlectores.TabIndex = 5;
            this.botonlectores.Text = "Lectores";
            this.botonlectores.UseVisualStyleBackColor = false;
            // 
            // botonlibros
            // 
            this.botonlibros.BackColor = System.Drawing.Color.Pink;
            this.botonlibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonlibros.Location = new System.Drawing.Point(105, 48);
            this.botonlibros.Margin = new System.Windows.Forms.Padding(2);
            this.botonlibros.Name = "botonlibros";
            this.botonlibros.Size = new System.Drawing.Size(119, 56);
            this.botonlibros.TabIndex = 4;
            this.botonlibros.Text = "Libros";
            this.botonlibros.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 340);
            this.Controls.Add(this.botonreporte);
            this.Controls.Add(this.botonprestamos);
            this.Controls.Add(this.botonlectores);
            this.Controls.Add(this.botonlibros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonreporte;
        private System.Windows.Forms.Button botonprestamos;
        private System.Windows.Forms.Button botonlectores;
        private System.Windows.Forms.Button botonlibros;
    }
}

