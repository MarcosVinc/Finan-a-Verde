using Entidade;
using Serviços.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanças
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            TelaLoginCadastrar tlc = new TelaLoginCadastrar();
            tlc.Show();
            this.Hide();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtEmail.Text, txtSenha.Text);

            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var usuario = new Usuario();
                    usuario.Logim = txtEmail.Text;
                    usuario.Senha = txtSenha.Text;
                    TelaInicial ti = new TelaInicial(usuario);
                    this.Hide();
                    ti.Show();
                }
                else
                {
                    MessageBox.Show("Logim ou senha estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

