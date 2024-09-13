using System;

namespace Wyszukiwanie_naiwne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            string s = "";

            for(int i = 0; i < 60; i++)
            {
                s += (char)rand.Next('A', 'Z' + 1);
            }

            s = s.ToLower();

            Console.WriteLine($"Tekst: {s}");
            Console.WriteLine("Wpisz szukany łańcuch znaków");
            string p = Console.ReadLine();
            int znaleziona = -1;
            int ileznaleziono = 0;

            int k;
            for (k = 0; k < s.Length; k++)
            {
                for(int j = 0; j < p.Length; j++)
                {
                    if ((k + j < s.Length) && p[j] == s[k + j])
                    {
                        ileznaleziono++;
                    }
                }
                if(ileznaleziono == p.Length)
                {
                    znaleziona = k;
                    break;
                }
                else
                {
                    ileznaleziono = 0;
                    k += ileznaleziono;
                }
            }

            if(znaleziona >= 0)
            {
                Console.WriteLine($"Znaleziono na pozycji {znaleziona}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono");
            }
        }
    }
}
