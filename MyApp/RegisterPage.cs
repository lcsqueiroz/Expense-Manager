using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class RegisterPage
    {
        public  static Dictionary<string, int> users = new Dictionary<string, int>();
        public static void RegisterUser()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Tela de Cadastro =====");

                Console.Write("\nInforme seu Nome: ");
                string userNameInput = Console.ReadLine();

                #region tratando duplicidade no dicionário
                if (users.ContainsKey(userNameInput))
                {
                    Console.WriteLine("Usuário já existe. Tente outro nome.");
                    Console.ReadKey();
                    continue; // volta pro topo do loop
                }
                #endregion

                Console.Write("\nInforme sua Senha (apenas números): ");
                string userPasswordInput = Console.ReadLine();

                if (int.TryParse(userPasswordInput, out int userPasswordInputConverted))
                {
                    users.Add(userNameInput, userPasswordInputConverted);
                    Console.WriteLine("\nUsuário cadastrado com sucesso!");
                    Console.WriteLine("\nAperte Enter para voltar ao menu principal...");
                    Console.ReadKey();
                    HomePage.MainMenu();
                    break; // sai do loop
                }
                else
                {
                    Console.WriteLine("\n\nA senha só pode conter números.");
                    Console.Write("\nPressione ENTER para tentar novamente...");
                    Console.ReadKey();
                }
            }
        }
    }
}
