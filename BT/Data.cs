using BT1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    public static class Data
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
    }
}
