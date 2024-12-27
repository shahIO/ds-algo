//Intuation
//The factorial (n!) of a number is the product of all the integers from 1 to that number 
// => n! = 1*2*3*.....(n-1)*n
// => 5! = (5) * (5-1) * (5-2) * (5-3) * (5-4)
// => 5! = 5 * 4 * 3 * 2 * 1


using System.Numerics;

namespace Mathematics
{
    public class Math_3_FactorialNumber()
    {
        public static BigInteger CalculateFactorial(int input)
        {
            BigInteger result = 1;
            while (input > 0)
            {
                result = result * input;
                input--;
            }
            return result;
        }

        // public static int CalculateTrailingZeroes(int input)
        // {
        //     int totalTrailingZeroes = 0;
        //     bool counter = true;
        //     BigInteger factorial = 1;

        //     while (input > 0)
        //     {
        //         factorial = factorial * input;
        //         input--;
        //     }

        //     while(counter)
        //     {
        //         BigInteger lastDigit = factorial % 10;
        //         if (lastDigit != 0){
        //             counter = false;
        //         } else {
        //             totalTrailingZeroes++;
        //             factorial /= 10;
        //         }
        //     }
        //     return totalTrailingZeroes;
        // }

        public static int CalculateTrailingZeroes_Naive(int input)
        {
            int totalTrailingZeroes = 0;
            int fact = 1;
            while(input > 0){
                fact = fact * input;
                input--;
            }
            while (fact % 10 == 0){
                totalTrailingZeroes++;
                fact /= 10;
            }
            return totalTrailingZeroes;
        }
//The idea is to consider prime factors of a factorial n. A trailing zero is always produced by prime factors 2 and 5. Our task is done if we can count the number of 5s and 2s. Consider the following examples:

//n = 5: There is one 5 and 3 2s in prime factors of 5! (2 * 2 * 2 * 3 * 5). So a count of trailing 0s is 1.

//n = 11: There are two 5s and eight 2s in prime factors of 11! (2 8 * 34 * 52 * 7). So the count of trailing 0s is 2.
//=> We can easily observe that the number of 2s in prime factors is always more than or equal to the number of 5s. So if we count 5s in prime factors, we are done.

//Following is the summarized formula for counting trailing 0s:

//Trailing 0s in n! = Count of 5s in prime factors of n! = floor(n/5) + floor(n/25) + floor(n/125) + ....
        public static int CalculateTrailingZeroes_Optim(int input)
        {
            int totalTrailingZeroes = 0;
            for (int i = 5; i <= input; i = i * 5)
            {
                totalTrailingZeroes = totalTrailingZeroes + (input / i);
            }
            return totalTrailingZeroes;
        }
    }
}