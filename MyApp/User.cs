using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    public class User
    {
        private string _nome;
        private int _senha;


        public string Nome
        {
            get { return _nome; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio ou conter apenas espaços em branco.");
                }
                _nome = value;
            }
        }

        public int Senha
        {
            get { return _senha; }
            set
            {
               if (_senha == null)
                {
                    throw new ArgumentException("A senha não pode ser vazia.");
                }
                _senha = value;
            }
        }

            
    }
}
