namespace biseccion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.masa = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.velocidad = new System.Windows.Forms.TextBox();
            this.gravedad = new System.Windows.Forms.TextBox();
            this.ers = new System.Windows.Forms.TextBox();
            this.C1 = new System.Windows.Forms.TextBox();
            this.C2 = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.it = new System.Windows.Forms.TextBox();
            this.bis = new System.Windows.Forms.Button();
            this.fc2 = new System.Windows.Forms.TextBox();
            this.fc1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.era = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Button();
            this.pf = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aceptar = new System.Windows.Forms.Button();
            this.ndatos = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.fx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.x0 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.xn = new System.Windows.Forms.NumericUpDown();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fxn = new System.Windows.Forms.NumericUpDown();
            this.Agregar = new System.Windows.Forms.Button();
            this.agrex = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndatos)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "m =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "t =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "v =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "g =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Es =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "c1 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "c2 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "El valor es ";
            // 
            // masa
            // 
            this.masa.Location = new System.Drawing.Point(75, 26);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(60, 20);
            this.masa.TabIndex = 8;
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(75, 68);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(60, 20);
            this.tiempo.TabIndex = 9;
            // 
            // velocidad
            // 
            this.velocidad.Location = new System.Drawing.Point(75, 110);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(60, 20);
            this.velocidad.TabIndex = 10;
            // 
            // gravedad
            // 
            this.gravedad.Location = new System.Drawing.Point(75, 152);
            this.gravedad.Name = "gravedad";
            this.gravedad.ReadOnly = true;
            this.gravedad.Size = new System.Drawing.Size(60, 20);
            this.gravedad.TabIndex = 11;
            // 
            // ers
            // 
            this.ers.Location = new System.Drawing.Point(75, 194);
            this.ers.Name = "ers";
            this.ers.Size = new System.Drawing.Size(60, 20);
            this.ers.TabIndex = 12;
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(75, 236);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(60, 20);
            this.C1.TabIndex = 13;
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(75, 278);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(60, 20);
            this.C2.TabIndex = 14;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(319, 23);
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Size = new System.Drawing.Size(60, 20);
            this.valor.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "No. de iteraciones";
            // 
            // it
            // 
            this.it.Location = new System.Drawing.Point(319, 68);
            this.it.Name = "it";
            this.it.ReadOnly = true;
            this.it.Size = new System.Drawing.Size(60, 20);
            this.it.TabIndex = 17;
            // 
            // bis
            // 
            this.bis.Location = new System.Drawing.Point(319, 155);
            this.bis.Name = "bis";
            this.bis.Size = new System.Drawing.Size(75, 23);
            this.bis.TabIndex = 18;
            this.bis.Text = "Bisección";
            this.bis.UseVisualStyleBackColor = true;
            this.bis.Click += new System.EventHandler(this.calcular_Click);
            // 
            // fc2
            // 
            this.fc2.Location = new System.Drawing.Point(200, 278);
            this.fc2.Name = "fc2";
            this.fc2.ReadOnly = true;
            this.fc2.Size = new System.Drawing.Size(60, 20);
            this.fc2.TabIndex = 22;
            // 
            // fc1
            // 
            this.fc1.Location = new System.Drawing.Point(200, 236);
            this.fc1.Name = "fc1";
            this.fc1.ReadOnly = true;
            this.fc1.Size = new System.Drawing.Size(60, 20);
            this.fc1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "f(c2) =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "f(c1) = ";
            // 
            // era
            // 
            this.era.Location = new System.Drawing.Point(319, 110);
            this.era.Name = "era";
            this.era.ReadOnly = true;
            this.era.Size = new System.Drawing.Size(60, 20);
            this.era.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Error aproximado";
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(319, 197);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(75, 23);
            this.sec.TabIndex = 25;
            this.sec.Text = "Secante";
            this.sec.UseVisualStyleBackColor = true;
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // pf
            // 
            this.pf.Location = new System.Drawing.Point(319, 242);
            this.pf.Name = "pf";
            this.pf.Size = new System.Drawing.Size(75, 23);
            this.pf.TabIndex = 26;
            this.pf.Text = "Punto fijo";
            this.pf.UseVisualStyleBackColor = true;
            this.pf.Click += new System.EventHandler(this.pf_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 359);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pf);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.sec);
            this.tabPage1.Controls.Add(this.C1);
            this.tabPage1.Controls.Add(this.era);
            this.tabPage1.Controls.Add(this.tiempo);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fc2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.masa);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ers);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.C2);
            this.tabPage1.Controls.Add(this.bis);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.fc1);
            this.tabPage1.Controls.Add(this.velocidad);
            this.tabPage1.Controls.Add(this.valor);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.gravedad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.it);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primera unidad";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aceptar);
            this.tabPage2.Controls.Add(this.ndatos);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.groupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interpolación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(270, 42);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 13;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // ndatos
            // 
            this.ndatos.Location = new System.Drawing.Point(103, 45);
            this.ndatos.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.ndatos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndatos.Name = "ndatos";
            this.ndatos.Size = new System.Drawing.Size(120, 20);
            this.ndatos.TabIndex = 12;
            this.ndatos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "label16";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.agrex);
            this.groupBox.Controls.Add(this.fx);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.x0);
            this.groupBox.Controls.Add(this.calcular);
            this.groupBox.Controls.Add(this.xn);
            this.groupBox.Controls.Add(this.X);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.fxn);
            this.groupBox.Controls.Add(this.Agregar);
            this.groupBox.Location = new System.Drawing.Point(23, 109);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(355, 209);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Agregar datos";
            this.groupBox.Visible = false;
            // 
            // fx
            // 
            this.fx.Location = new System.Drawing.Point(80, 182);
            this.fx.Name = "fx";
            this.fx.ReadOnly = true;
            this.fx.Size = new System.Drawing.Size(100, 20);
            this.fx.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "f(x)";
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(12, 23);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(41, 13);
            this.x0.TabIndex = 0;
            this.x0.Text = "X0";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(247, 177);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click_1);
            // 
            // xn
            // 
            this.xn.DecimalPlaces = 9;
            this.xn.Location = new System.Drawing.Point(80, 23);
            this.xn.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.xn.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.xn.Name = "xn";
            this.xn.Size = new System.Drawing.Size(120, 20);
            this.xn.TabIndex = 1;
            // 
            // X
            // 
            this.X.DecimalPlaces = 9;
            this.X.Location = new System.Drawing.Point(80, 129);
            this.X.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.X.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(120, 20);
            this.X.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "f(x0)";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "X";
            // 
            // fxn
            // 
            this.fxn.DecimalPlaces = 9;
            this.fxn.Location = new System.Drawing.Point(80, 76);
            this.fxn.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.fxn.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.fxn.Name = "fxn";
            this.fxn.Size = new System.Drawing.Size(120, 20);
            this.fxn.TabIndex = 3;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(247, 55);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 4;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // agrex
            // 
            this.agrex.Location = new System.Drawing.Point(247, 129);
            this.agrex.Name = "agrex";
            this.agrex.Size = new System.Drawing.Size(75, 23);
            this.agrex.TabIndex = 10;
            this.agrex.Text = "Agregar X";
            this.agrex.UseVisualStyleBackColor = true;
            this.agrex.Click += new System.EventHandler(this.agrex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 388);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "o";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndatos)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox masa;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.TextBox velocidad;
        private System.Windows.Forms.TextBox gravedad;
        private System.Windows.Forms.TextBox ers;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.TextBox C2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox it;
        private System.Windows.Forms.Button bis;
        private System.Windows.Forms.TextBox fc2;
        private System.Windows.Forms.TextBox fc1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox era;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Button pf;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown xn;
        private System.Windows.Forms.Label x0;
        private System.Windows.Forms.TextBox fx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.NumericUpDown fxn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown ndatos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button agrex;
    }
}

