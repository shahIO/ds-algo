// Prime Number
// 'n' is a prime number if n > 1 and n has only two divisors: 1 and itself

// Intuition

// 1) Naive Method
// Loop from 2 to n - 1. If n is divisible by any number in this range, return false, it's not prime.
// If it's not divisible by any number, then n is prime.
// Time Complexity: O(n)


// 2) Optimized Method
// Instead of running the loop from 2 to n - 1, we can reduce it to run from 2 to sqrt(n).

// Idea
// The divisor of a number is always in pairs. e.g. for 30 -> (1, 30), (2, 15), (3, 10), (5, 6)
// Formula: If (x, y) is a pair of divisors of n, then x * y = n
// If x <= y, then x * x <= n, which means x <= sqrt(n)
// So, we only need to check numbers from 2 to sqrt(n). Even if there is a divisor greater than sqrt(n),
// its pair will be less than sqrt(n), and we would have already checked it.
// Time Complexity: O(sqrt(n))


// 3) More Optimized Method
// We can further optimize the previous method. Instead of checking from 2 to sqrt(n) one step at a time, we check from 5 to sqrt(n) with increments of 6.

// Idea
// If n is a large number e.g. n = 1031, we check from 2 to sqrt(1031), i.e. 2 - 32
// We know that if a number is not divisible by 2, it will not be divisible by 4, 6, 8, etc. (multiples of 2).
// Similarly, if it is not divisible by 3, it will not be divisible by its multiples either.
// Hence, we skip the checks for all multiples of 2 and 3 if n is not divisible by either 2 or 3.


namespace Mathematics
{
    public class Math_7_CheckPrime()
    {
        public static bool IsPrime_Naive(int n)
        {
            if (n <= 1) return false;
            
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrime_Optimized(int n)
        {
            if (n <= 1) return false;

            for( int i = 2; i * i <= n; i++)
            {
                if( n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrime_MoreOptimized(int n)
        {
            if (n <= 1) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for( int i = 5; i * i <= n; i = i + 6)
            {
                if( n % i == 0 || n % i + 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
