
namespace Projeto_de_Software
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Título = new System.Windows.Forms.Label();
            this.rb_Mulher = new System.Windows.Forms.RadioButton();
            this.rb_Homem = new System.Windows.Forms.RadioButton();
            this.gbx_Sexo = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_Endereço = new System.Windows.Forms.TextBox();
            this.lbl_Endereço = new System.Windows.Forms.Label();
            this.lbl_Nascimento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_TítuloAPP = new System.Windows.Forms.Label();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.mtb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Data_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.mtb_Phone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.gbx_Sexo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CPF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.ForeColor = System.Drawing.Color.Teal;
            this.lbl_CPF.Location = new System.Drawing.Point(298, 132);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(38, 23);
            this.lbl_CPF.TabIndex = 116;
            this.lbl_CPF.Text = "CPF";
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Título.Font = new System.Drawing.Font("Most Wazted", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lbl_Título.Location = new System.Drawing.Point(315, 42);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(427, 57);
            this.lbl_Título.TabIndex = 107;
            this.lbl_Título.Text = "Tela de Cadastro ";
            // 
            // rb_Mulher
            // 
            this.rb_Mulher.AutoSize = true;
            this.rb_Mulher.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mulher.ForeColor = System.Drawing.Color.Purple;
            this.rb_Mulher.Location = new System.Drawing.Point(9, 55);
            this.rb_Mulher.Name = "rb_Mulher";
            this.rb_Mulher.Size = new System.Drawing.Size(97, 32);
            this.rb_Mulher.TabIndex = 133;
            this.rb_Mulher.TabStop = true;
            this.rb_Mulher.Text = "Mulher";
            this.rb_Mulher.UseVisualStyleBackColor = true;
            // 
            // rb_Homem
            // 
            this.rb_Homem.AutoSize = true;
            this.rb_Homem.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Homem.ForeColor = System.Drawing.Color.SteelBlue;
            this.rb_Homem.Location = new System.Drawing.Point(9, 20);
            this.rb_Homem.Name = "rb_Homem";
            this.rb_Homem.Size = new System.Drawing.Size(102, 32);
            this.rb_Homem.TabIndex = 132;
            this.rb_Homem.TabStop = true;
            this.rb_Homem.Text = "Homem";
            this.rb_Homem.UseVisualStyleBackColor = true;
            // 
            // gbx_Sexo
            // 
            this.gbx_Sexo.BackColor = System.Drawing.Color.Transparent;
            this.gbx_Sexo.Controls.Add(this.rb_Homem);
            this.gbx_Sexo.Controls.Add(this.rb_Mulher);
            this.gbx_Sexo.ForeColor = System.Drawing.Color.DimGray;
            this.gbx_Sexo.Location = new System.Drawing.Point(577, 132);
            this.gbx_Sexo.Name = "gbx_Sexo";
            this.gbx_Sexo.Size = new System.Drawing.Size(117, 98);
            this.gbx_Sexo.TabIndex = 134;
            this.gbx_Sexo.TabStop = false;
            this.gbx_Sexo.Text = "Selecione o sexo!";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Name.Location = new System.Drawing.Point(298, 193);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(50, 23);
            this.lbl_Name.TabIndex = 135;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(303, 340);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(343, 29);
            this.txt_Email.TabIndex = 140;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Email.Location = new System.Drawing.Point(298, 313);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(49, 23);
            this.lbl_Email.TabIndex = 139;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phone.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Phone.Location = new System.Drawing.Point(298, 252);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(50, 23);
            this.lbl_Phone.TabIndex = 137;
            this.lbl_Phone.Text = "Phone";
            // 
            // txt_Endereço
            // 
            this.txt_Endereço.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Endereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereço.Location = new System.Drawing.Point(303, 447);
            this.txt_Endereço.Name = "txt_Endereço";
            this.txt_Endereço.Size = new System.Drawing.Size(416, 29);
            this.txt_Endereço.TabIndex = 144;
            // 
            // lbl_Endereço
            // 
            this.lbl_Endereço.AutoSize = true;
            this.lbl_Endereço.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Endereço.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereço.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Endereço.Location = new System.Drawing.Point(298, 420);
            this.lbl_Endereço.Name = "lbl_Endereço";
            this.lbl_Endereço.Size = new System.Drawing.Size(77, 23);
            this.lbl_Endereço.TabIndex = 143;
            this.lbl_Endereço.Text = "Endereço";
            // 
            // lbl_Nascimento
            // 
            this.lbl_Nascimento.AutoSize = true;
            this.lbl_Nascimento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Nascimento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nascimento.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Nascimento.Location = new System.Drawing.Point(298, 371);
            this.lbl_Nascimento.Name = "lbl_Nascimento";
            this.lbl_Nascimento.Size = new System.Drawing.Size(98, 23);
            this.lbl_Nascimento.TabIndex = 141;
            this.lbl_Nascimento.Text = "Nascimento ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.lbl_TítuloAPP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 37);
            this.panel1.TabIndex = 145;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btn_Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.BackgroundImage")));
            this.btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Location = new System.Drawing.Point(697, 0);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(42, 37);
            this.btn_Fechar.TabIndex = 35;
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // lbl_TítuloAPP
            // 
            this.lbl_TítuloAPP.AutoSize = true;
            this.lbl_TítuloAPP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TítuloAPP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_TítuloAPP.Location = new System.Drawing.Point(12, 9);
            this.lbl_TítuloAPP.Name = "lbl_TítuloAPP";
            this.lbl_TítuloAPP.Size = new System.Drawing.Size(184, 17);
            this.lbl_TítuloAPP.TabIndex = 32;
            this.lbl_TítuloAPP.Text = "CONTROLE FINANCEIRO APP";
            // 
            // lbl_Line
            // 
            this.lbl_Line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Line.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Line.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Line.Location = new System.Drawing.Point(302, 492);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(415, 1);
            this.lbl_Line.TabIndex = 124;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Salvar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Image")));
            this.btn_Salvar.Location = new System.Drawing.Point(674, 495);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(44, 36);
            this.btn_Salvar.TabIndex = 147;
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Editar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.Location = new System.Drawing.Point(629, 495);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(44, 36);
            this.btn_Editar.TabIndex = 146;
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // mtb_CPF
            // 
            this.mtb_CPF.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_CPF.Location = new System.Drawing.Point(302, 161);
            this.mtb_CPF.Mask = "000.000.000-00";
            this.mtb_CPF.Name = "mtb_CPF";
            this.mtb_CPF.Size = new System.Drawing.Size(143, 29);
            this.mtb_CPF.TabIndex = 149;
            this.mtb_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Data_Nascimento
            // 
            this.Data_Nascimento.CalendarForeColor = System.Drawing.Color.SteelBlue;
            this.Data_Nascimento.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.Data_Nascimento.CalendarTitleBackColor = System.Drawing.Color.CadetBlue;
            this.Data_Nascimento.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.Data_Nascimento.CalendarTrailingForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Data_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data_Nascimento.Location = new System.Drawing.Point(302, 397);
            this.Data_Nascimento.Name = "Data_Nascimento";
            this.Data_Nascimento.Size = new System.Drawing.Size(101, 20);
            this.Data_Nascimento.TabIndex = 150;
            // 
            // mtb_Phone
            // 
            this.mtb_Phone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_Phone.Location = new System.Drawing.Point(302, 281);
            this.mtb_Phone.Mask = "(00) 000000000";
            this.mtb_Phone.Name = "mtb_Phone";
            this.mtb_Phone.Size = new System.Drawing.Size(132, 29);
            this.mtb_Phone.TabIndex = 151;
            this.mtb_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(303, 220);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(235, 29);
            this.txt_Name.TabIndex = 136;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(739, 541);
            this.Controls.Add(this.mtb_Phone);
            this.Controls.Add(this.Data_Nascimento);
            this.Controls.Add(this.mtb_CPF);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Endereço);
            this.Controls.Add(this.lbl_Endereço);
            this.Controls.Add(this.lbl_Nascimento);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.gbx_Sexo);
            this.Controls.Add(this.lbl_Line);
            this.Controls.Add(this.lbl_CPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.gbx_Sexo.ResumeLayout(false);
            this.gbx_Sexo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.RadioButton rb_Mulher;
        private System.Windows.Forms.RadioButton rb_Homem;
        private System.Windows.Forms.GroupBox gbx_Sexo;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_Endereço;
        private System.Windows.Forms.Label lbl_Endereço;
        private System.Windows.Forms.Label lbl_Nascimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label lbl_TítuloAPP;
        private System.Windows.Forms.Label lbl_Line;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.MaskedTextBox mtb_CPF;
        private System.Windows.Forms.DateTimePicker Data_Nascimento;
        private System.Windows.Forms.MaskedTextBox mtb_Phone;
        private System.Windows.Forms.TextBox txt_Name;
    }
}