using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Software
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text=="" && txt_Password.Text == "") 
            {
                MessageBox.Show("Nome de usuário e senha inválidos!");
                txt_UserName.Focus();
                return;
            }

            else if (txt_UserName.Text == "")
            {
                MessageBox.Show("Usuário inválido!");
                txt_Password.Focus();
                return;
            }

            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Senha inválida!");
                txt_Password.Focus();
                return;
            }

            else 
            {
                MessageBox.Show("Login realizado com sucesso!");
            }
        }

        private void link_NewCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Criando uma instância para tela de cadastro
            Cadastro Cadastro = new Cadastro();

            //Mostrando a tela de cadastro
            Cadastro.Show();
        }
    }
}
