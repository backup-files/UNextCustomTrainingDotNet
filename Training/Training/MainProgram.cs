using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using static Basics.Print;
using static Print.Print;

namespace Basics
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("----- Hello World Program -----");
            //HelloWorld.Run();
            //Console.WriteLine("----- Static Calculator Program -----");
            //StaticCalculator.Run();
            //Car c1 = new Car();
            //Car c2 = new Car("blue");
            //Console.Write("Enter a color: ");
            //string color = Console.ReadLine();
            //Car c3 = new Car(color);
            //Console.WriteLine($"{c1.Color}, {c2.Color}, {c3.Color}");
            //Car c4 = new Car("green", 2017);
            //Console.WriteLine($"c4 = {c4.Color}, {c4.Year}");
            //c4.CheckAge();
            //c4.PrintFuelType("diesel");
            //Child child = new Child();
            //child.PrintInheritedProperties();
            //Parent child1 = new Child();
            //child1.PrintNothing();
            //Vehicle bike = new Bike();
            //bike.Brake();
            //IVehicle truck = new Truck();
            //Console.WriteLine($"Truck color = {truck.Color}");
            //truck.Brake();
            //truck.Drive();
            //truck.Honk();
            //IVehicle jeep = new Jeep();
            //Console.WriteLine($"Jeep color = {jeep.Color}");
            //jeep.Brake();
            //jeep.Drive();
            //jeep.Honk();
            //((IVehicle)new Truck()).Honk();
            //((ICrane)new Truck()).Honk();
            //Console.WriteLine($"{Month.jan}, {Month.mar}, {(int) Month.dec}");
            //try
            //{
            //    int[] arr = { 1, 2, 3 };
            //    Console.WriteLine(arr[10]);
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine($"{e.Message} - {e.StackTrace}");
            //    Console.WriteLine(e.Source);
            //    Console.WriteLine(e.InnerException);
            //} 
            //finally
            //{
            //    Console.WriteLine("try catch block");
            //}
            //var arr = new int[5];
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            // Linq = Language Integrated Queries
            //int[] nums = new int[5]{ 10, 15, 16, 8, 6 };
            //print(nums);
            //Array.ForEach(nums, n => Console.WriteLine(n));
            //Array.Sort(nums);
            //Console.WriteLine(Array.BinarySearch(nums, 6));
            //var arList = new ArrayList {1, true, 3, "four", 5.0};
            //foreach(var i in arList)
            //{
            //    Console.WriteLine(i);
            //}
            //arList.Insert(1, false);
            //Console.WriteLine();
            //foreach (var i in arList)
            //{
            //    Console.WriteLine(i);
            //}
            //var ar1 = new ArrayList { 1, 2, 3 };
            //arList.InsertRange(2, ar1);
            //Console.WriteLine();
            //Array.ForEach(arList.ToArray(), n => Console.WriteLine(n));
            //arList.Remove(1.7);
            //try
            //{
            //    arList.RemoveAt(10);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}
            //try
            //{
            //    arList.RemoveRange(0, 10);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //}
            //Console.WriteLine();
            //Array.ForEach(arList.ToArray(), n => Console.WriteLine(n));
            //Console.WriteLine(nums.Max());
            //Console.WriteLine(nums.Min());
            //Console.WriteLine(nums.Sum());
            //Console.WriteLine(nums.Average());
            //ExtensionClass e = new ExtensionClass();
            //e.M1();
            //e.M2();
            //var list = new List<int>();
            //list.Add(2);
            //list.Add(3);
            //list.Add(5);
            //list.Add(7);
            //list.ForEach(n => Console.WriteLine(n));
            // list.Add("11"); - shows compile time error
            //var cars = new List<Car>()
            //{
            //    new Car("red"),
            //    new Car("black", 2020),
            //    new Car(),
            //    new Car("blue", 2021),
            //    new Car("red", 2016),
            //};
            //var result = from c in cars where c.Color.Equals("red") select c;
            //foreach (var car in result)
            //{
            //    Console.WriteLine($"{car.Color} - {car.Year}");
            //}
            //result.ToList().ForEach(car => {
            //    Print.print(car.Color, car.Year);
            //});
            //foreach (var car in (from c in cars where c.Year.Equals(2000) select c))
            //{
            //    print(car.Color, car.Year);
            //}
            //(from c in cars where c.Year > 2014 orderby c.Year select c).ToList().ForEach(car =>
            //{
            //    print(car.Color, car.Year);
            //});
            //Console.WriteLine();
            //var s = new SortedList<int, string>();
            //s.Add(1, "A");
            //s.Add(2, "B");
            //s.Add(3, "C");
            //s.ToList().ForEach(x => print(x));

            //var dict = new Dictionary<int, Car>();
            //dict.Add(1, new Car("blue"));
            //dict.Add(2, new Car());
            //dict.Add(3, new Car("black", 2017));

            //dict
            //    .Where(x => x.Value.Year == 2000)
            //    .ToList()
            //    .ForEach(x => print(x.Value.Color, x.Value.Year));
            //print(dict.Keys, "");
            //var ht = new Hashtable();
            //ht[1] = "hello";
            //ht[1] = "pokemon";
            //print(ht[1]);
            //Student s = new Student();
            //s.AddStudent("tejas");
            //print(s.GetStudents());
            //s.AddStudent("vishesh");
            //s.AddStudent("thrivikrama");
            //print(s.GetStudents(), s.RemoveStudent(), s.GetStudents(), s.GetStudent());
            //var queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //print(queue);
            //queue.Dequeue();
            //print(queue);
            //print(queue.Peek());
            //print(new List<int>() { 1, 2, 3, 4, 5 }.FirstOrDefault((n) => n == 6));

            int n = Convert.ToInt32(Console.ReadKey());
            int[] v = new int[n];
            for (int i = 0; i < n; ++i)
            {
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();
            int start = 1, end = n;
            for (var i = 0; i < n; ++i)
            {
                if (v[i] == start)
                {
                    start++;
                }
                else if (v[i] == end)
                {
                    end--;
                }
                else
                {
                    Console.WriteLine("no");
                    break;
                }
            }
            if (start == end)
                Console.WriteLine("yes");
        }
    }
}
