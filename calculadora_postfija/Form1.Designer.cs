namespace calculadora_postfija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.btn_ordenar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_resultado2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_0 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.lbl_ordenada = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_resultado_final = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_operacion
            // 
            this.txt_operacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_operacion.Location = new System.Drawing.Point(9, 12);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.Size = new System.Drawing.Size(257, 26);
            this.txt_operacion.TabIndex = 0;
            // 
            // btn_ordenar
            // 
            this.btn_ordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ordenar.Location = new System.Drawing.Point(9, 47);
            this.btn_ordenar.Name = "btn_ordenar";
            this.btn_ordenar.Size = new System.Drawing.Size(84, 23);
            this.btn_ordenar.TabIndex = 1;
            this.btn_ordenar.Text = "ORDENAR";
            this.btn_ordenar.UseVisualStyleBackColor = true;
            this.btn_ordenar.Click += new System.EventHandler(this.btn_ordenar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(272, 14);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(119, 23);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "CALCULAR ===>";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(495, 185);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(39, 13);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "(vacio)";
            // 
            // lbl_resultado2
            // 
            this.lbl_resultado2.AutoSize = true;
            this.lbl_resultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado2.Location = new System.Drawing.Point(495, 228);
            this.lbl_resultado2.Name = "lbl_resultado2";
            this.lbl_resultado2.Size = new System.Drawing.Size(39, 13);
            this.lbl_resultado2.TabIndex = 8;
            this.lbl_resultado2.Text = "(vacio)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "2do num del arreglo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "1er  num del arreglo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Top";
            // 
            // txt_0
            // 
            this.txt_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_0.Location = new System.Drawing.Point(437, 64);
            this.txt_0.Name = "txt_0";
            this.txt_0.Size = new System.Drawing.Size(69, 20);
            this.txt_0.TabIndex = 14;
            this.txt_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_1.Location = new System.Drawing.Point(437, 42);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(69, 20);
            this.txt_1.TabIndex = 15;
            this.txt_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_2.Location = new System.Drawing.Point(437, 19);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(69, 20);
            this.txt_2.TabIndex = 16;
            this.txt_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ordenada
            // 
            this.lbl_ordenada.AutoSize = true;
            this.lbl_ordenada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordenada.Location = new System.Drawing.Point(495, 208);
            this.lbl_ordenada.Name = "lbl_ordenada";
            this.lbl_ordenada.Size = new System.Drawing.Size(39, 13);
            this.lbl_ordenada.TabIndex = 6;
            this.lbl_ordenada.Text = "(vacio)";
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(6, 87);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(385, 152);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = resources.GetString("lbl_title.Text");
            // 
            // lbl_resultado_final
            // 
            this.lbl_resultado_final.BackColor = System.Drawing.Color.Lime;
            this.lbl_resultado_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado_final.ForeColor = System.Drawing.Color.Black;
            this.lbl_resultado_final.Location = new System.Drawing.Point(397, 113);
            this.lbl_resultado_final.Name = "lbl_resultado_final";
            this.lbl_resultado_final.Size = new System.Drawing.Size(131, 54);
            this.lbl_resultado_final.TabIndex = 17;
            this.lbl_resultado_final.Text = "(vacio)";
            this.lbl_resultado_final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resultado_final.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Num de clic calcular:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_resultado_final);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.txt_0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_resultado2);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_ordenada);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_ordenar);
            this.Controls.Add(this.txt_operacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.Button btn_ordenar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_resultado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_0;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label lbl_ordenada;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_resultado_final;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

