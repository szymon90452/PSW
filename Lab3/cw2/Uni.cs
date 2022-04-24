using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw2
{
    class Uni
    {
        List<Student> StudentList = new List<Student>();
        List<double> CorrectMarks = new List<double>() { 2, 3, 3.5, 4, 4.5, 5 };

        public List<double> getCorrectMarks()
        {
            return this.CorrectMarks;
        }

        public void addStudent(Student student)
        {
            foreach (Student oldStudent in StudentList) 
            {
                if (student.getIndexNumber() == oldStudent.getIndexNumber()) 
                {
                    Console.WriteLine("Istnieje już student z takim indeksem.");
                    return;
                }
            }
            StudentList.Add(student);
            Console.WriteLine("Student został dodany do listy.");
        }

        public void removeStudent(int indexNumber) 
        {
            foreach (Student student in StudentList)
            {
                if (student.getIndexNumber() == indexNumber)
                {
                    StudentList.Remove(student);
                    Console.WriteLine("Student został usunięty z listy.");
                    return;
                }
            }
            Console.WriteLine("Nie znaleziono studenta z takim indeksem.");
        }

        public void countAvg(int indexNumber)
        {
            foreach (Student student in StudentList)
            {
                if (student.getIndexNumber() == indexNumber)
                {
                    student.display();
                    Console.WriteLine("Średnia studenta z indeksem " + indexNumber + " wynosi: " + (student.getMarks().Sum() / student.getMarks().Count()));
                    return;
                }
            }
            Console.WriteLine("Nie znaleziono studenta z takim indeksem.");
        }

        public void countAvgForALL()
        {
            double sum = 0;
            int count = 0;
            foreach (Student student in StudentList)
            {
                sum += student.getMarks().Sum();
                count += student.getMarks().Count();
            }
            Console.WriteLine("Średnia wszystkich studentów wynosi: " + (sum / count));
        }

    }
}
