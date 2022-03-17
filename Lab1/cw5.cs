namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę");
                int inputNumber = int.Parse(Console.ReadLine());
                int number = inputNumber / 2; // dzielenie w celu zmniejszenia liczby operacji
                bool ifPrime = true; // zmienna przechowująca status liczby pierwszej
                for (int i = 2; i <= number; i++)
                {
                    if (inputNumber % i == 0) // operacja modulo sprawdzająca czy liczba jest podzielna przez inną liczbę
                    {
                        Console.Write("Podana liczba: " + inputNumber + " \nNie jest liczbą pierwszą!");
                        ifPrime = false; // w przypadku gdy nie jest liczba pierwsza warunek jest fałszywy i przerywane jest dalsze liczenie
                        break;
                    }
                }
                if (ifPrime == true) // Jezeli warunek jest spełniony to wyświetli się komunikat informacyjny
                {
                    Console.Write("Podana liczba: " + inputNumber + " \nJest liczbą pierwszą!");
                }
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("Podano wartość nieliczbową.");
            }

        }
    }
}