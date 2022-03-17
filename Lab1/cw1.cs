namespace Program {

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(101); //Zmienna przechwoująca losowaną liczbę, która jest losowana do 100 jako liczba całkowita
            int inputNumber; // Zmienna przechowująca wartość podaną z klawiatury
            Console.WriteLine("Zgadnij o jakiej liczbie myśle..."); //Wyświetlenie ciągu znaków w konsoli

            while (true)
            {

                Console.WriteLine("Podaj liczbę: ");
                try // Dokonanie aby w przypadku podania wartości pustej lub nieliczbowej program wysłał odpowiedni komunikat zamiast błedu lub erroru
                {
                    inputNumber = int.Parse(Console.ReadLine()); // Konwersja wartości na int                                           
                    if (inputNumber > randomNumber) // Sprawdzenie warunków
                    {
                        Console.WriteLine("Podana liczba jest wieksza od szukanej");
                    }
                    else if (inputNumber < randomNumber)
                    {
                        Console.WriteLine("Podana liczba jest mniejsza od szukanej");
                    }
                    else
                    {
                        Console.WriteLine("Brawo! Podana liczba jest równa szukanej");
                        break; // Jeżeli dojedzie do wyżej wymienionego warunku następuje wyjście z pętli co poprowadzi do zakończenia skryptu
                    }
                }
                catch (System.FormatException) // W przypadku podania nieprawidlowej wartosci zostanie wyzwolony ponizszy element
                {
                    Console.WriteLine("Podano pustą lub nieprawidłową wartość...");
                }

            }
        }
    }

}

