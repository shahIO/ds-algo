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
    }
}