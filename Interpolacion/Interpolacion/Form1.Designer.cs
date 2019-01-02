namespace Interpolacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorF = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.btnAgregarX = new System.Windows.Forms.Button();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.labResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cuántos datos desea utilizar?";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(170, 10);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(100, 20);
            this.txtDatos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posición del dato:";
            // 
            // txtValorX
            // 
            this.txtValorX.Location = new System.Drawing.Point(110, 48);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(100, 20);
            this.txtValorX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medición del dato:";
            // 
            // txtValorF
            // 
            this.txtValorF.Location = new System.Drawing.Point(110, 80);
            this.txtValorF.Name = "txtValorF";
            this.txtValorF.Size = new System.Drawing.Size(100, 20);
            this.txtValorF.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(266, 292);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(13, 291);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posición que desea calcluar:";
            // 
            // txtCalcular
            // 
            this.txtCalcular.Location = new System.Drawing.Point(162, 109);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(100, 20);
            this.txtCalcular.TabIndex = 9;
            // 
            // btnAgregarX
            // 
            this.btnAgregarX.Location = new System.Drawing.Point(216, 46);
            this.btnAgregarX.Name = "btnAgregarX";
            this.btnAgregarX.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarX.TabIndex = 11;
            this.btnAgregarX.Text = "Agregar";
            this.btnAgregarX.UseVisualStyleBackColor = true;
            this.btnAgregarX.Click += new System.EventHandler(this.btnAgregarX_Click);
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(216, 78);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarF.TabIndex = 12;
            this.btnAgregarF.Text = "Agregar";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // labResultado
            // 
            this.labResultado.AutoSize = true;
            this.labResultado.Location = new System.Drawing.Point(13, 150);
            this.labResultado.Name = "labResultado";
            this.labResultado.Size = new System.Drawing.Size(58, 13);
            this.labResultado.TabIndex = 13;
            this.labResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(77, 147);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 327);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.labResultado);
            this.Controls.Add(this.btnAgregarF);
            this.Controls.Add(this.btnAgregarX);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorF;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.Button btnAgregarX;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.Label labResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

