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
                Random rand = new Random();
                for (int i = 0; i < liczby.Length; i++)
                {
                    Console.Write($"Wprowadź {i + 1} liczbę tablicy: ");
                    {
                        try
                        {
                            this.liczby[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            this.liczby[i] = rand.Next(11);
                        }
                    }
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

            public int[] QuickSort()
            {
                Array.Copy(liczby, tab, 10);
                QuickSortHelper(tab, 0, tab.Length - 1);
                return tab;
            }

            private void QuickSortHelper(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int pivot = Partition(array, low, high);
                    QuickSortHelper(array, low, pivot - 1);
                    QuickSortHelper(array, pivot + 1, high);
                }
            }

            private int Partition(int[] array, int low, int high)
            {
                int pivot = array[high];
                int i = (low - 1);

                for (int j = low; j < high; j++)
                {
                    if (array[j] > pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                Swap(array, i + 1, high);
                return i + 1;
            }

            public int[] MergeSort()
            {
                Array.Copy(liczby, tab, liczby.Length); // Użyj liczby.Length zamiast tab.Length - 1
                MergeSortHelper(tab, 0, tab.Length - 1);
                return tab;
            }

            private void MergeSortHelper(int[] array, int left, int right)
            {
                if (left < right)
                {
                    int middle = (left + right) / 2;

                    MergeSortHelper(array, left, middle);
                    MergeSortHelper(array, middle + 1, right);

                    Merge(array, left, middle, right);
                }
            }

            private void Merge(int[] array, int left, int middle, int right)
            {
                int n1 = middle - left + 1;
                int n2 = right - middle;

                int[] L = new int[n1];
                int[] R = new int[n2];

                Array.Copy(array, left, L, 0, n1);
                Array.Copy(array, middle + 1, R, 0, n2);

                int i = 0, j = 0, k = left;

                while (i < n1 && j < n2)
                {
                    if (L[i] >= R[j])
                    {
                        array[k] = L[i];
                        i++;
                    }
                    else
                    {
                        array[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    array[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    array[k] = R[j];
                    j++;
                    k++;
                }
            }
        }

        static void Main(string[] args)
        {
            Algorytm alg = new();
            alg.WprowadzTablice();

            Console.Write("\nTablica");
            alg.WyswietlTablice();

            int[] bubble = alg.BubbleSort();
            Console.Write("Bubble sort: ");
            alg.WyswietlTablice(bubble);

            int[] insertion = alg.InsertionSort();
            Console.Write("Insertion sort: ");
            alg.WyswietlTablice(insertion);

            int[] quick = alg.QuickSort();
            Console.Write("Quick sort: ");
            alg.WyswietlTablice(quick);

            int[] merge = alg.MergeSort();
            Console.Write("Merge sort: ");
            alg.WyswietlTablice(merge);

            Console.ReadLine();
        }
    }
}
