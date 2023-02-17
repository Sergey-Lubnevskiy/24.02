using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
     delegate void MyDelegate(int[] arr);
     delegate void MyDelegateTime();
    class Class1
    {
        public static void Even(int[] arr)
        {
            if(arr[i]/2==0)
            {
                Console.Write(arr[i]+" ");
            }
        }
        public static void Odd(int[] arr)
        {
            if (arr[i] / 2 != 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Time()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date.TimeOfDay);
        }
        public static void Date()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date.Day);
        }
        public static void Week()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date.DayOfWeek);
        }
        static void Main(string[] args)
        {
            MyDelegate dg = new MyDelegate(Even);
            MyDelegateTime dg1 = new MyDelegateTime(Time);
            dg += Odd;
            dg1 += Date;
            dg1 += Week;
            int[] arr = new int[10];
            Random r = new Random();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = r.Next(1, 100);
            }
            dg(arr);
            foreach (MyDelegate item in dg.GetInvocationList())
            {
                Console.WriteLine("{0}", item.Method.Name);
            }
            dg -= Even;
            dg -= Odd;
            Console.WriteLine();
            dg(arr);
            foreach (MyDelegate item in dg.GetInvocationList())
            {
                Console.WriteLine("{0}", item.Method.Name);
            }
            dg = Odd;
            Console.WriteLine();
            dg(arr);
            foreach (MyDelegate item in dg.GetInvocationList())
            {
                Console.WriteLine("{0}", item.Method.Name);
            }
        }
    }
}
