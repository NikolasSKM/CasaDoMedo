using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoMedo
{
    class Program
    {
        public static string nome;
        public static string nomeAmigo;

        public static void Main()
        {
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            var enter = "";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("             +============================================+");
            Console.WriteLine("             |              A Casa do Medo!               |");
            Console.WriteLine("             |                  `'::::.                   |");
            Console.WriteLine("             |                    _____Y_                 |");
            Console.WriteLine("             |                   /      /                 |");
            Console.WriteLine("             |                __/__/ __/  ___             |");
            Console.WriteLine("             |            ---/__|  ::  | /___/ ----       |");
            Console.WriteLine("             |               |;:|  ||  | |: ;||           |");
            Console.WriteLine("             |                     ))                     |");
            Console.WriteLine("             +============================================+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        +=====================================================+");
            Console.WriteLine("        | Por favor, entre e se em casa... HAHAHAHAHAHAHA!!!! |");
            Console.WriteLine("        +=====================================================+");
            Console.WriteLine();
            Console.WriteLine("                     Pressione ENTER para continuar!");
            Console.ReadKey();
            Console.Clear();

            Nomes();
        }//end of void menu

        public static void Nomes()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("             +====================================+");
            Console.WriteLine("             |Que nome quer dar ao seu personagem?|");
            Console.WriteLine("             +====================================+");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("             +===============================================+");
            Console.WriteLine("             |Beleza... Agora que nome quer dar ao seu amigo?|");
            Console.WriteLine("             +===============================================+");
            nomeAmigo = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("             +=================================================+");
            Console.WriteLine("             |Ok!! Seu nome é " + nome + " , e do seu amigo é " + nomeAmigo + " |");
            Console.WriteLine("             +=================================================+");
            Console.Clear();

            Console.WriteLine("             +===============================================+");
            Console.WriteLine("             |Beleza... Agora vamos começar o joguinho...    |");
            Console.WriteLine("             +===============================================+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                     Pressione ENTER para continuar!");
            Console.ReadKey();
            Console.Clear();

            Cena1();
        }//end of Nomes

        public static void Cena1()
        {
            Console.WriteLine("             +===============================================+");
            Console.WriteLine("             |" + nome + " é um jovem tranquilo, alto astral" );
            Console.WriteLine("             +===============================================+");
        }
    }//end of class
}//end of namespace
