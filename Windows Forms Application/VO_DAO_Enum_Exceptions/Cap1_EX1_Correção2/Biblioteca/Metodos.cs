using Biblioteca.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public static class Metodos
    {
        public static bool Mensagem(string msg, TipoMensagemEnum tipo )
        {
            if (tipo == TipoMensagemEnum.alerta)
                MessageBox.Show(msg, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tipo == TipoMensagemEnum.erro)
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tipo == TipoMensagemEnum.informacao)
                MessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (tipo == TipoMensagemEnum.pergunta)
            {
                if (MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
            }

            return false;
        }
    }
}
