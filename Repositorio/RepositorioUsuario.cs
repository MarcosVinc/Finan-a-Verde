using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
     public class RepositorioUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(Usuario usuario)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Usuario values(@ID, @Nome,@Logim,@Telefone,@Senha,@Saldo)";
            //parametros
            cmd.Parameters.AddWithValue("@ID", usuario.ID);
            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Logim", usuario.Logim);
            cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@Saldo", usuario.Saldo);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Usuario Cadastrado!";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
        public List<Usuario> Consulta()
        {
            var produto = new List<Usuario>();

            cmd.CommandText = "select * from Usuario";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    Usuario x = new Usuario();
                    x.ID = (string)read["ID"];
                    x.Nome = (string)read["Nome"];
                    x.Telefone = (string)read["Telefone"];
                    x.Senha = (string)read["Senha"];
                    x.Saldo = (decimal)read["Saldo"];
                    x.Logim = (string)read["Logim"];
                    produto.Add(x);
                }

                read.Close();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

            return produto;

        }
        public void AdicionarAoValor(Usuario update)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "Update Usuario set Saldo = @saldo + Saldo where Logim = @logim";
            //parametros

            cmd.Parameters.AddWithValue("@Saldo", update.Saldo);
            cmd.Parameters.AddWithValue("@logim", update.Logim);



            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Dados alterados";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }

        public void SubitrairAoValor(Usuario update)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "Update Usuario set Saldo = @saldo - Saldo where Logim = @logim";
            //parametros

            cmd.Parameters.AddWithValue("@saldo", update.Saldo);
            cmd.Parameters.AddWithValue("@logim", update.Logim);



            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Dados alterados";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }

    }
}
