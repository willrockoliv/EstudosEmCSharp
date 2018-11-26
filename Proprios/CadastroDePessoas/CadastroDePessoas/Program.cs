using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class Program
    {
        static void SalvaCadastro(string linha_cadastro)
        {

        }
        static void Main(string[] args)
        {
            /* Cadastra Nome, Sobrenome, Idade, CPF, RG, Ocupação e WhatsApp
             * Salva em um txt
             * Pode ser conultado pelo Nome ou Código (Código gerado automaticamente e informado ao Usuário durante o cadastro)
             * Pode ser Alterado
             * Pode ser Excluído
            */

            bool fechar_programa = false;
            int opcao_menu = 0;
            string linha_cadastro = "";

            do
            {
                #region menu

                bool ok_menu = false;

                do
                {
                    try
                    {
                        Console.WriteLine("   >>> MENU <<<");
                        Console.WriteLine("\n  1) Iniciar cadastro \n  2) Alterar Cadastro" +
                                          "\n  3) Consultar Cadastro \n  4) Fechar Programa");
                        opcao_menu = Convert.ToInt16(Console.ReadLine());

                        if (opcao_menu < 1 || opcao_menu > 4)
                        {
                            Console.Clear();
                            Console.WriteLine("\n  >> Opção inválida! << \n");
                            break;
                        }
                        ok_menu = true;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("\n  >> Digite um número referente à uma opção! << \n");
                    }
                }
                while (ok_menu == false);

                #endregion

                if (opcao_menu == 1)
                {

                    SalvaCadastro(linha_cadastro);
                }
                else if (opcao_menu == 4)
                    fechar_programa = true;

            }
            while (fechar_programa == false);
        }
    }
}
