using Entidade;
using Repositorio;
using Serviços.Conversor;
using Serviços.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanças
{
    public partial class TelaInicial : Form
    {
        public Usuario UsuarioLogado;
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public TelaInicial(Usuario usuario)
        {
            UsuarioLogado = usuario;
            InitializeComponent();
            Customizacao();
        }
        private void Customizacao()
        {
            PanBt.Visible = false;

        }

        private void EsconderSubMenu()
        {
            if (PanBt.Visible == true)
                PanBt.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            EntradaSaldo ad = new EntradaSaldo(UsuarioLogado);
            ad.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanBt);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin tl = new TelaLogin();
            tl.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nada a declarar");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/MarcosVinc");
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/marcosl.xs/?hl=pt-br");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddIntermediario ad = new AddIntermediario(UsuarioLogado);
            ad.Show();

        }
    }
}


