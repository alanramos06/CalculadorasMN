namespace CalculadoraSimpsonPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labDato = new System.Windows.Forms.Label();
            this.labUltimoDato = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.NumericUpDown();
            this.txtA = new System.Windows.Forms.NumericUpDown();
            this.txtB = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de puntos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de b:";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtResultado);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.btnCalcular);
            this.gbDatos.Controls.Add(this.labDato);
            this.gbDatos.Controls.Add(this.labUltimoDato);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.txtFX);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Location = new System.Drawing.Point(12, 97);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(301, 151);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(74, 119);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(10, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labDato
            // 
            this.labDato.AutoSize = true;
            this.labDato.Location = new System.Drawing.Point(118, 53);
            this.labDato.Name = "labDato";
            this.labDato.Size = new System.Drawing.Size(0, 13);
            this.labDato.TabIndex = 4;
            // 
            // labUltimoDato
            // 
            this.labUltimoDato.AutoSize = true;
            this.labUltimoDato.Location = new System.Drawing.Point(7, 53);
            this.labUltimoDato.Name = "labUltimoDato";
            this.labUltimoDato.Size = new System.Drawing.Size(111, 13);
            this.labUltimoDato.TabIndex = 3;
            this.labUltimoDato.Text = "Último dato agregado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(220, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFX
            // 
            this.txtFX.DecimalPlaces = 10;
            this.txtFX.Location = new System.Drawing.Point(86, 18);
            this.txtFX.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtFX.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.txtFX.Name = "txtFX";
            this.txtFX.Size = new System.Drawing.Size(120, 20);
            this.txtFX.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Función de X:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(115, 7);
            this.txtN.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.txtN.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(81, 20);
            this.txtN.TabIndex = 4;
            this.txtN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtA
            // 
            this.txtA.DecimalPlaces = 10;
            this.txtA.Location = new System.Drawing.Point(76, 34);
            this.txtA.Maximum = new decimal(new int[] {
            404635648,
            395812,
            0,
            0});
            this.txtA.Minimum = new decimal(new int[] {
            404635648,
            395812,
            0,
            -2147483648});
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.DecimalPlaces = 10;
            this.txtB.Location = new System.Drawing.Point(76, 59);
            this.txtB.Maximum = new decimal(new int[] {
            404635648,
            395812,
            0,
            0});
            this.txtB.Minimum = new decimal(new int[] {
            404635648,
            395812,
            0,
            -2147483648});
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 20);
            this.txtB.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(222, 34);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 257);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora Simpson";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.NumericUpDown txtN;
        private System.Windows.Forms.NumericUpDown txtA;
        private System.Windows.Forms.NumericUpDown txtB;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labDato;
        private System.Windows.Forms.Label labUltimoDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown txtFX;
        private System.Windows.Forms.Label label4;
    }
}

