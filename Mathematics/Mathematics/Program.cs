﻿namespace Mathematics
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Math_1_CountDigits.CountDigits(256));
            // Console.WriteLine(Math_1_CountDigits.CountDigitsUsingString(25632));

            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(121));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("78987"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(-121));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("21"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(10));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("8"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(837));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("837"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(8668));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("A man, a plan, a canal: Panama"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome("race a car"));
            // Console.WriteLine(Math_2_Palindrome.IsPalindrome(" "));

            // Console.WriteLine(Math_3_FactorialNumber.CalculateFactorial(1));
            // Console.WriteLine(Math_3_FactorialNumber.CalculateFactorial(5));
            // Console.WriteLine(Math_3_FactorialNumber.CalculateFactorial(0));
            // Console.WriteLine(Math_3_FactorialNumber.CalculateFactorial(100));
            // Console.WriteLine(Math_3_FactorialNumber.CalculateTrailingZeroes_Naive(5));
            // Console.WriteLine(Math_4_TrailingZerosInFactorial.CalculateTrailingZeroes_Naive(115));
            // Console.WriteLine(Math_4_TrailingZerosInFactorial.CalculateTrailingZeroes_Optimum(115));

            // Console.WriteLine(Math_5_HCF.CalculateHCF_Naive(100, 200));
            // Console.WriteLine(Math_5_HCF.CalculateHCF_EuclideanAlgo(12,98));
            // Console.WriteLine(Math_5_HCF.CalculateHCF_EuclideanAlgoOptimized(24, 98));

            // Console.WriteLine(Math_6_LCM.CalcLCM_Naive(15, 20));
            // Console.WriteLine(Math_6_LCM.CalcLCM_Optimized(15, 20));

            // for(int i = 0; i <= 100; i++)
            // {
            //     if(Math_7_Prime.IsPrime_Naive(i)) {
            //         Console.WriteLine($"{i}");   
            //     }
            // }

            // for(int i = 0; i <= 100; i++)
            // {
            //     if(Math_7_Prime.IsPrime_Optimized(i)) {
            //         Console.WriteLine($"{i}");   
            //     }
            // }

            Console.WriteLine(Math_7_Prime.IsPrime_MoreOptimized(4));
        }   
    }
}
