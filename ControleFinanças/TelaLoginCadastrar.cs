using Entidade;
using FluentValidation.Results;
using Repositorio;
using Serviços.Conversor;
using Serviços.Validador;
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
    public partial class TelaLoginCadastrar : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public TelaLoginCadastrar()
        {
            InitializeComponent();
        }

        private void siticoneControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin tl = new TelaLogin();
            tl.Show();        
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            var repositorio = new RepositorioUsuario();
            user.Nome = txtNome.Text;
            user.Telefone = txtTelefone.Text;
            user.Senha = txtSenha.Text;
            user.Logim = txtEmail.Text;

            ValidacaoUsuario validacao = new ValidacaoUsuario();
            ValidationResult x = validacao.Validate(user);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {
                    errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
                    MessageBox.Show($"Mensagem do erro : {failure.ErrorMessage}");

                }
            }
            else
            {
                repositorio.Salvar(user);
                MessageBox.Show(repositorio.mensagem);
                this.Close();
                TelaLogin tl = new TelaLogin();
                tl.Show();
            }

        }
    }
}
