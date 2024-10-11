using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int db = 5;
            Random random = new Random();
            int[] lista = new int[db];

            for (int i = 0; i < db; i++)
            {

                lista[i] = random.Next(1, 101);

            }

            Console.WriteLine("A tömb számai: ");
            foreach (int szam in lista)
            {

                Console.Write(szam + ",");

            }

            Console.WriteLine();

            int minszam = lista[0];
            int maxszam = lista[0];

            for (int i = 1; i < lista.Length; i++)
            {
                if (lista[i] < minszam)
                {
                    minszam = lista[i];
                }
                if (lista[i] > maxszam)
                {
                    maxszam = lista[i];
                }
            }

            Console.WriteLine("A legkisebb szám: " + minszam);
            Console.WriteLine("A legnagyobb szám: " + maxszam);
        }
    }
}
