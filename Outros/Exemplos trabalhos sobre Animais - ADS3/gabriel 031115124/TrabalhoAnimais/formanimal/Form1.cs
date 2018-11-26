using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formanimal
{
    public partial class Form1 : Form
    {

        DataTable tabela;
        DataTable tabelaatributos;
        public Form1()
        {
            InitializeComponent();

            #region configuraDatatable1

            //cria uma tabela 
            tabela = new DataTable();

            //coluna codigo
            DataColumn coluna = new DataColumn("Codigo", typeof(int));
            tabela.Columns.Add(coluna);

            //coluna Animal
            coluna = new DataColumn("Animal", typeof(string));
            tabela.Columns.Add(coluna);

            //coluna Nome
            coluna = new DataColumn("Nome", typeof(string));
            tabela.Columns.Add(coluna);

            //configurações do grid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            //preencha as colunas com os nomes dos campos do datatable.
            //as colunas do grid foram preenchidas pela propriedade columns

            colCod.DataPropertyName = "Codigo";
            colAnimal.DataPropertyName = "Animal";
            coNome.DataPropertyName = "Nome";

            //associa a tabela ao grid
            dataGridView1.DataSource = tabela;

            #endregion

            #region configuraDataTable2


            tabelaatributos = new DataTable();

            //coluna codigo
            DataColumn colunai = new DataColumn("Característica", typeof(string));
            tabelaatributos.Columns.Add(colunai);

            //coluna Nome
            colunai = new DataColumn("Valor", typeof(string));
            tabelaatributos.Columns.Add(colunai);

            //configurações do grid
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            //preencha as colunas com os nomes dos campos do datatable.
            //as colunas do grid foram preenchidas pela propriedade columns

            colcaract.DataPropertyName = "Característica";
            colValorCarac.DataPropertyName = "Valor";

            //associa a tabela ao grid
            dataGridView2.DataSource = tabelaatributos;


            #endregion

        }

        #region Lista

        Lista lista = new Lista();

        public void InserenaLista(TrabalhoAnimais.Animal novo)
        {
            lista.InserirNoFim(novo);
        }



        #endregion

        #region variáveisdeControle
        /// <summary>
        /// Define o Sequencial Automaticamente
        /// </summary>        
        private int sequencial = 1;

        public int Sequencial
        {
            get { return sequencial; }
            set { sequencial = value; }
        }

        bool control = false;


        private int tamanhopanel19 = 0;

        public int Tamanhopanel19
        {
            get { return tamanhopanel19; }
            set { tamanhopanel19 = value; }
        }


        #endregion

        #region InserenoDataTableAnimais

        public void InsereDataTableAnimais(int sequencial, Tipobicho animal, string nome)
        {
            DataRow registro;

            registro = tabela.NewRow();
            registro["Codigo"] = Convert.ToString(sequencial);
            registro["Animal"] = Convert.ToString(animal);
            registro["Nome"] = nome;
            tabela.Rows.Add(registro);
        }
        #endregion

        #region InserenoDataTablepropriedades


        public void InserenoDatatablePropriedades(TrabalhoAnimais.Animal novoanimal, Tipobicho e)
        {
            tabelaatributos.Rows.Clear();

            DataRow registro;
            registro = tabelaatributos.NewRow();
            registro["Característica"] = "Sequencial";
            registro["Valor"] = novoanimal.Sequencial.ToString();
            tabelaatributos.Rows.Add(registro);

            DataRow registroTipo;
            string reino;
            if (novoanimal is TrabalhoAnimais.Mamifero)
                reino = "Mamífero";
            else if (novoanimal is TrabalhoAnimais.Reptil)
                reino = "Réptil";
            else
                reino = "Ave";
            registroTipo = tabelaatributos.NewRow();
            registroTipo["Característica"] = "Reino";
            registroTipo["Valor"] = reino;
            tabelaatributos.Rows.Add(registroTipo);

            DataRow registro2;
            registro2 = tabelaatributos.NewRow();
            registro2["Característica"] = "Animal";
            registro2["Valor"] = e.ToString();
            tabelaatributos.Rows.Add(registro2);

            DataRow registro3;
            registro3 = tabelaatributos.NewRow();
            registro3["Característica"] = "Nome";
            registro3["Valor"] = novoanimal.Nome;
            tabelaatributos.Rows.Add(registro3);

            DataRow registro4;
            registro4 = tabelaatributos.NewRow();
            registro4["Característica"] = "Nascimento";
            registro4["Valor"] = novoanimal.Datanascimento.ToShortDateString();
            tabelaatributos.Rows.Add(registro4);

            #region preencheidade

            DataRow especialIdade;
            string tempo = "";
            int idade;

            double auxiliar = Convert.ToDouble(novoanimal.Idade());
            double resto;
            double inteiro;

            if (auxiliar / 365 == 1)
            {
                idade = 1;
                tempo = idade.ToString() + " ano";
            }
            else if (auxiliar / 365 < 1)
            {
                idade = Convert.ToInt32(auxiliar);
                tempo = auxiliar.ToString() + " dias";
            }
            else if (auxiliar / 365 > 1)
            {
                inteiro = Math.Truncate(auxiliar / 365);
                resto = auxiliar - inteiro * 365;
                tempo = inteiro.ToString() + " anos e " + resto.ToString() + " dias";
            }


            especialIdade = tabelaatributos.NewRow();
            especialIdade["Característica"] = "Idade";
            especialIdade["Valor"] = tempo;
            tabelaatributos.Rows.Add(especialIdade);

            #endregion

            DataRow registro5;
            registro5 = tabelaatributos.NewRow();
            registro5["Característica"] = "Sexo";

            if (novoanimal.Sexo == 'F')
                registro5["Valor"] = "Fêmea";
            else
                registro5["Valor"] = "Macho";
            tabelaatributos.Rows.Add(registro5);


            if (novoanimal is TrabalhoAnimais.Mamifero)
            {

                DataRow registro7;
                string pelos;
                registro7 = tabelaatributos.NewRow();
                registro7["Característica"] = "Tem Pelos";
                if ((novoanimal as TrabalhoAnimais.Mamifero).Pelos == true)
                {
                    pelos = "Sim";
                }
                else
                {
                    pelos = "Não";
                }

                registro7["Valor"] = pelos;
                tabelaatributos.Rows.Add(registro7);

                if (pelos == "Sim")
                {
                    DataRow registro6;
                    registro6 = tabelaatributos.NewRow();
                    registro6["Característica"] = "Cor do Pelo";
                    registro6["Valor"] = (novoanimal as TrabalhoAnimais.Mamifero).Cordopelo;
                    tabelaatributos.Rows.Add(registro6);
                }

                DataRow registro8;
                string aquatico;
                registro8 = tabelaatributos.NewRow();
                registro8["Característica"] = "Aquático";
                if ((novoanimal as TrabalhoAnimais.Mamifero).Aquatico == true)
                {
                    aquatico = "Sim";
                }
                else
                {
                    aquatico = "Não";
                }
                registro8["Valor"] = aquatico;
                tabelaatributos.Rows.Add(registro8);



                DataRow registro9;
                registro9 = tabelaatributos.NewRow();
                registro9["Característica"] = "Quantidade de mamas";
                registro9["Valor"] = (novoanimal as TrabalhoAnimais.Mamifero).QtdMama.ToString();
                tabelaatributos.Rows.Add(registro9);




            }

            if (novoanimal is TrabalhoAnimais.Ave)
            {

                DataRow registro7;
                string aquatico;
                registro7 = tabelaatributos.NewRow();
                registro7["Característica"] = "Aquático";
                if ((novoanimal as TrabalhoAnimais.Ave).Aquatico == true)
                {
                    aquatico = "Sim";
                }
                else
                {
                    aquatico = "Não";
                }
                registro7["Valor"] = aquatico;
                tabelaatributos.Rows.Add(registro7);


                DataRow registro8;
                string penas;
                registro8 = tabelaatributos.NewRow();
                registro8["Característica"] = "Tem Penas";
                if ((novoanimal as TrabalhoAnimais.Ave).PossuiPenas == true)
                {
                    penas = "Sim";
                }
                else
                {
                    penas = "Não";
                }
                registro8["Valor"] = penas;
                tabelaatributos.Rows.Add(registro8);


                DataRow registro9;
                string rapina;
                registro9 = tabelaatributos.NewRow();
                registro9["Característica"] = "Rapina";
                if ((novoanimal as TrabalhoAnimais.Ave).Rapina == true)
                {
                    rapina = "Sim";
                }
                else
                {
                    rapina = "Não";
                }
                registro9["Valor"] = rapina;
                tabelaatributos.Rows.Add(registro9);


            }

            if (novoanimal is TrabalhoAnimais.Reptil)
            {

                DataRow registro7;
                string casco;
                registro7 = tabelaatributos.NewRow();
                registro7["Característica"] = "Tem casco";
                if ((novoanimal as TrabalhoAnimais.Reptil).TemCasco == true)
                {
                    casco = "Sim";
                }
                else
                {
                    casco = "Não";
                }
                registro7["Valor"] = casco;
                tabelaatributos.Rows.Add(registro7);


                DataRow registro8;
                string escamas;
                registro8 = tabelaatributos.NewRow();
                registro8["Característica"] = "Tem Escamas";
                if ((novoanimal as TrabalhoAnimais.Reptil).TemEscama == true)
                {
                    escamas = "Sim";
                }
                else
                {
                    escamas = "Não";
                }
                registro8["Valor"] = escamas;
                tabelaatributos.Rows.Add(registro8);


            }



        }



        #endregion

        #region ConfigurarImagemFundo, ConfigurarImagemAnimal, ConfiguraPosicaoinicialAnimal


        public void ConfiguraFundo(Tipobicho e)
        {
            if (e == Tipobicho.Gato)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoGato.jpg");
            if (e == Tipobicho.Baleia)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoBaleia.jpg");
            if (e == Tipobicho.Cachorro)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoCachorro.jpg");
            if (e == Tipobicho.Coruja)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoCoruja.jpg");
            if (e == Tipobicho.Camaleao)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoCamaleao.jpg");
            if (e == Tipobicho.Morcego)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoMorcego.jpg");
            if (e == Tipobicho.Ornitorrinco)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoOrnitorrinco.jpg");
            if (e == Tipobicho.Pato)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoPato.jpg");
            if (e == Tipobicho.Pinguim)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoPinguim.jpg");
            if (e == Tipobicho.Pombo)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoPombo.jpg");
            if (e == Tipobicho.Tartaruga)
                panel1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + @"\Background\fundoTartaruga.jpg");
        }

        public string ImagemAnimal(Tipobicho a)
        {
            if (a == Tipobicho.Gato)
                return @"\Animais\Gato.png";
            if (a == Tipobicho.Cachorro)
                return @"\Animais\Cachorro.png";
            if (a == Tipobicho.Morcego)
                return @"\Animais\Morcego.png";
            if (a == Tipobicho.Baleia)
                return @"\Animais\Baleia.png";
            if (a == Tipobicho.Ornitorrinco)
                return @"\Animais\Ornitorrinco.png";
            if (a == Tipobicho.Pinguim)
                return @"\Animais\Pinguim.png";
            if (a == Tipobicho.Pato)
                return @"\Animais\Pato.png";
            if (a == Tipobicho.Pombo)
                return @"\Animais\Pombo.png";
            if (a == Tipobicho.Coruja)
                return @"\Animais\Coruja.png";
            if (a == Tipobicho.Tartaruga)
                return @"\Animais\Tartaruga.png";
            if (a == Tipobicho.Camaleao)
                return @"\Animais\Camaleao.png";
            else
                return null;

        }


        public void ConfiguraPosicaoinicial(Tipobicho a)
        {
            //44; 332 atributo inicial na janela

            Point p = pictureBox1.Location;
            Point w = pbfilhote.Location;

            if (a == Tipobicho.Gato)
            {
                p.X = 80;
                p.Y = 300;
                w.Y = 370;
                w.X = 490;
            }
            if (a == Tipobicho.Cachorro)
            {
                p.X = 260;
                p.Y = 332;
                w.Y = 400;
                w.X = 80;

            }
            if (a == Tipobicho.Morcego)
            {
                p.X = 80;
                p.Y = -55;
                w.Y = 238;
                w.X = 480;

            }
            if (a == Tipobicho.Baleia)
            {

                p.X = 50;
                p.Y = 370;
                w.Y = 390;
                w.X = 450;
            
            
            
            }
            if (a == Tipobicho.Ornitorrinco)
            {

                p.X = 10;
                p.Y = 350;
                w.Y = 400;
                w.X = 400;

            }
            if (a == Tipobicho.Pinguim)
            {
                p.X = 10;
                p.Y = 350;
                w.Y = 400;
                w.X = 350;
            }
            if (a == Tipobicho.Pato)
            {
                p.X = 10;
                p.Y = 350;
                w.Y = 470;
                w.X = 400;
            }
            if (a == Tipobicho.Pombo)
            {
                p.X = -20;
                p.Y = 275;
                w.Y = 355;
                w.X = 350;

            }
            if (a == Tipobicho.Coruja)
            {
                p.X = 80;
                p.Y = 150;
                w.Y = 290;
                w.X = 480;
            }
            if (a == Tipobicho.Tartaruga)
            {

                p.X = 150;
                p.Y = 230;
                w.Y = 230;
                w.X = 510;

            
            
            }
            if (a == Tipobicho.Camaleao)
            {

                p.X = 80;
                p.Y = 250;
                w.Y = 370;
                w.X = 490;
            
            
            
            }

            pictureBox1.Location = p;
            pbfilhote.Location = w;


        }


        #region pbfilhoteConfigura

        public void PbFilhoteTamanhoOriginal()
        {

            pbfilhote.Size = new System.Drawing.Size(192, 186);


        }

        #endregion



        #endregion

        #region Configura Caixa Acoes, Configura Botoes Acoes

        public string DeterminaBotao(TipoBotao e)
        {

            if (e == TipoBotao.Amamentar)
            {
                return @"\Estrutura\iconeAmamentar.PNG";
            }

            if (e == TipoBotao.Botar)
            {
                return @"\Estrutura\iconeBotar.PNG";
            }

            if (e == TipoBotao.Chocar)
            {
                return @"\Estrutura\iconeChocar.PNG";
            }

            if (e == TipoBotao.Ciscar)
            {
                return @"\Estrutura\iconeCiscar.PNG";
            }

            else
            {
                return @"\Estrutura\iconeParir.PNG";
            }

        }


        public void ConfiguraCaixaAcoes(TrabalhoAnimais.Animal e)
        {
            if (e is TrabalhoAnimais.Mamifero)
            {

                if (e is TrabalhoAnimais.Classes.Baleia)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Parir));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Amamentar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - (btnciscar.Width + btnVoar.Width);
                }

                if (e is TrabalhoAnimais.Classes.Cachorro)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Parir));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Amamentar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - (btnciscar.Width + btnVoar.Width);
                }

                if (e is TrabalhoAnimais.Classes.Gato)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Parir));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Amamentar)); ;
                    btnciscar.Visible = false;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - (btnciscar.Width + btnVoar.Width);
                }

                if (e is TrabalhoAnimais.Classes.Ornitorrinco)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = true;
                    btnVoar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Amamentar));
                    panel19.Width = tamanhopanel19 - btnciscar.Width;
                }

                if (e is TrabalhoAnimais.Classes.Morcego)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Parir));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Amamentar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = true;
                    panel19.Width = Tamanhopanel19 - btnciscar.Width;
                }

            }
            if (e is TrabalhoAnimais.Ave)
            {

                if (e is TrabalhoAnimais.Classes.Pinguim)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = true;
                    btnciscar.Location = btnVoar.Location;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - btnciscar.Width;
                }

                if (e is TrabalhoAnimais.Classes.Coruja)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = true;
                    btnVoar.Visible = true;
                    //panel19.Width = Tamanhopanel19 - btnciscar.Width;
                }

                if (e is TrabalhoAnimais.Classes.Pato)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = true;
                    btnVoar.Visible = true;
                }

                if (e is TrabalhoAnimais.Classes.Pombo)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = true;
                    btnVoar.Visible = true;
                }


            }
            if (e is TrabalhoAnimais.Reptil)
            {

                if (e is TrabalhoAnimais.Classes.Tartaruga)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - (btnciscar.Width + btnVoar.Width);
                }

                if (e is TrabalhoAnimais.Classes.Camaleao)
                {
                    btnbotarParir.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Botar));
                    btnChocarAmamentar.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + DeterminaBotao(TipoBotao.Chocar));
                    btnciscar.Visible = false;
                    btnVoar.Visible = false;
                    panel19.Width = Tamanhopanel19 - (btnciscar.Width + btnVoar.Width);
                }


            }

        }

        #endregion

        #region AçõesAnimais

        private string corauxiliar;

        public string Corauxiliar
        {
            get { return corauxiliar; }
            set { corauxiliar = value; }
        }



        private string comunicar;

        public string Comunicar
        {
            get { return comunicar; }
            set { comunicar = value; }
        }

        private string movimentar;

        public string Movimentar
        {
            get { return movimentar; }
            set { movimentar = value; }
        }

        private string botar;

        public string Botar
        {
            get { return botar; }
            set { botar = value; }
        }

        private string parir;

        public string Parir
        {
            get { return parir; }
            set { parir = value; }
        }

        private string chocar;

        public string Chocar
        {
            get { return chocar; }
            set { chocar = value; }
        }

        private string amamentar;

        public string Amamentar
        {
            get { return amamentar; }
            set { amamentar = value; }
        }

        private string ciscar;

        public string Ciscar
        {
            get { return ciscar; }
            set { ciscar = value; }
        }

        private string voar;

        public string Voar
        {
            get { return voar; }
            set { voar = value; }
        }

        private bool ativabotar = false;
        private bool ativachocar = false;
        private bool ativamamentaremciscar = false;


        public void ConfiguraAcoes(TrabalhoAnimais.Animal e)
        {

            ConfiguraCaixaAcoes(e);


            if (e is TrabalhoAnimais.Mamifero)
            {

                if (e is TrabalhoAnimais.Classes.Baleia)
                {
                    Comunicar = (e as TrabalhoAnimais.Classes.Baleia).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Baleia).Movimentar();
                    Parir = (e as TrabalhoAnimais.Classes.Baleia).Parir();
                    Amamentar = (e as TrabalhoAnimais.Classes.Baleia).Amamentar();
                }

                if (e is TrabalhoAnimais.Classes.Cachorro)
                {
                    Comunicar = (e as TrabalhoAnimais.Classes.Cachorro).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Cachorro).Movimentar();
                    Parir = (e as TrabalhoAnimais.Classes.Cachorro).Parir();
                    Amamentar = (e as TrabalhoAnimais.Classes.Cachorro).Amamentar();

                }

                if (e is TrabalhoAnimais.Classes.Gato)
                {
                    Comunicar = (e as TrabalhoAnimais.Classes.Gato).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Gato).Movimentar();
                    Parir = (e as TrabalhoAnimais.Classes.Gato).Parir();
                    Amamentar = (e as TrabalhoAnimais.Classes.Gato).Amamentar();
                }

                if (e is TrabalhoAnimais.Classes.Ornitorrinco)
                {
                    ativabotar = true;
                    ativachocar = true;
                    ativamamentaremciscar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Chocar();
                    Amamentar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Amamentar();
                    Corauxiliar = (e as TrabalhoAnimais.Classes.Ornitorrinco).Cordopelo;


                }

                if (e is TrabalhoAnimais.Classes.Morcego)
                {

                    Comunicar = (e as TrabalhoAnimais.Classes.Morcego).Comunicar();
                   Movimentar = (e as TrabalhoAnimais.Classes.Morcego).Movimentar();
                    Parir = (e as TrabalhoAnimais.Classes.Morcego).Parir();
                    Amamentar = (e as TrabalhoAnimais.Classes.Morcego).Amamentar();
                    Voar = (e as TrabalhoAnimais.Classes.Morcego).Voar();


                }

            }
            if (e is TrabalhoAnimais.Ave)
            {


                if (e is TrabalhoAnimais.Classes.Pinguim)
                {
                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Pinguim).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Pinguim).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Pinguim).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Pinguim).Chocar();
                    Ciscar = (e as TrabalhoAnimais.Classes.Pinguim).Ciscar();



                }

                if (e is TrabalhoAnimais.Classes.Coruja)
                {
                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Coruja).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Coruja).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Coruja).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Coruja).Chocar();
                    Ciscar = (e as TrabalhoAnimais.Classes.Coruja).Ciscar();
                    Voar = (e as TrabalhoAnimais.Classes.Coruja).Voar();



                }

                if (e is TrabalhoAnimais.Classes.Pato)
                {

                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Pato).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Pato).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Pato).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Pato).Chocar();
                    Ciscar = (e as TrabalhoAnimais.Classes.Pato).Ciscar();
                    Voar = (e as TrabalhoAnimais.Classes.Pato).Voar();


                }

                if (e is TrabalhoAnimais.Classes.Pombo)
                {
                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Pombo).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Pombo).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Pombo).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Pombo).Chocar();
                    Ciscar = (e as TrabalhoAnimais.Classes.Pombo).Ciscar();
                    Voar = (e as TrabalhoAnimais.Classes.Pombo).Voar();
                }


            }
            if (e is TrabalhoAnimais.Reptil)
            {


                if (e is TrabalhoAnimais.Classes.Tartaruga)
                {
                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Tartaruga).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Tartaruga).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Tartaruga).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Tartaruga).Chocar();

                }

                if (e is TrabalhoAnimais.Classes.Camaleao)
                {
                    ativabotar = true;
                    ativachocar = true;
                    Comunicar = (e as TrabalhoAnimais.Classes.Camaleao).Comunicar();
                    Movimentar = (e as TrabalhoAnimais.Classes.Camaleao).Movimentar();
                    Botar = (e as TrabalhoAnimais.Classes.Camaleao).Botar();
                    Chocar = (e as TrabalhoAnimais.Classes.Camaleao).Chocar();

                }


            }





        }

        #endregion

        #region inicializaçoesUtilidades

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= (0x80000 | 0x20000);  // habilita o minimizar na janela sem borda              
                return cp;
            }
        }
        

        bool dialogAnimais = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        
            tsbexibeacoes.Enabled = false;
            tamanhopanel19 = panel19.Width;

        }




        private void panel7_MouseEnter(object sender, EventArgs e)
        {

            timerbarra.Enabled = true;
         

        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            timerbarra.Enabled = false;
            Point p = new Point();

            if (panel7.Location.X == 733)
            {
                p.Y = panel7.Location.Y;
                p.X = 982;
                panel7.Location = p;
            }
         
        }

        int count = 0;
        private void timerbarra_Tick(object sender, EventArgs e)
        {

            Point p = new Point();

            p.X = panel7.Location.X;
            p.Y = panel7.Location.Y;

            while (p.X != 733)
            {
                p.X -= 1;
                panel7.Location = p;

            }

            count++;

        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = Color.PapayaWhip;
            timerbarra.Enabled = true;
           
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
           
                timerbarra.Enabled = false;
                panel12.BackColor = Color.Tan;
                Point p = new Point();

                p.X = 982;
                p.Y = panel7.Location.Y;


                panel7.Location = p;
          
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {

            dialogAnimais = true;

        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            dialogAnimais = false;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (dialogAnimais)
            {

                Point p = new Point();
                p.X = MousePosition.X - 300;
                p.Y = MousePosition.Y - 100;
                panel6.Location = p;
            }
        }




        #endregion

        #region enumeradorTipoBicho
        public enum Tipobicho
        {

            Gato, Cachorro, Baleia, Morcego, Ornitorrinco, Pinguim, Pombo, Pato, Coruja, Tartaruga, Camaleao

        }


        private Tipobicho getbicho;


        #endregion

        #region enumeradorTipoBotao

        public enum TipoBotao
        {

            Botar, Chocar, Amamentar, Parir, Ciscar

        }




        #endregion

        #region configuraClasseJanela


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }


        public void Libera()
        {
            lblCorPelo.Visible = true;
            txtCorPelo.Visible = true;
            btnSelect.Visible = true;
        }

        public void Impede()
        {
            lblCorPelo.Visible = false;
            txtCorPelo.Visible = false;
            btnSelect.Visible = false;
        }

        public void exibeCriador(Tipobicho e)
        {
            txtseq.Text = Sequencial.ToString();
            txtSexo.Text = string.Empty;
            txtCorPelo.Text = string.Empty;
            txtnome.Text = string.Empty;
            mtbNascimento.Text = string.Empty;

            if (e == Tipobicho.Gato)
            {
                Libera();
                getbicho = e;

            }
            else if (e == Tipobicho.Cachorro)
            {
                Libera();
                getbicho = e;
            }
            else if (e == Tipobicho.Baleia)
            {
                Libera();
                getbicho = e;
            }
            else if (e == Tipobicho.Morcego)
            {
                Libera();
                getbicho = e;
            }
            else if (e == Tipobicho.Ornitorrinco)
            {
                Libera();
                getbicho = e;
            }
            else if (e == Tipobicho.Coruja)
            {
                Impede();
                getbicho = e;
            }
            else if (e == Tipobicho.Pato)
            {
                Impede();
                getbicho = e;
            }
            else if (e == Tipobicho.Pinguim)
            {
                Impede();
                getbicho = e;
            }
            else if (e == Tipobicho.Pombo)
            {
                Impede();
                getbicho = e;
            }
            else if (e == Tipobicho.Tartaruga)
            {
                Impede();
                getbicho = e;
            }
            else if (e == Tipobicho.Camaleao)
            {
                Impede();
                getbicho = e;
            }

            panel6.Visible = true;
        }

        #endregion

        #region ColoreImagem


        /// <summary>
        /// Esse botão permite ao usuário escolher as cores de animais que tem pelos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string caption = "";

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                caption = colorDialog1.Color.ToArgb().ToString();
                txtCorPelo.Text = caption;

            }
        }

        /// <summary>
        /// Esse método é o responsável por colorir cada uma das imagens de um animal
        /// para cada nova imagem deve se passar ao método que as colorirá e exibirá.
        /// </summary>
        /// <param name="imagem"></param>
        /// <param name="cor"></param>
        public void ConfiguraImage(string imagem, Color cor)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(System.Environment.CurrentDirectory + imagem);


            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {

                    string p = bmp.GetPixel(x, y).ToArgb().ToString();

                    if (bmp.GetPixel(x, y).ToArgb() == Color.White.ToArgb())
                    {
                        bmp.SetPixel(x, y, cor);
                    }
                }


                pictureBox1.BackgroundImage = bmp;

            }

        }


        public void ConfiguraImageAuxiliar(string imagem, Color cor)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(System.Environment.CurrentDirectory + imagem);


            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {

                    string p = bmp.GetPixel(x, y).ToArgb().ToString();

                    if (bmp.GetPixel(x, y).ToArgb() == Color.White.ToArgb())
                    {
                        bmp.SetPixel(x, y, cor);
                    }
                }


                pbfilhote.BackgroundImage = bmp;

            }

        }


        public void ConfiguraImage(string imagem)
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(System.Environment.CurrentDirectory + imagem);
            pictureBox1.BackgroundImage = bmp;
        }



        #endregion

        #region enumerarAnimalparaInstancia

        private void btnGato_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Gato);
        }

        private void btnCachorro_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Cachorro);
        }

        private void btnBaleia_Click(object sender, EventArgs e)
        {

            exibeCriador(Tipobicho.Baleia);
        }

        private void btnMorcego_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Morcego);
        }

        private void btnOrnito_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Ornitorrinco);
        }

        private void btnPinguin_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Pinguim);
        }

        private void btnPombo_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Pombo);
        }

        private void btnPato_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Pato);
        }

        private void btnCoruja_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Coruja);
        }

        private void btnTartaruga_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Tartaruga);
        }

        private void btnCroc_Click(object sender, EventArgs e)
        {
            exibeCriador(Tipobicho.Camaleao);
        }
        #endregion

        #region botaoinstanciar

        private void btnInstancia_Click(object sender, EventArgs e)
        {
            try
            {
                ativachocar = false;
                ativabotar = false;
                ativamamentaremciscar = false;


                if (getbicho == Tipobicho.Gato)
                {
                    #region gatoinstancia

                    TrabalhoAnimais.Classes.Gato gato = new TrabalhoAnimais.Classes.Gato(Convert.ToInt32(txtseq.Text), txtnome.Text,
                    Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), txtCorPelo.Text, false, true, 6);

                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(Convert.ToInt32(txtCorPelo.Text)));
                    ConfiguraFundo(Tipobicho.Gato);
                    ConfiguraAcoes(gato);
                    ConfiguraPosicaoinicial(Tipobicho.Gato);


                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Gato, txtnome.Text); // insere no dataTable
                    InserenaLista(gato);
                    InserenoDatatablePropriedades(gato, Tipobicho.Gato);




                    #endregion
                }
                else if (getbicho == Tipobicho.Cachorro)
                {
                    #region cachorroinstancia

                    TrabalhoAnimais.Classes.Cachorro cachorro = new TrabalhoAnimais.Classes.Cachorro(Convert.ToInt32(txtseq.Text), txtnome.Text,
                    Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), txtCorPelo.Text, false, true, 6);

                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(Convert.ToInt32(txtCorPelo.Text)));
                    ConfiguraFundo(Tipobicho.Cachorro);
                    ConfiguraAcoes(cachorro);
                    ConfiguraPosicaoinicial(Tipobicho.Cachorro);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Cachorro, txtnome.Text); // insere no dataTable
                    InserenaLista(cachorro);
                    InserenoDatatablePropriedades(cachorro, Tipobicho.Cachorro);



                    #endregion
                }
                else if (getbicho == Tipobicho.Baleia)
                {
                    #region baleiainstancia

                    TrabalhoAnimais.Classes.Baleia baleia = new TrabalhoAnimais.Classes.Baleia(txtnome.Text,
                    Convert.ToInt32(txtseq.Text), Convert.ToChar(txtSexo.Text), txtCorPelo.Text,
                    Convert.ToDateTime(mtbNascimento.Text), true, 1, true);

                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(Convert.ToInt32(txtCorPelo.Text)));
                    ConfiguraFundo(Tipobicho.Baleia);
                    ConfiguraAcoes(baleia);
                    ConfiguraPosicaoinicial(Tipobicho.Baleia);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Baleia, txtnome.Text); // insere no dataTable
                    InserenaLista(baleia);
                    InserenoDatatablePropriedades(baleia, Tipobicho.Baleia);


                    #endregion
                }
                else if (getbicho == Tipobicho.Morcego)
                {
                    #region morcegoinstancia

                    TrabalhoAnimais.Classes.Morcego morcego = new TrabalhoAnimais.Classes.Morcego(Convert.ToInt32(txtseq.Text), txtnome.Text,
                    Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), txtCorPelo.Text, false, true, 2);

                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(Convert.ToInt32(txtCorPelo.Text)));
                    ConfiguraFundo(Tipobicho.Morcego);
                    ConfiguraAcoes(morcego);
                    ConfiguraPosicaoinicial(Tipobicho.Morcego);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Morcego, txtnome.Text); // insere no dataTable
                    InserenaLista(morcego);
                    InserenoDatatablePropriedades(morcego, Tipobicho.Morcego);



                    #endregion
                }
                else if (getbicho == Tipobicho.Ornitorrinco)
                {
                    #region instanciaornito

                    TrabalhoAnimais.Classes.Ornitorrinco ornitorrinco = new TrabalhoAnimais.Classes.Ornitorrinco(Convert.ToInt32(txtseq.Text), txtnome.Text,
                    Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), txtCorPelo.Text, false, true, 2, false);

                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(Convert.ToInt32(txtCorPelo.Text)));
                    ConfiguraFundo(Tipobicho.Ornitorrinco);
                    ConfiguraAcoes(ornitorrinco);
                    ConfiguraPosicaoinicial(Tipobicho.Ornitorrinco);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Ornitorrinco, txtnome.Text); // insere no dataTable
                    InserenaLista(ornitorrinco);
                    InserenoDatatablePropriedades(ornitorrinco, Tipobicho.Ornitorrinco);


                    #endregion
                }
                else if (getbicho == Tipobicho.Coruja)
                {
                    #region instanciacoruja

                    TrabalhoAnimais.Classes.Coruja coruja = new TrabalhoAnimais.Classes.Coruja(Convert.ToInt32(txtseq.Text),
                    txtnome.Text, Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), false, true, true);

                    ConfiguraImage(ImagemAnimal(getbicho));
                    ConfiguraFundo(Tipobicho.Coruja);
                    ConfiguraAcoes(coruja);
                    ConfiguraPosicaoinicial(Tipobicho.Coruja);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Coruja, txtnome.Text); // insere no dataTable
                    InserenaLista(coruja);
                    InserenoDatatablePropriedades(coruja, Tipobicho.Coruja);


                    #endregion
                }
                else if (getbicho == Tipobicho.Pato)
                {
                    #region instanciapato

                    TrabalhoAnimais.Classes.Pato pato = new TrabalhoAnimais.Classes.Pato(Convert.ToInt32(txtseq.Text),
                    txtnome.Text, Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), true, false, true);

                    ConfiguraImage(ImagemAnimal(getbicho));
                    ConfiguraFundo(Tipobicho.Pato);
                    ConfiguraAcoes(pato);
                    ConfiguraPosicaoinicial(Tipobicho.Pato);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Pato, txtnome.Text); // insere no dataTable
                    InserenaLista(pato);
                    InserenoDatatablePropriedades(pato, Tipobicho.Pato);


                    #endregion
                }
                else if (getbicho == Tipobicho.Pinguim)
                {
                    #region instanciapinguim

                    TrabalhoAnimais.Classes.Pinguim pinguim = new TrabalhoAnimais.Classes.Pinguim(Convert.ToInt32(txtseq.Text),
                    txtnome.Text, Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), true, false, true);

                    ConfiguraImage(ImagemAnimal(getbicho));
                    ConfiguraFundo(Tipobicho.Pinguim);
                    ConfiguraAcoes(pinguim);
                    ConfiguraPosicaoinicial(Tipobicho.Pinguim);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Pinguim, txtnome.Text); // insere no dataTable
                    InserenaLista(pinguim);
                    InserenoDatatablePropriedades(pinguim, Tipobicho.Pinguim);



                    #endregion
                }
                else if (getbicho == Tipobicho.Pombo)
                {
                    #region instanciapombo

                    TrabalhoAnimais.Classes.Pombo pombo = new TrabalhoAnimais.Classes.Pombo(Convert.ToInt32(txtseq.Text),
                    txtnome.Text, Convert.ToChar(txtSexo.Text), Convert.ToDateTime(mtbNascimento.Text), false, false, true);

                    ConfiguraImage(ImagemAnimal(getbicho));
                    ConfiguraFundo(Tipobicho.Pombo);
                    ConfiguraAcoes(pombo);
                    ConfiguraPosicaoinicial(Tipobicho.Pombo);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Pombo, txtnome.Text); // insere no dataTable
                    InserenaLista(pombo);
                    InserenoDatatablePropriedades(pombo, Tipobicho.Pombo);



                    #endregion
                }
                else if (getbicho == Tipobicho.Tartaruga)
                {
                    #region instanciatartaruga

                    TrabalhoAnimais.Classes.Tartaruga tartaruga = new TrabalhoAnimais.Classes.Tartaruga(Convert.ToInt32(txtseq.Text), txtnome.Text,
                    Convert.ToDateTime(mtbNascimento.Text), Convert.ToChar(txtSexo.Text), true, false, false);

                    ConfiguraImage(ImagemAnimal(getbicho));
                    ConfiguraFundo(Tipobicho.Tartaruga);
                    ConfiguraAcoes(tartaruga);
                    ConfiguraPosicaoinicial(Tipobicho.Tartaruga);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Tartaruga, txtnome.Text); // insere no dataTable
                    InserenaLista(tartaruga);
                    InserenoDatatablePropriedades(tartaruga, Tipobicho.Tartaruga);


                    #endregion
                }
                else if (getbicho == Tipobicho.Camaleao)
                {
                    #region instanciacamaleao

                    TrabalhoAnimais.Classes.Camaleao camaleao = new TrabalhoAnimais.Classes.Camaleao(Convert.ToInt32(txtseq.Text),
                    txtnome.Text, Convert.ToDateTime(mtbNascimento.Text), Convert.ToChar(txtSexo.Text), false, true, false);

                    Random r = new Random();



                    ConfiguraImage(ImagemAnimal(getbicho), Color.FromArgb(r.Next(9000)));
                    ConfiguraFundo(Tipobicho.Camaleao);
                    ConfiguraAcoes(camaleao);
                    ConfiguraPosicaoinicial(Tipobicho.Camaleao);

                    InsereDataTableAnimais(Convert.ToInt32(txtseq.Text), Tipobicho.Camaleao, txtnome.Text); // insere no dataTable
                    InserenaLista(camaleao);
                    InserenoDatatablePropriedades(camaleao, Tipobicho.Camaleao);


                    #endregion
                }

                pbfilhote.Visible = false;
                comboBox1.Enabled = true;
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                panel6.Visible = false;
                sequencial++;
                tsbexibeacoes.Enabled = true;
                pictureBox1.Visible = true;
                PbFilhoteTamanhoOriginal();
             

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);

            }

        }

        #endregion

        #region menu



        #endregion

        #region eventos

        private void panel11_MouseEnter(object sender, EventArgs e)
        {

        }



        private void panel6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Escape) && panel6.Visible == true)
            {

                panel6.Visible = false;

            }

            if (control == true && Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.G))
            {

                MessageBox.Show("GOD");

            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {

                control = true;

            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {

                control = false;

            }
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            panel6.Visible = false;
        }



        #endregion

        #region MenusAuxiliaresBarraFerramentas

        private void label14_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(label14, label14.Location.X - 10, label14.Location.Y + 15);
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.PapayaWhip;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.Tan;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show(label16, label16.Location.X - 95, label16.Location.Y + 15);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            contextMenuStrip3.Show(label16, label16.Location.X + 25, label16.Location.Y + 15);
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.BackColor = Color.PapayaWhip;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.BackColor = Color.Tan;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.BackColor = Color.PapayaWhip;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.Tan;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            JanelaInfoAnimais gato = new JanelaInfoAnimais();
            gato.DeterminaAnimal(Tipobicho.Gato.ToString());
            gato.ShowDialog();



        }
        private void cachorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais cachorro = new JanelaInfoAnimais();
            cachorro.DeterminaAnimal(Tipobicho.Cachorro.ToString());
            cachorro.ShowDialog();
        }

        private void morcegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais morcego = new JanelaInfoAnimais();
            morcego.DeterminaAnimal(Tipobicho.Morcego.ToString());
            morcego.ShowDialog();
        }

        private void baleiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais baleia = new JanelaInfoAnimais();
            baleia.DeterminaAnimal(Tipobicho.Baleia.ToString());
            baleia.ShowDialog();
        }

        private void ornitorrincoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais ornitorrinco = new JanelaInfoAnimais();
            ornitorrinco.DeterminaAnimal(Tipobicho.Ornitorrinco.ToString());
            ornitorrinco.ShowDialog();
        }

        private void patoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais pato = new JanelaInfoAnimais();
            pato.DeterminaAnimal(Tipobicho.Pato.ToString());
            pato.ShowDialog();
        }

        private void pomboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais pombo = new JanelaInfoAnimais();
            pombo.DeterminaAnimal(Tipobicho.Pombo.ToString());
            pombo.ShowDialog();
        }

        private void pinguimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais pinguim = new JanelaInfoAnimais();
            pinguim.DeterminaAnimal(Tipobicho.Pinguim.ToString());
            pinguim.ShowDialog();
        }

        private void corujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais coruja = new JanelaInfoAnimais();
            coruja.DeterminaAnimal(Tipobicho.Coruja.ToString());
            coruja.ShowDialog();
        }

        private void tartarugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais tartaruga = new JanelaInfoAnimais();
            tartaruga.DeterminaAnimal(Tipobicho.Tartaruga.ToString());
            tartaruga.ShowDialog();
        }

        private void camaleãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JanelaInfoAnimais camaleao = new JanelaInfoAnimais();
            camaleao.DeterminaAnimal(Tipobicho.Camaleao.ToString());
            camaleao.ShowDialog();
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.BackColor = Color.PapayaWhip;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.BackColor = Color.Tan;
        }

        private void label21_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label21.BackColor = Color.PapayaWhip;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.BackColor = Color.Tan;
        }

        #endregion

        #region comboboxSelecoes

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabela.Rows.Clear();

            #region cbOptodos
            if (comboBox1.SelectedItem.ToString() == "Todos")
            {
                foreach (TrabalhoAnimais.Animal x in lista)
                {

                    if (x is TrabalhoAnimais.Classes.Gato)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Gato, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Cachorro)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Cachorro, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Baleia)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Baleia, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Morcego)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Morcego, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Ornitorrinco)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Ornitorrinco, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Coruja)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Coruja, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pato)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pato, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pombo)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pombo, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pinguim)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pinguim, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Tartaruga)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Tartaruga, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Camaleao)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Camaleao, x.Nome);
                    }


                }



            }

            #endregion

            #region cbOpMamiferos

            if (comboBox1.SelectedItem.ToString() == "Mamíferos")
            {

                foreach (TrabalhoAnimais.Animal x in lista)
                {
                    if (x is TrabalhoAnimais.Classes.Gato)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Gato, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Cachorro)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Cachorro, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Baleia)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Baleia, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Morcego)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Morcego, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Ornitorrinco)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Ornitorrinco, x.Nome);
                    }

                }


            }
            #endregion

            #region cbOpAves

            if (comboBox1.SelectedItem.ToString() == "Aves")
            {
                foreach (TrabalhoAnimais.Animal x in lista)
                {

                    if (x is TrabalhoAnimais.Classes.Coruja)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Coruja, x.Nome);

                    }
                    if (x is TrabalhoAnimais.Classes.Pato)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pato, x.Nome);

                    }
                    if (x is TrabalhoAnimais.Classes.Pombo)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pombo, x.Nome);

                    }
                    if (x is TrabalhoAnimais.Classes.Pinguim)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pinguim, x.Nome);

                    }

                }



            }
            #endregion

            #region cbOpRepteis

            if (comboBox1.SelectedItem.ToString() == "Répteis")
            {

                foreach (TrabalhoAnimais.Animal x in lista)
                {

                    if (x is TrabalhoAnimais.Classes.Tartaruga)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Tartaruga, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Camaleao)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Camaleao, x.Nome);

                    }

                }

            }

            #endregion

            #region cbOpOviparos

            if (comboBox1.SelectedItem.ToString() == "Ovíparos")
            {

                foreach (TrabalhoAnimais.Animal x in lista)
                {

                    if (x is TrabalhoAnimais.Reptil || x is TrabalhoAnimais.Ave)
                    {

                        if (x is TrabalhoAnimais.Classes.Tartaruga)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Tartaruga, x.Nome);
                        }

                        if (x is TrabalhoAnimais.Classes.Camaleao)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Camaleao, x.Nome);

                        }

                        if (x is TrabalhoAnimais.Classes.Coruja)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Coruja, x.Nome);

                        }
                        if (x is TrabalhoAnimais.Classes.Pato)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Pato, x.Nome);

                        }
                        if (x is TrabalhoAnimais.Classes.Pombo)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Pombo, x.Nome);

                        }
                        if (x is TrabalhoAnimais.Classes.Pinguim)
                        {
                            InsereDataTableAnimais(x.Sequencial, Tipobicho.Pinguim, x.Nome);

                        }
                    }
                    else if (x is TrabalhoAnimais.Classes.Ornitorrinco)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Ornitorrinco, x.Nome);
                    }



                }
            }

            #endregion

            #region cbOpVoadores


            if (comboBox1.SelectedItem.ToString() == "Voadores")
            {

                foreach (TrabalhoAnimais.Animal x in lista)
                {

                    if (x is TrabalhoAnimais.Classes.Morcego)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Morcego, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Coruja)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Coruja, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Pato)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pato, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Pombo)
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pombo, x.Nome);
                    }

                }

            }


            #endregion

            #region cbOpBotamOvos
            if (comboBox1.SelectedItem.ToString() == "Botam Ovos")
            {
                foreach (TrabalhoAnimais.Animal x in lista)
                {
                    if (x is TrabalhoAnimais.Classes.Ornitorrinco && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Ornitorrinco, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Coruja && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Coruja, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pato && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pato, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pombo && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pombo, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Pinguim && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Pinguim, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Tartaruga && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Tartaruga, x.Nome);
                    }
                    if (x is TrabalhoAnimais.Classes.Camaleao && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Camaleao, x.Nome);
                    }


                }



            }

            #endregion

            #region cbOpMamiferos

            if (comboBox1.SelectedItem.ToString() == "Amamentam")
            {

                foreach (TrabalhoAnimais.Animal x in lista)
                {
                    if (x is TrabalhoAnimais.Classes.Gato && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Gato, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Cachorro && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Cachorro, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Baleia && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Baleia, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Morcego && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Morcego, x.Nome);
                    }

                    if (x is TrabalhoAnimais.Classes.Ornitorrinco && x.Sexo == 'F')
                    {
                        InsereDataTableAnimais(x.Sequencial, Tipobicho.Ornitorrinco, x.Nome);
                    }

                }


            }
            #endregion

        }

        #endregion

        #region recarregaAnimal

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if ((MessageBox.Show("Deseja carregar esse animal?", "Atenção", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                ativachocar = false;
                ativabotar = false;
                ativamamentaremciscar = false;

                foreach (TrabalhoAnimais.Animal x in lista)
                {
                    string p = dataGridView1.SelectedRows[0].Cells["colCod"].Value.ToString();

                    if (x.Sequencial.ToString() == dataGridView1.SelectedRows[0].Cells["colCod"].Value.ToString())
                    {
                        Tipobicho a = Tipobicho.Baleia;

                        if (x is TrabalhoAnimais.Classes.Cachorro)
                        {
                            a = Tipobicho.Cachorro;
                            ConfiguraImage(ImagemAnimal(a), Color.FromArgb(Convert.ToInt32((x as TrabalhoAnimais.Mamifero).Cordopelo)));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Gato)
                        {
                            a = Tipobicho.Gato;
                            ConfiguraImage(ImagemAnimal(a), Color.FromArgb(Convert.ToInt32((x as TrabalhoAnimais.Mamifero).Cordopelo)));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Baleia)
                        {
                            a = Tipobicho.Baleia;
                            ConfiguraImage(ImagemAnimal(a), Color.FromArgb(Convert.ToInt32((x as TrabalhoAnimais.Mamifero).Cordopelo)));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Morcego)
                        {
                            a = Tipobicho.Morcego;
                            ConfiguraImage(ImagemAnimal(a), Color.FromArgb(Convert.ToInt32((x as TrabalhoAnimais.Mamifero).Cordopelo)));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Ornitorrinco)
                        {
                            a = Tipobicho.Ornitorrinco;
                            ConfiguraImage(ImagemAnimal(a), Color.FromArgb(Convert.ToInt32((x as TrabalhoAnimais.Mamifero).Cordopelo)));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Pato)
                        {
                            a = Tipobicho.Pato;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Pinguim)
                        {
                            a = Tipobicho.Pinguim;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Pombo)
                        {
                            a = Tipobicho.Pombo;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Coruja)
                        {
                            a = Tipobicho.Coruja;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Tartaruga)
                        {
                            a = Tipobicho.Tartaruga;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        if (x is TrabalhoAnimais.Classes.Camaleao)
                        {
                            a = Tipobicho.Camaleao;
                            ConfiguraImage(ImagemAnimal(a));
                            ConfiguraFundo(a);
                        }

                        ConfiguraPosicaoinicial(a);
                        InserenoDatatablePropriedades(x, a);//recarrega o datatable de propriedades
                        ConfiguraAcoes(x); //carrega todos os dados nas variáveis que são executadas pelos 
                        pictureBox1.Visible = true;
                        PbFilhoteTamanhoOriginal();
                        pbfilhote.Visible = false;
                        //botões de ação


                        break;

                    }


                }




            }


        }

        #endregion

        #region somAnimal

        public void ExecutaSomAnimal(string path)
        {            
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = path;
                player.Load();
                player.Play();                          
        }

        #endregion

        #region MenuEBotõesAçõesdosAnimais

        private void exibirAçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point p = new Point();

            p.X = 653;
            p.Y = 81;
            panel19.Location = p;

            if (tsbexibeacoes.Checked == true)
                panel19.Visible = true;
            else
            {
                panel19.Visible = false;

            }

        }

        private void btncomunicar_Click(object sender, EventArgs e)
        {
            try
            {
                ExecutaSomAnimal(System.Environment.CurrentDirectory + Comunicar);
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmovimentar_Click(object sender, EventArgs e)
        {

            Point p = new Point();
            p.Y = pictureBox1.Location.Y;

            string organizador = Movimentar;
            organizador = organizador.Remove(0, organizador.IndexOf(";")+1);

            p.X = Convert.ToInt32(organizador);


            pictureBox1.Location = p;
            timer2.Enabled = true;







        }

        private void btnbotarParir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ativabotar)
                {
                    pbfilhote.Visible = true;
                    pbfilhote.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Botar);

                }
                else
                {
                    pbfilhote.Visible = true;
                    pbfilhote.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Parir);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnChocarAmamentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ativachocar)
                {
                    Point p = pbfilhote.Location;
                    p.Y = p.Y - 100;
                    p.X = p.X - 100;
                    pictureBox1.Visible = false;
                    pbfilhote.Size = pictureBox1.Size;
                    pbfilhote.Location = p;
                    pbfilhote.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Chocar);
                    timer3.Enabled = true;

                }
                else
                {

                    Point p = new Point();
                    p.X = 120;
                    p.Y = 100;

                    pictureBox1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Amamentar);
                    pictureBox1.Location = p;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVoar_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Voar);

                Point p = pictureBox1.Location;

                p.Y = p.Y - 200;

                pictureBox1.Location = p;



            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        PictureBox p = new PictureBox();
                
     

        private void btnciscar_Click(object sender, EventArgs e)
        {

            if (ativamamentaremciscar)
            {

                ConfiguraImageAuxiliar(Amamentar, Color.FromArgb(Convert.ToInt32(Corauxiliar)));


            }
            else
            {   
            
                
                p.BackgroundImage = pictureBox1.BackgroundImage;

                pictureBox1.BackgroundImage = Image.FromFile(System.Environment.CurrentDirectory + Ciscar);
                timer1.Enabled = true;
                

            }


        }



        #endregion

        #region Agradecimentos, Desenvolvedor

        private void agradecimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agradecimentos agr = new Agradecimentos();
            agr.ShowDialog();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desenvolvedor desenvolvedor = new Desenvolvedor();
            desenvolvedor.ShowDialog();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImage = p.BackgroundImage;
            timer1.Enabled = false;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Point p = new Point();
            p.Y = pictureBox1.Location.Y;
            p.X = pictureBox1.Location.X-100;

            pictureBox1.Location = p;

            timer2.Enabled = false;


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pbfilhote.Visible = false;
            timer3.Enabled = false;
        }

    }
}
