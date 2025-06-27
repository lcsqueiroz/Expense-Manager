using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class HomePage
    {
        public static int MainMenu()
        {
            while (true)
            {
                #region Opções de entrada no sistema
                Console.Clear();
                Console.WriteLine("===== Tela Inicial =====");
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Cadastro");
                Console.WriteLine("3 - Fechar Programa");
                Console.Write("\nOpção selecionada: ");
                #endregion

                string stringMainMenuSelected = Console.ReadLine();
                int intMainMenuSelected;

                if (int.TryParse(stringMainMenuSelected, out intMainMenuSelected))
                {
                    switch (intMainMenuSelected)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Bem vindo ao sistema! ");
                            return intMainMenuSelected;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Bem vindo ao cadastro");
                            return intMainMenuSelected;

                        case 3:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opção inválida. Pressione ENTER para tentar novamente.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Pressione ENTER para tentar novamente.");
                    Console.ReadKey();
                }
            }
        }
    }
}
