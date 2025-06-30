using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Registro
    {
        public void Registrar(Usuario Usuario)
        {
            string nomeUsuario = Usuario.Nome;
            string senhaUsuario= Usuario.Senha;

            string jsonUsuario = JsonSerializer.Serialize(Usuario);

        }
    }
}
