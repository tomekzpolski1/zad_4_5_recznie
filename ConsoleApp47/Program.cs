using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ilu elementowa ma być tab1");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] tab1 = new int[rozmiar];
            int[] tab2 = new int[rozmiar];
            // wersja z recznym wpisywaniem liczb
            for (int i = 0; i < tab1.Length; i++) //petla zapelniająca tablice liczbami
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementy tab1 to:");
            for (int i = 0; i < tab1.Length; i++) // petla wypisujaca elementy tablicy
            {
                Console.Write(tab1[i] + " ");
            }
            Console.WriteLine();
            for (int j = 1; j < tab1.Length; j++)
            {
                tab2[j] = tab1[j - 1];
            }

            tab2[0] = tab1[rozmiar - 1];
            Console.WriteLine("Tab2 ma postać:");
            foreach (int x in tab2)
            {
                Console.WriteLine(x+" ");
            }
        }
    }
}
