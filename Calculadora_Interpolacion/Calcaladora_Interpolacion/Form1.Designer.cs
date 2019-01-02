namespace Calcaladora_Interpolacion
{
    partial class Form1
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
            this.txtDatos = new System.Windows.Forms.NumericUpDown();
            this.txtValorX = new System.Windows.Forms.NumericUpDown();
            this.txtValorFx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPunto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPunto)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(119, 66);
            this.txtDatos.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(50, 20);
            this.txtDatos.TabIndex = 0;
            this.txtDatos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // txtValorX
            // 
            this.txtValorX.DecimalPlaces = 6;
            this.txtValorX.Location = new System.Drawing.Point(150, 25);
            this.txtValorX.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtValorX.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(95, 20);
            this.txtValorX.TabIndex = 1;
            // 
            // txtValorFx
            // 
            this.txtValorFx.DecimalPlaces = 6;
            this.txtValorFx.Location = new System.Drawing.Point(150, 61);
            this.txtValorFx.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtValorFx.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.txtValorFx.Name = "txtValorFx";
            this.txtValorFx.Size = new System.Drawing.Size(95, 20);
            this.txtValorFx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor de X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor de la función de X:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(69, 119);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(176, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado:";
            // 
            // txtPunto
            // 
            this.txtPunto.DecimalPlaces = 6;
            this.txtPunto.Location = new System.Drawing.Point(119, 106);
            this.txtPunto.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtPunto.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.txtPunto.Name = "txtPunto";
            this.txtPunto.Size = new System.Drawing.Size(95, 20);
            this.txtPunto.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dato a encontrar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Datos que usará:";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.btnCalcular);
            this.groupBoxDatos.Controls.Add(this.btnAgregar);
            this.groupBoxDatos.Controls.Add(this.label3);
            this.groupBoxDatos.Controls.Add(this.label4);
            this.groupBoxDatos.Controls.Add(this.txtValorX);
            this.groupBoxDatos.Controls.Add(this.txtValorFx);
            this.groupBoxDatos.Controls.Add(this.txtResultado);
            this.groupBoxDatos.Controls.Add(this.label5);
            this.groupBoxDatos.Location = new System.Drawing.Point(26, 147);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(349, 148);
            this.groupBoxDatos.TabIndex = 15;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Ingresar datos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(265, 116);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(265, 44);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(238, 79);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(389, 308);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPunto);
            this.Controls.Add(this.txtDatos);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Método de Interpolación";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.txtDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPunto)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtDatos;
        private System.Windows.Forms.NumericUpDown txtValorX;
        private System.Windows.Forms.NumericUpDown txtValorFx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtPunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

