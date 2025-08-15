int[] vetor = new int[1000];
        Random rnd = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rnd.Next(0, 10000); 
        }

        BubbleSort(vetor);

        Console.WriteLine("Primeiros 10 valores ordenados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetor[i]);
        }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }