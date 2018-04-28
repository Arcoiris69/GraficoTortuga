namespace Graficos_por_Tortuga
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
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.btnGirarD = new System.Windows.Forms.Button();
            this.btnGirarI = new System.Windows.Forms.Button();
            this.btnpluma = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(23, 21);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(85, 23);
            this.btnAvanzar.TabIndex = 0;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(311, 102);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Mostrar";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(23, 131);
            this.txtImprimir.Multiline = true;
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(379, 251);
            this.txtImprimir.TabIndex = 2;
            // 
            // btnGirarD
            // 
            this.btnGirarD.Location = new System.Drawing.Point(23, 79);
            this.btnGirarD.Name = "btnGirarD";
            this.btnGirarD.Size = new System.Drawing.Size(85, 23);
            this.btnGirarD.TabIndex = 3;
            this.btnGirarD.Text = "Girar Derecha";
            this.btnGirarD.UseVisualStyleBackColor = true;
            this.btnGirarD.Click += new System.EventHandler(this.btnGirarD_Click);
            // 
            // btnGirarI
            // 
            this.btnGirarI.Location = new System.Drawing.Point(23, 50);
            this.btnGirarI.Name = "btnGirarI";
            this.btnGirarI.Size = new System.Drawing.Size(85, 23);
            this.btnGirarI.TabIndex = 4;
            this.btnGirarI.Text = "Girar Izquierda";
            this.btnGirarI.UseVisualStyleBackColor = true;
            this.btnGirarI.Click += new System.EventHandler(this.btnGirarI_Click);
            // 
            // btnpluma
            // 
            this.btnpluma.Location = new System.Drawing.Point(188, 37);
            this.btnpluma.Name = "btnpluma";
            this.btnpluma.Size = new System.Drawing.Size(100, 23);
            this.btnpluma.TabIndex = 5;
            this.btnpluma.Text = "Pluma Abajo";
            this.btnpluma.UseVisualStyleBackColor = true;
            this.btnpluma.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(311, 29);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(91, 31);
            this.txtPasos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Pasos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado de la pluma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 394);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.btnpluma);
            this.Controls.Add(this.btnGirarI);
            this.Controls.Add(this.btnGirarD);
            this.Controls.Add(this.txtImprimir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAvanzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.Button btnGirarD;
        private System.Windows.Forms.Button btnGirarI;
        private System.Windows.Forms.Button btnpluma;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

