// Intuition

// 1) Naive Method
// Loop from 1 to n1. If n is divisible by any number in this range, print it.
// Time Complexity: O(n)

// 2) Optimized Not sorted
// Instead of running the loop from 1 to n, we can reduce it to run from 1 to sqrt(n).

// Idea
// The divisor of a number is always in pairs. e.g. for 30 -> (1, 30), (2, 15), (3, 10), (5, 6)
// Formula: If (x, y) is a pair of divisors of n, then x * y = n
// If x <= y, then x * x <= n, which means x <= sqrt(n)
// So, we only need to check numbers from 1 to sqrt(n). Even if there is a divisor greater than sqrt(n), its pair will be less than sqrt(n), and we would have already checked it.
// If number divisble then print it.

// Time Complexity: O(sqrt(n))


// 3) Using above solution will print all the divisors of n but not in sorted order. To print it in sorted order, we will first print x from (x,y) in pair i.e. number % x and then iterate back printing y i.e. number/x




namespace Mathematics{
    public class Math_9_AllDivisors()
    {
        public static void AllDivisors_Naive(int input)
        {
            for(int i = 1; i <= input; i++)
            {
                if( input % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void AllDivisors_Optimize_NotSorted(int input)
        {
            if (input == 0) return;
            for(int i = 1; i <= Math.Sqrt(input); i++)
            {
                if( input % i == 0)
                {
                    Console.Write(i + " ");
                    if ( i != input / i){
                        Console.Write(input / i + " ");
                    }
                }
            }
        }

        public static void AllDivisors_Optimize_Sorted(int input)
        {
            if (input == 0) return;
            int i;
            for(i = 1; i < Math.Sqrt(input); i++)
            {
                if(input % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            for(; i >= 1; i--)
            {
                if (input % i == 0){
                    Console.Write(input / i + " ");
                }
            }
        }
    }
}