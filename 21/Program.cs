using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int user, user1, user2, com, com1, com2, somaU, somaU1, somaC, somaC1, resposta;
            Random r = new Random();
            
            Console.WriteLine("Blackjack");
            user = r.Next(1, 13);
            com = r.Next(1, 13);
            user1 = r.Next(1, 13);
            com1 = r.Next(1, 13);
            Console.WriteLine("User: " + user + "/" + user1 + "\n");
            Console.ReadKey();
            Console.WriteLine("Com: " + com + "/" + "* \n" );
            somaU = user + user1;
            somaC = com + com1;


            Console.WriteLine("Deseja receber outra carta? \n" +
                "[1] - SIM / [2] - NÃO");
            resposta = Int32.Parse(Console.ReadLine());
            Console.Clear();

            if (resposta == 1) 
            {
                user2 = r.Next(1, 13);
                com2 = r.Next(1, 13);

                somaU1 = somaU + user2;
                somaC1 = somaC + com2;

                Console.WriteLine("User: " + somaU1);
                Console.WriteLine("Com: " + somaC1);

                if (somaU1 < 21 && somaC1 < 21)
                {                    
                    if (somaU1 > somaC1)
                    {                        
                        Console.WriteLine("Parabéns você venceu!");
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!");
                    }
                }
                else
                {
                    Console.WriteLine("User: " + somaU);
                    Console.WriteLine("Com: " + somaC);

                    if (somaU1 > somaC1)
                    {
                        Console.WriteLine("Parabéns você venceu!");
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu!");
                    }
                }
            }
            else
            {
                if (somaU > somaC)
                {
                    Console.WriteLine("Parabéns você venceu!");
                }
                else
                {
                    Console.WriteLine("Você perdeu!");
                }
            }


            Console.ReadLine();
        }
    }
}
