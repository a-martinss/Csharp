
namespace Fahrenheit_e_Celsius
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
            this.btn_ExibirTemperatura = new System.Windows.Forms.Button();
            this.lbl_Intrução = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.rb_Celsius = new System.Windows.Forms.RadioButton();
            this.rb_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ExibirTemperatura
            // 
            this.btn_ExibirTemperatura.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ExibirTemperatura.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExibirTemperatura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ExibirTemperatura.Location = new System.Drawing.Point(484, 296);
            this.btn_ExibirTemperatura.Name = "btn_ExibirTemperatura";
            this.btn_ExibirTemperatura.Size = new System.Drawing.Size(149, 72);
            this.btn_ExibirTemperatura.TabIndex = 30;
            this.btn_ExibirTemperatura.Text = "Exibir Temperatura";
            this.btn_ExibirTemperatura.UseVisualStyleBackColor = false;
            this.btn_ExibirTemperatura.Click += new System.EventHandler(this.btn_ExibirTemperatura_Click);
            // 
            // lbl_Intrução
            // 
            this.lbl_Intrução.AutoSize = true;
            this.lbl_Intrução.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intrução.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Intrução.Location = new System.Drawing.Point(170, 240);
            this.lbl_Intrução.Name = "lbl_Intrução";
            this.lbl_Intrução.Size = new System.Drawing.Size(248, 29);
            this.lbl_Intrução.TabIndex = 31;
            this.lbl_Intrução.Text = "Informe a Temperatura!";
            // 
            // txt_Num
            // 
            this.txt_Num.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Num.Location = new System.Drawing.Point(442, 240);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(191, 26);
            this.txt_Num.TabIndex = 32;
            this.txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_Celsius
            // 
            this.rb_Celsius.AutoSize = true;
            this.rb_Celsius.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Celsius.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rb_Celsius.Location = new System.Drawing.Point(73, 165);
            this.rb_Celsius.Name = "rb_Celsius";
            this.rb_Celsius.Size = new System.Drawing.Size(103, 35);
            this.rb_Celsius.TabIndex = 34;
            this.rb_Celsius.TabStop = true;
            this.rb_Celsius.Text = "Celsius";
            this.rb_Celsius.UseVisualStyleBackColor = true;
            // 
            // rb_Fahrenheit
            // 
            this.rb_Fahrenheit.AutoSize = true;
            this.rb_Fahrenheit.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Fahrenheit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rb_Fahrenheit.Location = new System.Drawing.Point(73, 120);
            this.rb_Fahrenheit.Name = "rb_Fahrenheit";
            this.rb_Fahrenheit.Size = new System.Drawing.Size(149, 35);
            this.rb_Fahrenheit.TabIndex = 33;
            this.rb_Fahrenheit.TabStop = true;
            this.rb_Fahrenheit.Text = "Fahrenheit";
            this.rb_Fahrenheit.UseVisualStyleBackColor = true;
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.AutoSize = true;
            this.lbl_Mensagem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Mensagem.Location = new System.Drawing.Point(276, 52);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(291, 24);
            this.lbl_Mensagem.TabIndex = 37;
            this.lbl_Mensagem.Text = "Conversor de Temperatura!";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Resultado.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Resultado.Location = new System.Drawing.Point(269, 335);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(123, 33);
            this.lbl_Resultado.TabIndex = 38;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.rb_Celsius);
            this.Controls.Add(this.rb_Fahrenheit);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.lbl_Intrução);
            this.Controls.Add(this.btn_ExibirTemperatura);
            this.Name = "Form1";
            this.Text = "Fahrenheit e Celsius";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExibirTemperatura;
        private System.Windows.Forms.Label lbl_Intrução;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.RadioButton rb_Celsius;
        private System.Windows.Forms.RadioButton rb_Fahrenheit;
        private System.Windows.Forms.Label lbl_Mensagem;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

