using Entidade;
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
    public partial class AddIntermediario : Form
    {
        public Usuario UsuarioLogado;
        public AddIntermediario(Usuario usuario)
        {
            UsuarioLogado = usuario;
            InitializeComponent();
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntradaSaldo ad = new EntradaSaldo(UsuarioLogado);
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           SaidaSaldo ad = new SaidaSaldo(UsuarioLogado);
            ad.Show();
        }

        private void AddIntermediario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'finançasVerdeDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.finançasVerdeDataSet.Usuario);

        }
    }
}
