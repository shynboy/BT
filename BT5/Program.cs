using BT1;
using BT3;
using BT4;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st1 = new Stopwatch();
            Stopwatch st2 = new Stopwatch();
            Stopwatch st3 = new Stopwatch();
            Console.WriteLine("-------ARRAY------\n");
            BT1.MyClass myArrayClass = new BT1.MyClass(BT1.Data.students);
            st1.Start();
            myArrayClass.Display();
            st1.Stop();
            Console.WriteLine();
            Console.WriteLine("-------LIST------\n");
            BT3.MyClass MyListClass = new BT3.MyClass(BT3.Data.students);
            st2.Start();
            myArrayClass.Display();
            st2.Stop();
            Console.WriteLine();
            Console.WriteLine("-------ARRAYLIST------\n");
            BT4.MyClass myArrayListClass = new BT4.MyClass(BT4.Data.students);
            st3.Start();
            myArrayListClass.Display();
            st3.Stop();
            Console.WriteLine();
            Console.WriteLine("-------RESULT------\n");
            //Console.WriteLine($"Array time compile {st1.Elapsed}");
            //Console.WriteLine($"List time compile {st2.Elapsed}");
            //Console.WriteLine($"ArrayList time compile {st3.Elapsed}");
            List<dynamic> list = new List<dynamic>() { st1.Elapsed,st2.Elapsed,st3.Elapsed };
            list.Sort();
            Console.WriteLine("Fast=>Slow");
            foreach(var item in list)
            {
                if(item == st1.Elapsed)
                    Console.WriteLine($"Array Time Compile: \t {st1.Elapsed}");
                else if(item == st2.Elapsed)
                    Console.WriteLine($"List Time Compile: \t {st2.Elapsed}");
                else Console.WriteLine($"ArrayList Time Compile: \t {st3.Elapsed}");
            }

            Console.ReadLine();

        }
    }
}
