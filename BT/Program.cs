using System;
using System.Collections.Generic;

namespace BT1
{
    public class Program
    {
        public static Random random = new Random();
        public static Student[] students = new Student[]
             {
                new Student(){Name="A", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="B", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="C", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="D", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="E", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="F", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="G", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="H", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="I", SubjectName="Math" ,MathScore= random.Next(0,10)},
                new Student(){Name="K", SubjectName="Math" ,MathScore= random.Next(0,10)},
             };
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(students);
            myClass.Display();
        }

    }

    public class MyClass
    {
        private Student[] _listStudents;
        public MyClass(Student[] listStudents)
        {
            _listStudents = listStudents;
        }

        public decimal MinScore()
        {
            decimal minValue = _listStudents[0].MathScore;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                int minIndex = i;
                if(_listStudents[minIndex].MathScore < minValue)
                {
                    minValue = _listStudents[minIndex].MathScore;
                }
            }
            return minValue;
        }

        public decimal MaxScore()
        {
            decimal maxValue = _listStudents[0].MathScore;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                int maxIndex = i;
                if(_listStudents[maxIndex].MathScore > maxValue)
                {
                    maxValue = _listStudents[maxIndex].MathScore;
                }
            }
            return maxValue;
        }

        public decimal AverageScore()
        {
            decimal average = 0;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                average += _listStudents[i].MathScore / _listStudents.Length;
            }
            return average;
        }

        public void Display()
        {
            foreach(Student student in _listStudents)
            {
                Console.WriteLine($"Student Name: {student.Name} \t Subject: {student.SubjectName} \t Score: {student.MathScore}");
            }
            Console.WriteLine("____________________________");
            Console.WriteLine($"Min Score: {this.MinScore()} \t Max Score: {this.MaxScore()} \t Average: {this.AverageScore()}");
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string SubjectName { get; set; }
        public decimal MathScore { get; set; }

        //public Mathematics Mathematics { get; set; }
    }

    //public class Mathematics
    //{
    //    public string Name = "Mathematics";
    //    public decimal Score { get; set; }
    //}


}
