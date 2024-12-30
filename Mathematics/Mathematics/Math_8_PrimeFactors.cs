// Prime Factors
// Prime factors of a number are the prime numbers that divide the number exactly without leaving a remainder.

// Intuition
// 1) Basic Method
// Loop from 2 to sqrt(input). For each number, while it divides the input, print the number and divide the input by this number.
// Time Complexity: O(sqrt(n))

// Idea
// - If the input is less than or equal to 1, there are no prime factors.
// - Loop from 2 to sqrt(input).
// - For each number in the loop, check if it divides the input. If it does, print the number and divide the input by this number.
// - Continue this until the input becomes 1.
// - If the remaining input is greater than 1, it is also a prime factor.


// 2) Optimized Method
// First, handle the smallest prime factors (2 and 3). Then, loop from 5 to sqrt(input) with    increments of 6. This skips all multiples of 2 and 3.
// Time Complexity: O(sqrt(n))

 // 2) Optimized Method // - If the input is less than or equal to 1, there are no prime factors.
 // - First, divide the input by 2 until it is no longer divisible by 2.
 // - Then, divide the input by 3 until it is no longer divisible by 3.
 // - Loop from 5 to sqrt(input) with increments of 6.
 // - For each number in the loop, check if it divides the input. If it does, print the number and divide the input by this number.
 // - Continue this until the input becomes 1.
// Time Complexity: O(sqrt(n))

namespace Mathematics
{
    public class Math_8_PrimeFactors()
    {
        public static void PrimeFactors(int input)
        {
            if (input <= 1) return;
            for(int i = 2; i <= Math.Sqrt(input); i++)
            {
                while(input % i == 0)
                {
                    Console.Write(i + " ");
                    input = input / i;
                }
            }
            if (input > 1){
               Console.Write(input + " "); 
            }
        }

        public static void PrimeFactors_Optimize(int input)
        {
            if (input <= 1) return;

            while(input % 2 == 0)
            {
                Console.Write(2 + " ");
                input = input / 2;
            }

            while(input % 3 == 0)
            {
                Console.Write(3 + " ");
                input = input / 3;
            }

            for(int i = 5; i <= Math.Sqrt(input); i = i + 6)
            {
                while(input % i == 0)
                {
                    Console.Write(i + " ");
                    input = input / i;
                }
                while(input % (i + 2) == 0)
                {
                    Console.Write(i + " ");
                    input = input / i + 2;
                }
            }
            if (input > 3){
               Console.Write(input + " "); 
            }

        }
    }
}