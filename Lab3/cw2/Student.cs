using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Cw2
{
    class Student
    {
        private int index_number;
        private String name;
        private String surname;
        private int year;
        private List<double> marks = new List<double>();

        public Student(int index_number, String name, String surname, int year)
        {
            this.name = name;
            this.surname = surname;
            this.index_number = index_number;
            this.year = year;
        }

        public int getIndexNumber()
        {
            return this.index_number;
        }

        public String getName()
        {
            return this.name;
        }

        public String getSurname()
        {
            return this.surname;
        }

        public int getYear()
        {
            return this.year;
        }

        public List<double> getMarks() 
        { 
            return this.marks;
        }

        void setIndexNumber(int newIndexNumber)
        {
            this.index_number = newIndexNumber;
        }

        void setName(String newName)
        {
            this.name = newName;
        }

        void setSurname(String newSurname)
        {
            this.surname = newSurname;
        }

        void setYear(int newYear)
        {
            this.year = newYear;
        }

        public void addMark(double mark)
        {
            this.marks.Add(mark);
        }

        public void display()
        {
            Console.WriteLine("Student "+this.name+" "+this.surname);
            Console.WriteLine("rok studiów: " + this.year);
            Console.Write("oceny: ");
            foreach (var item in marks)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine("");
        }

    }
}
