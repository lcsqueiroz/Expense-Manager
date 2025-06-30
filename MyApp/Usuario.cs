using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Usuario
    {
        private string _nome;
        private string _senha;


        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}
