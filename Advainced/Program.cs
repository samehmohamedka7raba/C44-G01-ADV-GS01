using Advainced.Example1;
using System.Collections;

namespace Advainced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region v1
            //int a = 10, b = 20;
            //Console.WriteLine($"a : {a}");
            //Console.WriteLine($"b : {b}");
            //Console.WriteLine($"After swap");
            //Helper.SWAP(ref a, ref b);
            //Console.WriteLine($"a : {a}");
            //Console.WriteLine($"b : {b}");

            //decimal x = 10.5m, y = 20.5m;
            //Console.WriteLine($"x : {x}");
            //Console.WriteLine($"y : {y}");
            //Console.WriteLine($"After swap");
            //Helper.SWAP(ref x, ref y);
            //Console.WriteLine($"x : {x}");
            //Console.WriteLine($"x : {y}");


            //Point p1 = new Point(1, 2);
            //Point p2 = new Point(3, 4);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine($"After swap");
            //Helper.SWAP(ref p1, ref p2);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion


            #region Example-2 

            //int[] arr = {1, 2, 3, 4, 5};
            //int result = Helper<int>.linearSearch(arr, 3);
            //Console.WriteLine($"index of target value = {result}");

            //Employy employy01 = new Employy(1,1000,"sameh");
            //Employy employy02 = new Employy(1,1000,"sameh");
            //Console.WriteLine(employy01.GetHashCode());
            //Console.WriteLine(employy02.GetHashCode());
            //if (employy01 == employy02)
            //    Console.WriteLine($"Equal");
            //else
            //    Console.WriteLine($"Not equal");
            #endregion


            #region example-3 Equality and GetHashCode
            //Employy employy01 = new Employy(1,1000, "sameh");
            //Employy employy02 = new Employy(1, 1000, "sameh");
            //Console.WriteLine(employy01.GetHashCode());
            //Console.WriteLine(employy02.GetHashCode());

            //var table = new Hashtable();
            //table[employy01] = "Dev;";
            //Console.WriteLine(table[employy02] );

            String name01 = "sameh";
            string name02 = "sameh";
            Console.WriteLine(name01.GetHashCode());
            Console.WriteLine(name02.GetHashCode());




            #endregion

        }
    }
}
