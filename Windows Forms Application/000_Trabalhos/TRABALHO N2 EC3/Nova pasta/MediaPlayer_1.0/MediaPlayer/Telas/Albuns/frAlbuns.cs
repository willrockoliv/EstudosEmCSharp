﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    /// <summary>
    /// Criar uma forma de associar álbuns e músicas
    /// 
    /// Ao exibir as mídias para que o usuário as selecione, deve ser possível lista-las das seguintes maneiras:
    /// •	Ordem Alfabética(não importa a mídia, todas em ordem alfabética)
    /// •	Por tipo de mídia(álbum / música / vídeo / foto) e uma vez escolhido o tipo, exibir em ordem alfabética.
    /// •	Por ano(exibir uma forma da pessoa selecionar o ano e então devem ser exibidas as mídias que constam nesse ano)
    /// </summary>
    public partial class frAlbuns : Form
    {
        public frAlbuns()
        {
            InitializeComponent();
        }
    }
}
