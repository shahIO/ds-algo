// Intuition
//============
//=> The main idea is to reverse the given number and then compare it with the original number.
//=> If the reversed number is the same as the original number, then the number is a palindrome.
//============
//=> Reversal of the Number: Reverse the given number by extracting its last digit and appending it to a new number.
//=> Isolating the Last Digit: In each iteration, calculate x % 10 to get the last digit of x. This digit is added to the reversed number after shifting the current digits of reversed one place to the left (multiplying by 10).
//=> Removing the Last Digit: Remove the last digit from the number by doing integer division by 10 (x = x / 10).
//=> Comparison: After reversing, compare the reversed number with the original number. If they are the same, the number is a palindrome. Otherwise, it is not.
//============

namespace Mathematics
{
    public class Math_2_PalindromeNumbers
    {
        public static bool IsPalindrome(int input)
        {
            int reversed = 0;
            int number = input;
            while (input > 0)
            {
                int lastDigit = input % 10;
                reversed = reversed * 10 + lastDigit;
                input /= 10;
            }
            return number == reversed;
        }

        public static bool IsPalindrome(string input)
        {
            char[] reversed = new char[input.Length];
            for(int i = 0; i < input.Length ; i++)
            {
                reversed[i] = input[input.Length - 1 - i];
            }
            string reversedString = new (reversed);
            
            return input == reversedString;
        }
    }
}