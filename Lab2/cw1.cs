namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {

            int[] array1 = new int[10];
            bool valueCorrect = true;
            int temp;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Podaj " + (i + 1) + " element tablicy: ");
                while (true)
                {
                    try
                    {
                        array1[i] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Podano niewłaściwy format. Format powinien być liczbowy");
                        valueCorrect = false;
                    }

                    if (valueCorrect == true)
                    {
                        break;
                    }
                    else 
                    {
                        valueCorrect = true;
                    }
                }
            }

            Console.WriteLine("Tablica przed sortowaniem: ");
            Console.WriteLine(string.Join(",", array1));

            for (int j = 0; j < array1.Length; j++)
            {
                for (int k = 0; k < array1.Length - 1; k++)
                {
                    if (array1[k] > array1[k + 1])
                    {
                        temp = array1[k + 1];
                        array1[k + 1] = array1[k];
                        array1[k] = temp;
                    }
                }
            }

            Console.WriteLine("\nTablica po sortowaniu: ");
            Console.WriteLine(string.Join(",", array1));
        }
    }
}