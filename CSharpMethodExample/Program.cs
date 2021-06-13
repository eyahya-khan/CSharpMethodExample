using System;

namespace CSharpMethodExample
{
    class Program
    {
        //create method and call multiple method
        /*static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }*/

        //method with parameter
        /*static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }
        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }*/

        //method with default parameter
        /*static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }
        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("Bangladesh");
            MyMethod();
            MyMethod("USA");
        }*/

        //multiple parameter
        /*static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }
        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }*/

        //return value
        /*static int MyMethod(int x)
        {
            return 5 + x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }*/

        //return sum of multiple parameter
        /*static int MyMethod(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }*/

        //return different type value
        /*static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }*/

    }
}
