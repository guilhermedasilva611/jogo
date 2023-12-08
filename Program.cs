using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Faça um programa que receba um golpe que um personagem deve executar. O programa
deve ficar solicitando golpes até o usuário responder que não deseja mais executá-lo. Para
identificar os golpes, utilize 3 teclas: c (chute), s (soco) e m (magia), onde: chute vale 2
pontos, soco 4 pontos e magia 10 pontos. No final, o programa deve exibir para o usuário o
número e a pontuação obtida por cada tipo de golpe, bem como a pontuação total do
usuário.
 */


namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----JOGO DE LUTA-----");

            const int chute = 2;
            const int soco = 4;
            const int magia = 10;

            int repetir = 1, totalPontos = 0, c = 0, s = 0, m = 0;
            

            do
            {
                Console.Write("Realize um golpe...\n(c)-CHUTE\n(s)-SOCO \n(m)-MAGIA\n");
                string golpe = Console.ReadLine().ToLower();

                switch (golpe)
                {

                    case "c":
                        Console.WriteLine("Chute realizado!");
                        totalPontos += chute;
                        c++;
                        break;

                    case "s":
                        Console.WriteLine("Soco realizado!");
                        totalPontos += soco;
                        s++;
                        break;

                    case "m":
                        Console.WriteLine("Magia realizada!");
                        totalPontos += magia;
                        m++;
                        break;

                    default:
                        Console.WriteLine("Golpe inválido!!!");
                        break;

                }

                Console.WriteLine("Deseja realizar um novo golpe?\n(1)-sim \n(2)-Não");
                repetir = int.Parse(Console.ReadLine());


            } while (repetir == 1);


            Console.WriteLine($"Você realizou: Chutes {c}, pontos:{c * chute} Socos {s}, pontos:{s * soco} Magia, {m}, pontos:{m * magia}\n PONTOS: {totalPontos}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
