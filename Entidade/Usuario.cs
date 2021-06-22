using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
   public class Usuario
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Logim { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public decimal Saldo { get; set; }

           public Usuario(string nome, string logim,string telefone, string senha, decimal saldo) 
           {
            Nome = nome;
            Logim = logim;
            Senha = senha;
            Saldo = saldo;
            Telefone = telefone;
           }
                public  Usuario()
                {
                     ID = Guid.NewGuid().ToString();
                }
   }
}
