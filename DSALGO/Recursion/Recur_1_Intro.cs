namespace Recursion
{
    public class Recur_1_Intro
    {
        //Execution of methods
        public static void fun1()
        {
            Console.WriteLine("Fun");
        }

        public static void fun2()
        {
            Console.WriteLine("Before Fun1!");
            fun1();
            Console.WriteLine("After Fun1!");
        }

        //Infinite recursion
        public static void foo()
        {
            // Since no base case hence infinite loop
            Console.WriteLine("Hello Shah");
            foo();
        }

        //Finite recursion
        public static void bar(int n)
        {
            //Base case
           if (n == 0)
            {
                return;
            }

            Console.WriteLine("Shah");
            bar(n - 1);
        }

        // Practise
        public static void func1(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            func1(n - 1);
            Console.WriteLine(n);
        }

        public static void func2(int n)
        {
            if (n == 0)
            {
                return;
            }
            func2(n - 1);
            Console.WriteLine(n);
            func2(n - 1);
        }
    }
}
