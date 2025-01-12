
namespace Forma_Geométrica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Valor4 = new System.Windows.Forms.TextBox();
            this.lbl_Valor4 = new System.Windows.Forms.Label();
            this.txt_Diâmetro = new System.Windows.Forms.TextBox();
            this.lbl_Instrução3 = new System.Windows.Forms.Label();
            this.lbl_Instrução2 = new System.Windows.Forms.Label();
            this.lbl_Instrução = new System.Windows.Forms.Label();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.txt_Valor3 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.lbl_Valor3 = new System.Windows.Forms.Label();
            this.lbl_Valor2 = new System.Windows.Forms.Label();
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.rb_Triângulo = new System.Windows.Forms.RadioButton();
            this.rb_Quadrilátero = new System.Windows.Forms.RadioButton();
            this.rb_Circulo = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Valor4
            // 
            this.txt_Valor4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Valor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Valor4.Location = new System.Drawing.Point(405, 320);
            this.txt_Valor4.Name = "txt_Valor4";
            this.txt_Valor4.Size = new System.Drawing.Size(191, 26);
            this.txt_Valor4.TabIndex = 86;
            this.txt_Valor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Valor4
            // 
            this.lbl_Valor4.AutoSize = true;
            this.lbl_Valor4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor4.Location = new System.Drawing.Point(185, 319);
            this.lbl_Valor4.Name = "lbl_Valor4";
            this.lbl_Valor4.Size = new System.Drawing.Size(195, 26);
            this.lbl_Valor4.TabIndex = 85;
            this.lbl_Valor4.Text = "Digite o quarto valor!";
            // 
            // txt_Diâmetro
            // 
            this.txt_Diâmetro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Diâmetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diâmetro.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Diâmetro.Location = new System.Drawing.Point(40, 411);
            this.txt_Diâmetro.Name = "txt_Diâmetro";
            this.txt_Diâmetro.Size = new System.Drawing.Size(191, 26);
            this.txt_Diâmetro.TabIndex = 84;
            this.txt_Diâmetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Instrução3
            // 
            this.lbl_Instrução3.AutoSize = true;
            this.lbl_Instrução3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrução3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Instrução3.Location = new System.Drawing.Point(35, 370);
            this.lbl_Instrução3.Name = "lbl_Instrução3";
            this.lbl_Instrução3.Size = new System.Drawing.Size(337, 26);
            this.lbl_Instrução3.TabIndex = 83;
            this.lbl_Instrução3.Text = "Caso seja circulo, informe o diâmetro";
            // 
            // lbl_Instrução2
            // 
            this.lbl_Instrução2.AutoSize = true;
            this.lbl_Instrução2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrução2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Instrução2.Location = new System.Drawing.Point(146, 96);
            this.lbl_Instrução2.Name = "lbl_Instrução2";
            this.lbl_Instrução2.Size = new System.Drawing.Size(485, 26);
            this.lbl_Instrução2.TabIndex = 82;
            this.lbl_Instrução2.Text = "Digite os valores! Caso seja Triângulo ou Quadrilátero.";
            // 
            // lbl_Instrução
            // 
            this.lbl_Instrução.AutoSize = true;
            this.lbl_Instrução.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrução.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Instrução.Location = new System.Drawing.Point(266, 10);
            this.lbl_Instrução.Name = "lbl_Instrução";
            this.lbl_Instrução.Size = new System.Drawing.Size(291, 26);
            this.lbl_Instrução.TabIndex = 81;
            this.lbl_Instrução.Text = "Escolha uma Forma Geométrica!";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Resultado.Location = new System.Drawing.Point(393, 370);
            this.txt_Resultado.Multiline = true;
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(373, 71);
            this.txt_Resultado.TabIndex = 80;
            this.txt_Resultado.Text = "Resultado";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Valor3
            // 
            this.txt_Valor3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Valor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Valor3.Location = new System.Drawing.Point(405, 264);
            this.txt_Valor3.Name = "txt_Valor3";
            this.txt_Valor3.Size = new System.Drawing.Size(191, 26);
            this.txt_Valor3.TabIndex = 79;
            this.txt_Valor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Valor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Valor2.Location = new System.Drawing.Point(405, 204);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(191, 26);
            this.txt_Valor2.TabIndex = 78;
            this.txt_Valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Valor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Valor1.Location = new System.Drawing.Point(405, 143);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(191, 26);
            this.txt_Valor1.TabIndex = 77;
            this.txt_Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Valor3
            // 
            this.lbl_Valor3.AutoSize = true;
            this.lbl_Valor3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor3.Location = new System.Drawing.Point(185, 263);
            this.lbl_Valor3.Name = "lbl_Valor3";
            this.lbl_Valor3.Size = new System.Drawing.Size(208, 26);
            this.lbl_Valor3.TabIndex = 76;
            this.lbl_Valor3.Text = "Digite o terceiro valor!";
            // 
            // lbl_Valor2
            // 
            this.lbl_Valor2.AutoSize = true;
            this.lbl_Valor2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor2.Location = new System.Drawing.Point(184, 203);
            this.lbl_Valor2.Name = "lbl_Valor2";
            this.lbl_Valor2.Size = new System.Drawing.Size(208, 26);
            this.lbl_Valor2.TabIndex = 75;
            this.lbl_Valor2.Text = "Digite o segundo valor!";
            // 
            // lbl_Valor1
            // 
            this.lbl_Valor1.AutoSize = true;
            this.lbl_Valor1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor1.Location = new System.Drawing.Point(181, 143);
            this.lbl_Valor1.Name = "lbl_Valor1";
            this.lbl_Valor1.Size = new System.Drawing.Size(209, 26);
            this.lbl_Valor1.TabIndex = 74;
            this.lbl_Valor1.Text = "Digite o primeiro valor!";
            // 
            // rb_Triângulo
            // 
            this.rb_Triângulo.AutoSize = true;
            this.rb_Triângulo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Triângulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_Triângulo.Location = new System.Drawing.Point(325, 53);
            this.rb_Triângulo.Name = "rb_Triângulo";
            this.rb_Triângulo.Size = new System.Drawing.Size(117, 32);
            this.rb_Triângulo.TabIndex = 73;
            this.rb_Triângulo.TabStop = true;
            this.rb_Triângulo.Text = "Triângulo";
            this.rb_Triângulo.UseVisualStyleBackColor = true;
            this.rb_Triângulo.CheckedChanged += new System.EventHandler(this.rb_Triângulo_CheckedChanged);
            // 
            // rb_Quadrilátero
            // 
            this.rb_Quadrilátero.AutoSize = true;
            this.rb_Quadrilátero.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Quadrilátero.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_Quadrilátero.Location = new System.Drawing.Point(601, 53);
            this.rb_Quadrilátero.Name = "rb_Quadrilátero";
            this.rb_Quadrilátero.Size = new System.Drawing.Size(148, 32);
            this.rb_Quadrilátero.TabIndex = 72;
            this.rb_Quadrilátero.TabStop = true;
            this.rb_Quadrilátero.Text = "Quadrilátero";
            this.rb_Quadrilátero.UseVisualStyleBackColor = true;
            this.rb_Quadrilátero.CheckedChanged += new System.EventHandler(this.rb_Quadrilátero_CheckedChanged);
            // 
            // rb_Circulo
            // 
            this.rb_Circulo.AutoSize = true;
            this.rb_Circulo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Circulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_Circulo.Location = new System.Drawing.Point(40, 53);
            this.rb_Circulo.Name = "rb_Circulo";
            this.rb_Circulo.Size = new System.Drawing.Size(94, 32);
            this.rb_Circulo.TabIndex = 71;
            this.rb_Circulo.TabStop = true;
            this.rb_Circulo.Text = "Circulo";
            this.rb_Circulo.UseVisualStyleBackColor = true;
            this.rb_Circulo.CheckedChanged += new System.EventHandler(this.rb_Circulo_CheckedChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Calcular.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Calcular.Location = new System.Drawing.Point(654, 279);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(95, 48);
            this.btn_Calcular.TabIndex = 70;
            this.btn_Calcular.Text = "Calcular ";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Valor4);
            this.Controls.Add(this.lbl_Valor4);
            this.Controls.Add(this.txt_Diâmetro);
            this.Controls.Add(this.lbl_Instrução3);
            this.Controls.Add(this.lbl_Instrução2);
            this.Controls.Add(this.lbl_Instrução);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Valor3);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.lbl_Valor3);
            this.Controls.Add(this.lbl_Valor2);
            this.Controls.Add(this.lbl_Valor1);
            this.Controls.Add(this.rb_Triângulo);
            this.Controls.Add(this.rb_Quadrilátero);
            this.Controls.Add(this.rb_Circulo);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Forma Geométrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Valor4;
        private System.Windows.Forms.Label lbl_Valor4;
        private System.Windows.Forms.TextBox txt_Diâmetro;
        private System.Windows.Forms.Label lbl_Instrução3;
        private System.Windows.Forms.Label lbl_Instrução2;
        private System.Windows.Forms.Label lbl_Instrução;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.TextBox txt_Valor3;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.Label lbl_Valor3;
        private System.Windows.Forms.Label lbl_Valor2;
        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.RadioButton rb_Triângulo;
        private System.Windows.Forms.RadioButton rb_Quadrilátero;
        private System.Windows.Forms.RadioButton rb_Circulo;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

