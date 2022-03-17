namespace Program 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg binarny");
            String inputBin = Console.ReadLine(); //pobranie ciągu znaków
            bool wasOne = false; // Zmienna zapisująca stan pojawienia się jedynki w naszym ciągu
            bool wasZero = false; // Zmienna zapisująca stan pojawienia się zera w naszym ciągu
            int holeCount = 0; // Zmienna definiująca liczbę dziur w ciągu
            for (int i = 0; i < inputBin.Length; i++) //pętla for działająca na podstawie długości wprowadzonego ciągu znaków
            {
                switch (inputBin[i]) // instrukcja switch sprawdzająca znak po znaku nasz ciag.
                {
                    case '0':
                        if (wasOne == true) // jeżeli była wczesniej jedynka to zostaje oznaczona flaga ze pojawilo sie zero
                        {
                            wasZero = true;
                        }
                        break;
                    case '1':
                        if (wasZero == true) // jezeli pojawilo się wcześniej zero to znaczy że była dziura
                        {
                            holeCount++; // inkrementacja liczby dziur
                            wasZero = false; // ustawienie flagi zera na fałsz
                        }
                        wasOne = true; //niezaleznie od warunku flaga zawsze w przypadku znalezienia jedynki bedzie jedynka
                        break;
                    default: //jezeli trafil znak niepowolany inny niz 0 lub 1 to operacja zostanie przerwana
                        Console.WriteLine("Ciąg binarny posiada znaki niedozwolone.");
                        return;
                }
            }
            Console.WriteLine("Liczba dziur dla podanego ciagu wynosi: " + holeCount); // zostaje wypisana finalna liczba dziur
        }
    }
}