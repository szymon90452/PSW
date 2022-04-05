namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            bool valueCorrect = true;
            int tableSize;
            double sumaOdchl = 0;
            double odchylenie = 0;
            double[] correctValues = { 2, 3, 3.5, 4, 4.5, 5 };
            bool isInArray = false;

            Console.WriteLine("Proszę podać wielkość tablicy: ");

            try
            {
                tableSize = int.Parse(Console.ReadLine());
            }
            catch (FormatException) 
            {
                Console.WriteLine("Podano niepoprawny format. Ustawiono wartość domyślnie na 5.");
                tableSize = 5;
            }

            double[] array1 = new double[tableSize];
            double[] uniqueArray = new double[tableSize];
            int[] numberOfUniqueNums = new int[tableSize];

            Console.WriteLine("Proszę o podanie liczb z zakresu: 2, 3, 3.5, 4, 4.5, 5 ");

            for (int i = 0; i < tableSize; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element tablicy: ");
                while (true)
                {
                    try
                    {
                        array1[i] = double.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        valueCorrect = false;
                    }

                    foreach (double correctValue in correctValues) {
                        if (correctValue == array1[i])
                        {
                            valueCorrect = true;
                            break;
                        }
                        else {
                            valueCorrect = false;
                        }
                    }

                    if (valueCorrect == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Podano liczbę spoza zakresu. Proszę podać jeszcze raz");
                        valueCorrect = true;
                    }
                }
            }

            Console.WriteLine("Średnia wartość zbioru wynosi: " + array1.Average());
            Console.WriteLine("Wartość minimalna zbioru wynosi: " + array1.Min());
            Console.WriteLine("Wartość maksymalna zbioru wynosi: " + array1.Max());

            Console.WriteLine("Wartości poniżej średniej: ");
            foreach (double number in array1) 
            {
                if (number < array1.Average()) 
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Wartości poniżej średniej: ");
            foreach (double number in array1)
            {
                if (number > array1.Average())
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < tableSize; i++)
            {
                isInArray = false;

                for (int j = 0; j < tableSize; j++)
                {
                    if (array1[i] == uniqueArray[j]) {
                        numberOfUniqueNums[j]++;
                        isInArray = true;
                        break;
                    }
                }

                if (isInArray == false) {
                    for (int j = 0; j < tableSize; j++)
                    {
                        if (uniqueArray[j] == 0) {
                            uniqueArray[j] = array1[i];
                            numberOfUniqueNums[j] = 1;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine("Częstotliwość występowania liczb:");

            for (int i = 0; i < tableSize; i++)
            {
                if (uniqueArray[i] != 0)
                {
                    if (numberOfUniqueNums[i] > 1)
                    {
                        Console.WriteLine(uniqueArray[i] + " - " + numberOfUniqueNums[i] + " razy");
                    }
                    else
                    {
                        Console.WriteLine(uniqueArray[i] + " - " + numberOfUniqueNums[i] + " raz");
                    }
                }
                else {
                    break;
                }
            }

            for (int x = 0; x < tableSize; x++) 
            {
                sumaOdchl += Math.Pow(array1[x] - array1.Average(),2);
            }
            odchylenie = Math.Sqrt(sumaOdchl / tableSize);
            Console.WriteLine("Odchylenie standardowe wynosi:" + odchylenie);
        }
    }
}