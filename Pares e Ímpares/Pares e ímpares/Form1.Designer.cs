
namespace Pares_e_ímpares
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
            this.lbl_Intrução = new System.Windows.Forms.Label();
            this.btn_Verificar = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Mensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Intrução
            // 
            this.lbl_Intrução.AutoSize = true;
            this.lbl_Intrução.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intrução.Location = new System.Drawing.Point(42, 183);
            this.lbl_Intrução.Name = "lbl_Intrução";
            this.lbl_Intrução.Size = new System.Drawing.Size(198, 29);
            this.lbl_Intrução.TabIndex = 27;
            this.lbl_Intrução.Text = "Informe o número! ";
            // 
            // btn_Verificar
            // 
            this.btn_Verificar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Verificar.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Verificar.Location = new System.Drawing.Point(551, 131);
            this.btn_Verificar.Name = "btn_Verificar";
            this.btn_Verificar.Size = new System.Drawing.Size(114, 81);
            this.btn_Verificar.TabIndex = 29;
            this.btn_Verificar.Text = "Verificar";
            this.btn_Verificar.UseVisualStyleBackColor = false;
            this.btn_Verificar.Click += new System.EventHandler(this.btn_Verificar_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Valor.Location = new System.Drawing.Point(299, 186);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(191, 26);
            this.txt_Valor.TabIndex = 30;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Mensagem
            // 
            this.lbl_Mensagem.AutoSize = true;
            this.lbl_Mensagem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mensagem.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Mensagem.Location = new System.Drawing.Point(180, 37);
            this.lbl_Mensagem.Name = "lbl_Mensagem";
            this.lbl_Mensagem.Size = new System.Drawing.Size(391, 24);
            this.lbl_Mensagem.TabIndex = 32;
            this.lbl_Mensagem.Text = "Verificar se o número é par ou ímpar.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.lbl_Mensagem);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.btn_Verificar);
            this.Controls.Add(this.lbl_Intrução);
            this.Name = "Form1";
            this.Text = "Pares e ímpares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Intrução;
        private System.Windows.Forms.Button btn_Verificar;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_Mensagem;
    }
}

