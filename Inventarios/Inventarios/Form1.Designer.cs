namespace Inventarios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_anios = new System.Windows.Forms.TextBox();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.txt_conservacion = new System.Windows.Forms.TextBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_calculando = new System.Windows.Forms.Label();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 307);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(132, 53);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // pgb
            // 
            this.pgb.BackColor = System.Drawing.Color.Black;
            this.pgb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgb.Location = new System.Drawing.Point(211, 362);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(519, 25);
            this.pgb.TabIndex = 1;
            this.pgb.UseWaitCursor = true;
            this.pgb.Value = 100;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 390);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(132, 51);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_anios
            // 
            this.txt_anios.Location = new System.Drawing.Point(247, 72);
            this.txt_anios.Name = "txt_anios";
            this.txt_anios.Size = new System.Drawing.Size(171, 20);
            this.txt_anios.TabIndex = 3;
            // 
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(250, 132);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(168, 20);
            this.txt_orden.TabIndex = 4;
            // 
            // txt_conservacion
            // 
            this.txt_conservacion.Location = new System.Drawing.Point(250, 192);
            this.txt_conservacion.Name = "txt_conservacion";
            this.txt_conservacion.Size = new System.Drawing.Size(168, 20);
            this.txt_conservacion.TabIndex = 5;
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(641, 72);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(162, 20);
            this.txt_dias.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Demanda por años en unidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dame el numero de dias de entrega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(90, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo de ordenar por orden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(27, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Costo de conservacion por unidad por año";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(460, 139);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(58, 13);
            this.lbl_Resultado.TabIndex = 11;
            this.lbl_Resultado.Text = "Resultado:";
            // 
            // lbl_calculando
            // 
            this.lbl_calculando.AutoSize = true;
            this.lbl_calculando.BackColor = System.Drawing.Color.Transparent;
            this.lbl_calculando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_calculando.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculando.ForeColor = System.Drawing.Color.Blue;
            this.lbl_calculando.Location = new System.Drawing.Point(402, 319);
            this.lbl_calculando.Name = "lbl_calculando";
            this.lbl_calculando.Size = new System.Drawing.Size(116, 24);
            this.lbl_calculando.TabIndex = 12;
            this.lbl_calculando.Text = "Calcular ¿?";
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias.Location = new System.Drawing.Point(521, 29);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(255, 24);
            this.lbl_dias.TabIndex = 13;
            this.lbl_dias.Text = "¿Quieres el punto de reorden?";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(875, 466);
            this.Controls.Add(this.lbl_dias);
            this.Controls.Add(this.lbl_calculando);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dias);
            this.Controls.Add(this.txt_conservacion);
            this.Controls.Add(this.txt_orden);
            this.Controls.Add(this.txt_anios);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.btn_calcular);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_anios;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.TextBox txt_conservacion;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_calculando;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.Timer timer1;
    }
}

