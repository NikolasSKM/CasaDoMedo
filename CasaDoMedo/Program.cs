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
            Console.WriteLine("      +===========================================================+");
            Console.WriteLine("      | Por favor, entre e sinta-se em casa... HAHAHAHAHAHAHA!!!! |");
            Console.WriteLine("      +===========================================================+");
            Console.WriteLine();
            Console.WriteLine("                     Pressione ENTER para continuar!");
            Console.ReadKey();
            Console.Clear();

            Nomes();
        }//end of void menu

        public static void Nomes()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("             +==============================================================================================================+");
            Console.WriteLine("             |Que nome quer dar ao seu personagem (somente do sexo masculino, se não ia ficar difícil o desenvolvimento =D)?|");
            Console.WriteLine("             +==============================================================================================================+");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("             +=========================================================================================================+");
            Console.WriteLine("             |Beleza... Agora que nome quer dar ao seu amigo (eu sei, eu sei, mas ainda vou melhorar o código rsrs =D)?|");
            Console.WriteLine("             +=========================================================================================================+");
            nomeAmigo = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("             +=================================================+");
            Console.WriteLine("             |Ok!! Seu nome é " + nome + " , e do seu amigo é " + nomeAmigo + " |");
            Console.WriteLine("             +=================================================+");
            Console.Clear();

            Console.WriteLine("             +===============================================+");
            Console.WriteLine("             |Fecho... Agora vamos começar o joguinho...     |");
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
            var resp = "";
            Console.WriteLine("+=====================================================================================================================================+");
            Console.WriteLine(nome + " é um jovem tranquilo, introvertido mas de bom humor, prefe mesmo é estar no aconchego da sua casa e na companhia de seus jogos maravilhosos do que estar na rua, mas se precisar sair, prefere" +
                " um bom pub ou um encontrão na casa de seus amigos... com churrasco e muita cerveja, é claro! Qual a surpresa, ele sabe se divertir, ele é gamer e não bicho do mato");
            Console.WriteLine("Vive numa cidade chamada Extranhoville, que não possui muitos abitantes, fica no interior do país. Algo tem ocorrido na cidade e tem deixado todos muito preocupados, está havendo muitos sumissos de moradores," +
                " então qualquer demora de resposta no Whatsapp passa de um mero vácuo para um possível sequestro. Numa linda tarde seu amigo" + nomeAmigo + " manda um whats pedindo que" + nome + " vá até sua casa porque quer conversar sobre" +
                " esses sequestros, pois acha que sabe quem pode estar por trás disso.");
            Console.WriteLine("+======================================================================================================================================+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             +=============================+");
            Console.WriteLine("             |O que" + nome + " deve fazer?|");
            Console.WriteLine("             +=============================+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             +===================================================================+");
            Console.WriteLine("             |1 - Ligar para seu amigo?                                          |");
            Console.WriteLine("             |2 - Ir dormir pois já é tarde da noite e de manhã tem de trabalhar!|");
            Console.WriteLine("             |3 - Ir até a casa de" + nomeAmigo + " pois quer dar uma caminhada! |");
            Console.WriteLine("             +===================================================================+");
            Console.WriteLine();
            resp = Console.ReadKey();

            if (resp == "1")
            {
                Cena1_1();
            }
            if (resp == "2")
            {
                Cena2();
            }
            if (resp == "3")
            {
                Cena1_2();
            }
            else
            {
                Cena1();
            }
        }//end of Cena1

        public static void Cena1_1()
            {
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine(nomeAmigo + " não atende o smartphone apesar das inúmeras tentativas de ligação de" + nome + ". Apesar de achar muito estranho não ser atendido, acaba indo dormir pois está tarde e tem de trabalhar bem" +
                    " cedo na manhã seguinte.");
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine();
                Console.WriteLine("                     Pressione ENTER para continuar a história!");
                Console.ReadKey();
                Console.Clear();

                Cena2();
            }//end of Cena1_1

        public static void Cena1_2()
            {
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine("Antes de sair, olhou a hora e viu que já era muito tarde e na manhã seguinte inicia seu trabalho bem cedo, então decide deixar para ligar no dia seguinte após seu expediente de trabalho.");
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine();
                Console.WriteLine("                     Pressione ENTER para continuar a história!");
                Console.ReadKey();
                Console.Clear();

                Cena2();
            }//end of Cena1_2

        public static void Cena2()
            {
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine("No dia seguinte após seu expediente, tentar ligar para seu amigo, mas depois de inúmeras tentativas não consegue contato.");
                Console.WriteLine("+=======================================================================================================================================================+");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             +=============================+");
                Console.WriteLine("             |O que" + nome + " deve fazer?|");
                Console.WriteLine("             +=============================+");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             +==============================================================================================================+");
                Console.WriteLine("             |1 - Ligar para a policia? Pois é preocupante por causa dos ocorridos da cidade.                               |");
                Console.WriteLine("             |2 - Ir até a casa de" + nomeAmigo + "? Pois está preocupado, principalmente por causa dos ocorridos da cidade.|");
                Console.WriteLine("             |3 - Não dar bola e ir para casa descansar. Seu amigo já é bem grandinho e sabe se cuidar.                     |");
                Console.WriteLine("             +==============================================================================================================+");
                Console.WriteLine();
                resp = Console.ReadKey();
            }//end of Cena2
    }//end of class
}//end of namespace
