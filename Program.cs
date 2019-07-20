using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Impares = new List<int>();
            List<int> Pares = new List<int>();
            Console.WriteLine("NUMEROS PARES");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Pares.Add(i);

                }
            }
            foreach (int par in Pares)
            {
                Console.Write(par + ", ");

            }
            Console.WriteLine();
            Console.WriteLine("O SETIMO NUMERO PAR ENTRE 0 E 100 É: "+ Pares[6]);
            Descremento(Pares);
            Console.WriteLine("");
      
            Console.WriteLine("");
            Console.WriteLine("NUMEROS IMPARES");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Impares.Add(i);

                }
            }

            foreach (int Imp in Impares)
                Console.Write(Imp + ", ");
            Console.WriteLine();
            Console.WriteLine("O VIGÉSIMO NUMERO IMPAR É :" + Impares[19]);
            Descremento(Impares);
        }

        private static void Descremento(List<int> D)
        {
            for (int i=0; i<=D.Count-1; i++)
            {
                if (D[i] % 2 == 0)
                    D[i] += 1;
                else D[i] -= 1;
            }
            if (D[0] % 2 == 0) {
                D.Add(100);

            }
            D.Remove(101);
        }
       
    }
}

