namespace Program {

    class Program {

        static void Main(string[] args) 
        {
            var hash = new HashSet<int>(); // Zdefiniowany zestaw wartości typu liczbowego całkowitego
            Console.WriteLine("Wprowadzam 5 wartości: ");
            for (int i = 1; i <= 5; i++) //Pętla iteracyjna, która wykona się 5 razy w celu wprowadzenia wartości do naszego zestawu wartosci.
            {
                try // error handling na wprowadzenie pustej wartości i nieliczbowej
                {
                    Console.WriteLine("Podaj liczbę nr " + i);
                    string number = Console.ReadLine(); // pobieranie ciągu znaków wprowadzonego do konsoli.
                    hash.Add(int.Parse(number)); // dodanie liczby do zestawu i wcześniejsze przekształcenie ze string na int
                }
                catch (System.FormatException) 
                {
                    Console.WriteLine("Podano wartość nieliczbową");
                    return;
                }
            }
            Console.WriteLine("Liczba unikalnych wartości wynosi: "+ hash.Count); // Wyświetlenie długości naszego zestawu
            Console.WriteLine(string.Join(",", hash)); // Wyświetlenie wszystkich znaków zestawu (wszystkie znaki są unikalnymi)
        }
    
    }

}