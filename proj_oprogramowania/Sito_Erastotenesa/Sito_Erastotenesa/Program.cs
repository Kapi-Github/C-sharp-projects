namespace Sito_Erastotenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine("Wpisz zakres do jakiego chcesz znaleźć liczby pierwsze: ");
            n = Convert.ToInt32(Console.ReadLine());
            bool[] A = new bool[n - 1];
            Array.Fill(A, true);

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if(A[i-2] == true)
                {
                    for (int j = 2 * i; j <= n; j += i)
                    {
                        A[j-2] = false;
                    }
                }
            }

            Console.WriteLine("Liczby pierwsze");
            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] == true)
                {
                    Console.Write($"{i + 2}, ");
                }
            }

            Console.ReadLine();
        }
    }
}
