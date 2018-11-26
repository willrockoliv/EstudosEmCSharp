using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    interface ICadastro
    {
        void Salvar(string conteudo);
        string Pesquisar(string valor);
    }
}
