using System;
using System.Collections.Generic;

namespace BT2
{
    class Program
    {
        public static Random random = new Random();
        public static Student[] students = new Student[]
        {
                new Student(){ Name = "A", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                } },
                new Student(){ Name = "B", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "C", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "D", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "E", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "F", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "G", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "H", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "I", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
                new Student(){ Name = "K", Subjects = new Subject[]{
                    new Subject() { Name = "Physics", Score = random.Next(0,10)},
                    new Subject() { Name = "Mathematics", Score = random.Next(0,10)},
                    new Subject() { Name = "Chemicals", Score = random.Next(0,10)},
                    new Subject() { Name = "English", Score = random.Next(0,10) }
                }},
        };
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(students);
            myClass.Display();

            Console.WriteLine("-----------");

            Console.ReadLine();
        }
    }

    public class MyClass
    {
        private Student[] _listStudents;
        public MyClass(Student[] listStudents)
        {
            _listStudents = listStudents;
        }

        // Điểm thấp nhất tất cả học sinh trên một môn 
        public Subject MinCoreOneSubjectInClass(string subName)
        {
            decimal minScore = _listStudents[0].Subjects[0].Score;
            for(int i = 0; i < _listStudents[i].Subjects.Length; i++)
            {
                if(subName == _listStudents[0].Subjects[i].Name)
                {
                    for(int j = 0; j < _listStudents.Length; j++)
                    {
                        int minIndex = j;
                        if(minScore > _listStudents[minIndex].Subjects[i].Score)
                        {
                            minScore = _listStudents[minIndex].Subjects[i].Score;
                        }
                    }
                }
            }
            return new Subject() { Name = subName,Score = minScore };
        }
        // Điểm cao nhất tất cả học sinh trên một môn 
        public Subject MaxCoreOneSubjectInClass(string subName)
        {
            var result = new { Name = subName,Socre = -1 };
            decimal maxScore = _listStudents[0].Subjects[0].Score;
            for(int i = 0; i < _listStudents[i].Subjects.Length; i++)
            {
                if(subName == _listStudents[0].Subjects[i].Name)
                {
                    for(int j = 0; j < _listStudents.Length; j++)
                    {
                        int maxIndex = j;
                        if(maxScore < _listStudents[maxIndex].Subjects[i].Score)
                        {
                            maxScore = _listStudents[maxIndex].Subjects[i].Score;
                        }
                    }
                }
            }
            return new Subject { Name = subName,Score = maxScore };
        }
        // Điểm thấp nhất tất cả học sinh trên tất cả các môn trong một lớp
        public decimal MinScoreAllSubjectInClass()
        {
            decimal minValue = _listStudents[0].Subjects[0].Score;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                for(int j = 0; j < _listStudents[i].Subjects.Length; j++)
                {
                    int minIndex = j;
                    if(_listStudents[i].Subjects[minIndex].Score < minValue)
                    {
                        minValue = _listStudents[i].Subjects[minIndex].Score;
                    }
                }
            }
            return minValue;
        }
        // Điểm cao nhất tất cả học sinh trên tất cả các môn trong một lớp
        public decimal MaxScoreAllSubjectInClass()
        {
            decimal maxValue = _listStudents[0].Subjects[0].Score;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                for(int j = 0; j < _listStudents[i].Subjects.Length; j++)
                {
                    int maxIndex = j;
                    if(_listStudents[i].Subjects[maxIndex].Score > maxValue)
                    {
                        maxValue = _listStudents[i].Subjects[maxIndex].Score;
                    }
                }
            }
            return maxValue;
        }
        // Điểm trung bình một môn trong lớp
        public decimal AverageScoreOneSubjectInClass(string subName)
        {
            decimal averageScore = 0;
            for(int i = 0; i < _listStudents[0].Subjects.Length; i++)
            {
                if(_listStudents[0].Subjects[i].Name == subName)
                {
                    for(int j = 0; j < _listStudents.Length - 1; i++)
                    {
                        averageScore += _listStudents[j].Subjects[0].Score / _listStudents.Length;
                    }
                }
            }
            return averageScore;
        }
        //Điểm trung bình một học sinh trong một lớp
        public decimal AverageScoreOneStudentInAllSubject(string name)
        {
            decimal averageSocre = 0;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                if(_listStudents[i].Name == name)
                {
                    for(int j = 0; j < _listStudents[i].Subjects.Length; j++)
                    {
                        averageSocre += _listStudents[i].Subjects[j].Score / _listStudents[i].Subjects.Length;
                    }
                }
            }
            return averageSocre;
        }
        //Điểm trung bình của lớp
        public decimal AverageScoreOfClass()
        {
            decimal averageSocreOneStudent = 0;
            for(int i = 0; i < _listStudents.Length; i++)
            {
                averageSocreOneStudent += AverageScoreOneStudentInAllSubject(_listStudents[i].Name);
            }
            decimal result = averageSocreOneStudent / _listStudents.Length;
            return result;
        }
        public void Display()
        {
            foreach(Student student in _listStudents)
            {
                Console.WriteLine($"STUDENT NAME: {student.Name} \t");
                Console.WriteLine("\t Subject Name");
                foreach(Subject subject in student.Subjects)
                {
                    Console.Write($"\t {subject.Name} \t");
                    Console.WriteLine($"Score: {subject.Score}");
                }
                Console.WriteLine($"---------Average Score: {AverageScoreOneStudentInAllSubject(student.Name)}-----------");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Average Score of class: \t {AverageScoreOfClass()}");
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public Subject[] Subjects { get; set; }
    }

    public class Subject
    {
        public string Name { get; set; }
        public decimal Score { get; set; }
    }



}
