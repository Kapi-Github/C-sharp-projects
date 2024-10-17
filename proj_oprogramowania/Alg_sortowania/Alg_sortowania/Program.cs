namespace Alg_sortowania
{
    internal class Program
    {   
        class Algorytm
        {
            private int[] liczby = new int[10];
            private int[] tab = new int[10];
            public void WprowadzTablice()
            {
                for (int i = 0; i < liczby.Length; i++)
                {
                    Console.Write($"Wprowadź {i + 1} liczbę tablicy: ");
                    this.liczby[i] = Convert.ToInt32( Console.ReadLine());
                }
            }
            public void WyswietlTablice()
            {
                Console.WriteLine('\n');
                foreach (int number in this.liczby)
                {
                    Console.Write($"{number}   ");
                }
                Console.WriteLine('\n');
            }

            public void WyswietlTablice(int[] tab)
            {
                Console.WriteLine('\n');
                foreach (int number in tab)
                {
                    Console.Write($"{number}   ");
                }
                Console.WriteLine('\n');
            }

            private static void Swap(int[] array, int i, int j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            public int[] BubbleSort()
            {
                int temp = -1;
                Array.Copy(liczby, tab, 10); 
                for(int i = 0; i < tab.Length - 1; i++)
                {
                    for(int j = 0; j < tab.Length - i - 1; j++)
                    {
                        if( tab[j] < tab[j + 1])
                        {
                            Swap(tab, j, j + 1);
                        }
                    }
                }
                return tab;
            }

            public int[] InsertionSort()
            {
                Array.Copy(liczby, tab, 10);
                for (int i = 0; i < tab.Length; i++) 
                {
                    int key = tab[i];
                    int j = i - 1;

                    while (j >= 0 && tab[j] < key)
                    {
                        tab[j + 1] = tab[j];
                        j = j - 1;
                    }
                    tab[j + 1] = key;
                }
                return tab;
            }
        }

        static void Main(string[] args)
        {
            Algorytm alg = new();
            alg.WprowadzTablice();

            Console.Write("\nTablica");
            alg.WyswietlTablice();

            int[] bubble = alg.BubbleSort();
            Console.Write($"Bubble sort: ");
            alg.WyswietlTablice(bubble);

            int[] insertion = alg.InsertionSort();
            Console.Write($"Insertion sort: ");
            alg.WyswietlTablice(insertion);

            //int[] quick = alg.QuickSort();
            //Console.Write($"Quick sort: ");
            //alg.WyswietlTablice(quick);

            Console.ReadLine();
        }
    }
}
