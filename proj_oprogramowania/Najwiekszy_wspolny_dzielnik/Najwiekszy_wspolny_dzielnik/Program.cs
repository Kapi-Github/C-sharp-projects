namespace Najwiekszy_wspolny_dzielnik
{
    internal class Program
    {
        static int NWD(int a, int b)
        {
            return a == b ? b : a > b ? NWD(a - b, b) : NWD(a, b - a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwszą liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = NWD(a, b);
            Console.WriteLine($"Największy wspólny dzielnik liczb {a} i {b} to: {result}");
        }
    }
}
