using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_do_laços
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int cont = 0 ; cont < 3; cont++)
            int menu;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1- numeros pares sequencia\n2- fibonacci \n3- numeros impares sequencia");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("digite o numero de 1 a 3: ");
            menu = int.Parse(Console.ReadLine());
            

            if (menu == 1)
            {
                Console.Write("digite o 1 numero: ");
                
                int valor1
                    = int.Parse(Console.ReadLine());

                Console.Write("digite o 2 numero: ");
                
                int valor2
                    = int.Parse(Console.ReadLine());

                for (int cont = valor1; cont <= valor2; cont++)
                {
                    
                    if (cont % 2 == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("seus numeros sao" + cont);
                    }
                }


            }
            else if (menu == 2)
            {
                
                Console.Write("bem vindo a sequencia de fibonacci digite sua posiçao: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("digite uma opçao valida");
                    Console.WriteLine("");
                }

                Console.WriteLine("");
                Console.Write("sua sequencia de fibonacci " + numero + " é: ");

                if (numero >= 0) 
                        Console.Write("\n0");
                Console.WriteLine("");

                if (numero >= 1) 
                        Console.Write("\n1");
                Console.WriteLine("");

                double a = 0, b = 1;

                for (double final =  3; final <= numero + 1; final++)
                {
                    double c = a + b;
                    Console.WriteLine("\n" + c);

                    a = b ; b = c;
                }

            }
            else if (menu == 3)
            {
                Console.Write("digite o 1 numero: ");

                int valor1
                    = int.Parse(Console.ReadLine());

                Console.Write("digite o 2 numero: ");

                int valor2
                    = int.Parse(Console.ReadLine());

                for (int cont = valor1; cont <= valor2; cont++)
                {

                    if (cont % 2 != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("seus numeros sao" + cont);
                    }
                }


            }




            Console.ReadKey();
        }
    }
}
