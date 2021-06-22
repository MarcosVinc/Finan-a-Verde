using Entidade;
using FluentValidation.Results;
using Repositorio;
using Serviços.Conversor;
using Serviços.Modelo;
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
    public partial class EntradaSaldo : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public Usuario User;
        public EntradaSaldo(Usuario user)
        {
            User = user;
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repositorio = new RepositorioUsuario();

            
            User.Saldo = ConversorDeNumeros.ConvertaStringParaDecimal(txtDinheiro.Text, 2);

            ValidacaoSaldo validacao = new ValidacaoSaldo();
            ValidationResult x = validacao.Validate(User);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {

                    errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
                    MessageBox.Show($"Erro ao preencher :{failure.PropertyName}," +
                        $"+ mensagem do erro : {failure.ErrorMessage} ");
                }
            }
            else
            {

                repositorio.AdicionarAoValor(User);
                MessageBox.Show(repositorio.mensagem);
                this.Close();


            }

        }

        private void EntradaSaldo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

