using System;

namespace Instrucoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int numero = 2; 
            switch (numero)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numero} argumentos");
                    break;
                    
            }*/
            

            /*int i = 15;

            while (i > 0)
            {
                Console.WriteLine($"Número = {i}");
                i--;
            }*/
            

            /*string texto;

            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));*/
            

            /*for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(i);
            } */
            

            /*while (true)
            {
                string s = Console.ReadLine();

                if (!string.IsNullOrEmpty(s))
                    break;
                
                Console.WriteLine(s);
            }*/
            

            /*int Somar(int a, int b)
            {
                return a + b;
            }
            
            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));*/
            

            /*double Dividir(double x, double y)
            {
                if (y == 5)
                    throw new DivideByZeroException();
                return x / y;
                
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro generico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até Breve");
            }*/
            

            /* Preenchendo array unidimensional
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
                Console.WriteLine($"a[{i}] = a[{i}]");
            }*/
            
            
            /*Array multidimensional
            int[,] a2 = new int[10, 5];
            int[,,] a3 = new int[10, 5, 2];

            /*Inicializador de array
            int[] a = {1, 2, 3};;*/
        }
    }
}
