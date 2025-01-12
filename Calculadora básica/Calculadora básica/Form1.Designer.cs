
namespace Calculadora_básica
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
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.lbl_Intrucao2 = new System.Windows.Forms.Label();
            this.lbl_Intrucao1 = new System.Windows.Forms.Label();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.bloqueada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resultado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_Resultado.Location = new System.Drawing.Point(554, 370);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(191, 35);
            this.txt_Resultado.TabIndex = 53;
            this.txt_Resultado.Text = "Resultado";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Num2
            // 
            this.txt_Num2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Num2.Location = new System.Drawing.Point(422, 267);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(191, 26);
            this.txt_Num2.TabIndex = 51;
            this.txt_Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Num1
            // 
            this.txt_Num1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_Num1.Location = new System.Drawing.Point(422, 132);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(191, 26);
            this.txt_Num1.TabIndex = 50;
            this.txt_Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Intrucao2
            // 
            this.lbl_Intrucao2.AutoSize = true;
            this.lbl_Intrucao2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intrucao2.Location = new System.Drawing.Point(393, 222);
            this.lbl_Intrucao2.Name = "lbl_Intrucao2";
            this.lbl_Intrucao2.Size = new System.Drawing.Size(254, 29);
            this.lbl_Intrucao2.TabIndex = 49;
            this.lbl_Intrucao2.Text = "Digite o segundo número!";
            // 
            // lbl_Intrucao1
            // 
            this.lbl_Intrucao1.AutoSize = true;
            this.lbl_Intrucao1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intrucao1.Location = new System.Drawing.Point(393, 90);
            this.lbl_Intrucao1.Name = "lbl_Intrucao1";
            this.lbl_Intrucao1.Size = new System.Drawing.Size(257, 29);
            this.lbl_Intrucao1.TabIndex = 48;
            this.lbl_Intrucao1.Text = "Digite o primeiro número!";
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.BackColor = System.Drawing.Color.Gray;
            this.btn_Subtracao.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subtracao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Subtracao.Location = new System.Drawing.Point(55, 139);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(178, 63);
            this.btn_Subtracao.TabIndex = 47;
            this.btn_Subtracao.Text = "Subtração -";
            this.btn_Subtracao.UseVisualStyleBackColor = false;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.BackColor = System.Drawing.Color.Gray;
            this.btn_Multiplicacao.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multiplicacao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Multiplicacao.Location = new System.Drawing.Point(55, 247);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(178, 63);
            this.btn_Multiplicacao.TabIndex = 46;
            this.btn_Multiplicacao.Text = "Multiplicação *";
            this.btn_Multiplicacao.UseVisualStyleBackColor = false;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.BackColor = System.Drawing.Color.Gray;
            this.btn_Divisao.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Divisao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Divisao.Location = new System.Drawing.Point(55, 350);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(178, 63);
            this.btn_Divisao.TabIndex = 45;
            this.btn_Divisao.Text = "Divisão /";
            this.btn_Divisao.UseVisualStyleBackColor = false;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // btn_Somar
            // 
            this.btn_Somar.BackColor = System.Drawing.Color.Gray;
            this.btn_Somar.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Somar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Somar.Location = new System.Drawing.Point(55, 37);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(178, 63);
            this.btn_Somar.TabIndex = 44;
            this.btn_Somar.Text = "Adição +";
            this.btn_Somar.UseVisualStyleBackColor = false;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // bloqueada
            // 
            this.bloqueada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bloqueada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloqueada.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bloqueada.Location = new System.Drawing.Point(357, 377);
            this.bloqueada.Name = "bloqueada";
            this.bloqueada.Size = new System.Drawing.Size(191, 26);
            this.bloqueada.TabIndex = 52;
            this.bloqueada.Text = "Resultado";
            this.bloqueada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bloqueada.TextChanged += new System.EventHandler(this.bloqueada_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.bloqueada);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Intrucao2);
            this.Controls.Add(this.lbl_Intrucao1);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Somar);
            this.Name = "Form1";
            this.Text = "Calculadora básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.Label lbl_Intrucao2;
        private System.Windows.Forms.Label lbl_Intrucao1;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.TextBox bloqueada;
    }
}

