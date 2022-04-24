using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw2
{
    class Program
    {
        static public void Main(String[] args)
        {

            String choice;
            int indexNumber;
            Uni uni = new Uni();

            while (true)
            {
                displayMenu();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        addStudent(uni);
                        break;
                    case "2":
                        Console.WriteLine("Usuwanie studenta: ");
                        Console.Write("numer indeksu: ");
                        indexNumber = int.Parse(Console.ReadLine());
                        uni.removeStudent(indexNumber);
                        break;
                    case "3":
                        Console.WriteLine("Oblicz średnią studenta");
                        Console.Write("numer indeksu: ");
                        indexNumber = int.Parse(Console.ReadLine());
                        uni.countAvg(indexNumber);
                        break;
                    case "4":
                        Console.WriteLine("Oblicz średnią wszystkich studentów");
                        uni.countAvgForALL();
                        break;
                    case "5":
                        Console.WriteLine("Zakończenie programu.");
                        return;
                    default:
                        Console.WriteLine("Nie rozpoznano polecenia. Proszę podać jeszcze raz.");
                        break;
                }
                pressToContinue();
            }
        }

        static void displayMenu() 
        {
            Console.WriteLine("PROGRAM");
            Console.WriteLine("-----------------");
            Console.WriteLine("1) Dodaj studenta");
            Console.WriteLine("2) Usuń studenta");
            Console.WriteLine("3) Oblicz średnią studenta");
            Console.WriteLine("4) Oblicz wszystkich studentów");
            Console.WriteLine("5) Wyjście");
            Console.WriteLine("-----------------");
        }

        static void addStudent(Uni uni)
        {
            String name;
            String surname;
            int indexNumber;
            int year;
            int i = 1;
            bool ask;
            bool correctValue = false;
            while (true)
            {
                try
                {
                    Console.WriteLine("Wprowadzenie studenta: ");
                    Console.Write("imię: ");
                    name = Console.ReadLine();
                    Console.Write("nazwisko: ");
                    surname = Console.ReadLine();
                    Console.Write("numer indeksu: ");
                    indexNumber = int.Parse(Console.ReadLine());
                    Console.Write("rok studiów: ");
                    year = int.Parse(Console.ReadLine());
                    Student newStudent = new Student(indexNumber, name, surname, year);

                    while (true)
                    {
                        correctValue = false;
                        Console.Write("ocena nr " + i + ": ");
                        double mark = double.Parse(Console.ReadLine());
                        if (mark == 0)
                        {
                            i = 1;
                            break;
                        }
                        foreach (double correctMark in uni.getCorrectMarks())
                        {
                            if (mark == correctMark)
                            {
                                newStudent.addMark(mark);
                                i++;
                                correctValue = true;
                                break;
                            }
                        }

                        if (correctValue == false)
                        {
                            Console.WriteLine("Podano niepoprawną ocenę.");
                        }

                        ask = continueOperation("Czy kontynuować dalej wprowadzanie ocen? (T/N): ");

                        if (ask == false)
                        {
                            break;
                        }

                    }
                    uni.addStudent(newStudent);

                    ask = continueOperation("Czy kontynuować dalej wprowadzanie studentów? (T/N): ");

                    if (ask == false)
                    {
                        return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wprowadzono nieprawidłowy format wartości. Proszę spróbować jeszcze raz");
                }
                

            }
        }

        static bool continueOperation(string text)
        {
            string answer;
            Console.WriteLine(text);
            while (true) 
            {
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "t":
                        return true;
                    case "T":
                        return true;
                    case "n":
                        return false;
                    case "N":
                        return false;
                    default:
                        Console.WriteLine("Nie rozpoznano odpowiedzi.");
                        break;
                }
            }
        }

        static void pressToContinue()
        {
            Console.WriteLine("Proszę wcisnąć klawisz aby kontynuować.");
            Console.ReadKey();
        }
    }
}
