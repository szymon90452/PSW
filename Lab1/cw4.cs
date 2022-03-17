namespace Program {
    class Program {
        static void getList(List<int> numList) // Metoda odpowiedzialna za pobieranie znaków do naszej listy
        {
            string input;
            input = Console.ReadLine();
            string[] array = input.Split(",");
            int singleNumber;
            foreach (string s in array)
            {
                if (Int32.TryParse(s, out singleNumber))
                {
                    numList.Add(singleNumber);
                }
            }
        }

        static void concatLists(List<int> list1, List<int> list2) // operacja sumy zbiorów
        {
            List<int> list = new List<int>();
            list.AddRange(list1);
            list.AddRange(list2);
            Console.WriteLine(String.Join(",", list));
        }

        static void differenceLists(List<int> list1, List<int> list2) // operacja różnicy zbiorów
        {
            var list3 = list1.Except(list2).ToList();
            Console.WriteLine(String.Join(",", list3));

        }

        static void commonItemsofLists(List<int> list1, List<int> list2) // operacja części wspólnej zbiorów
        {
            var list3 = list1.Intersect(list2);
            Console.WriteLine(String.Join(",", list3));
        }

        static void symetricDifference(List<int> list1, List<int> list2) // operacja różnicy symetrycznej zbiorów
        {
            var list3 = list1.Except(list2).Union(list2.Except(list1));
            Console.WriteLine(String.Join(",", list3));
        }

        static void Main(string[] args) // Metoda główna
        {
            List<int> numbers1 = new List<int>(); // pierwszy zbiór
            List<int> numbers2 = new List<int>(); // drugi zbiór
            Console.WriteLine("Podaj zbiór nr 1:");
            getList(numbers1);
            Console.WriteLine("Podaj zbiór nr 2:");
            getList(numbers2);
            Console.WriteLine("Suma zbiorów:");
            concatLists(numbers1, numbers2);
            Console.WriteLine("Różnica zbiorów:");
            differenceLists(numbers1, numbers2);
            Console.WriteLine("Część wspólna zbiorów:");
            commonItemsofLists(numbers1, numbers2);
            Console.WriteLine("Różnica symetryczna zbiorów:");
            symetricDifference(numbers1, numbers2);
        }
    }
}