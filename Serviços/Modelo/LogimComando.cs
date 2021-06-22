using Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviços.Modelo
{
   public class LogimComando
    {
        public bool tem = false;
        public string mensagem = "";
        Conexao conexao = new Conexao();
        SqlCommand cmd = new  SqlCommand();
        SqlDataReader dr;
        

        public bool verificarLogin(string logim, string senha) 
        {
            cmd.CommandText = "select * from Usuario where Logim = @Logim and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Logim", logim);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                { tem = true; }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return tem;


        }
    }
}
