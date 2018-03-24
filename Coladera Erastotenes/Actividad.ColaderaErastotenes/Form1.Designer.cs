namespace Actividad.ColaderaErastotenes
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
            this.btnObtenerPrimos = new System.Windows.Forms.Button();
            this.txtbxPrimos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnObtenerPrimos
            // 
            this.btnObtenerPrimos.AutoSize = true;
            this.btnObtenerPrimos.Location = new System.Drawing.Point(31, 47);
            this.btnObtenerPrimos.Name = "btnObtenerPrimos";
            this.btnObtenerPrimos.Size = new System.Drawing.Size(89, 34);
            this.btnObtenerPrimos.TabIndex = 0;
            this.btnObtenerPrimos.Text = "Generar";
            this.btnObtenerPrimos.UseVisualStyleBackColor = true;
            this.btnObtenerPrimos.Click += new System.EventHandler(this.btnObtenerPrimos_Click);
            // 
            // txtbxPrimos
            // 
            this.txtbxPrimos.Location = new System.Drawing.Point(126, 35);
            this.txtbxPrimos.Multiline = true;
            this.txtbxPrimos.Name = "txtbxPrimos";
            this.txtbxPrimos.Size = new System.Drawing.Size(449, 46);
            this.txtbxPrimos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 127);
            this.Controls.Add(this.txtbxPrimos);
            this.Controls.Add(this.btnObtenerPrimos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerPrimos;
        private System.Windows.Forms.TextBox txtbxPrimos;
    }
}

