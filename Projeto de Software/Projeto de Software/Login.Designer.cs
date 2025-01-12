
namespace Projeto_de_Software
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox_Cadeado = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.link_EsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.lbl_TítuloAPP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link_NewCadastro = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cadeado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Cadeado
            // 
            this.pictureBox_Cadeado.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Cadeado.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Cadeado.Image")));
            this.pictureBox_Cadeado.Location = new System.Drawing.Point(45, 226);
            this.pictureBox_Cadeado.Name = "pictureBox_Cadeado";
            this.pictureBox_Cadeado.Size = new System.Drawing.Size(27, 41);
            this.pictureBox_Cadeado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Cadeado.TabIndex = 30;
            this.pictureBox_Cadeado.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(45, 175);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(27, 41);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 29;
            this.pictureBox.TabStop = false;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Login.Font = new System.Drawing.Font("Most Wazted", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.White;
            this.lbl_Login.Location = new System.Drawing.Point(154, 130);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(72, 35);
            this.lbl_Login.TabIndex = 23;
            this.lbl_Login.Text = "Login";
            // 
            // link_EsqueceuSenha
            // 
            this.link_EsqueceuSenha.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.link_EsqueceuSenha.AutoSize = true;
            this.link_EsqueceuSenha.BackColor = System.Drawing.Color.Transparent;
            this.link_EsqueceuSenha.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.link_EsqueceuSenha.ForeColor = System.Drawing.Color.SteelBlue;
            this.link_EsqueceuSenha.LinkColor = System.Drawing.Color.Gray;
            this.link_EsqueceuSenha.Location = new System.Drawing.Point(134, 273);
            this.link_EsqueceuSenha.Name = "link_EsqueceuSenha";
            this.link_EsqueceuSenha.Size = new System.Drawing.Size(107, 13);
            this.link_EsqueceuSenha.TabIndex = 27;
            this.link_EsqueceuSenha.TabStop = true;
            this.link_EsqueceuSenha.Text = "Esqueceu sua senha";
            this.link_EsqueceuSenha.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(75, 188);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(244, 20);
            this.txt_UserName.TabIndex = 22;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Login.AutoSize = true;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(140, 299);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(94, 37);
            this.btn_Login.TabIndex = 21;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(72, 170);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(60, 13);
            this.lbl_UserName.TabIndex = 24;
            this.lbl_UserName.Text = "User Name";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Password.Location = new System.Drawing.Point(72, 223);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 26;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(75, 241);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(244, 20);
            this.txt_Password.TabIndex = 25;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.lbl_TítuloAPP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 31;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.btn_Fechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.BackgroundImage")));
            this.btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Fechar.FlatAppearance.BorderSize = 0;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Location = new System.Drawing.Point(758, 0);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // link_NewCadastro
            // 
            this.link_NewCadastro.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.link_NewCadastro.AutoSize = true;
            this.link_NewCadastro.BackColor = System.Drawing.Color.Transparent;
            this.link_NewCadastro.DisabledLinkColor = System.Drawing.Color.WhiteSmoke;
            this.link_NewCadastro.ForeColor = System.Drawing.Color.White;
            this.link_NewCadastro.LinkColor = System.Drawing.Color.Gray;
            this.link_NewCadastro.Location = new System.Drawing.Point(144, 345);
            this.link_NewCadastro.Name = "link_NewCadastro";
            this.link_NewCadastro.Size = new System.Drawing.Size(85, 13);
            this.link_NewCadastro.TabIndex = 34;
            this.link_NewCadastro.TabStop = true;
            this.link_NewCadastro.Text = "Criar nova conta";
            this.link_NewCadastro.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.link_NewCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_NewCadastro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_NewCadastro);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.link_EsqueceuSenha);
            this.Controls.Add(this.pictureBox_Cadeado);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cadeado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Cadeado;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.LinkLabel link_EsqueceuSenha;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TítuloAPP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_NewCadastro;
        private System.Windows.Forms.Button btn_Fechar;
    }
}

