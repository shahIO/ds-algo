// LCM (Least Common Multiple)
// Example :-
//  15 = 3 * 5
//  20 = 2 * 2 * 5
//  (if factor common on both consider one)= 2 * 2 * 3 * 5 = 60

//Intuition

// 1) Naive Approach
// The basic approach is to find the maximum of both numbers, then iterate from that number, till we find a number that is completely divisible by both numbers.

// 2) Optimized
// An efficient solution is based on the below formula for LCM of two numbers ‘a’ and ‘b’. 

//   a x b = LCM(a, b) * GCD (a, b)
//=> LCM(a, b) = (a x b) / GCD(a, b)

namespace Mathematics
{
    public class Math_6_LCM()
    {

        public static int CalcLCM_Naive(int input1, int input2)
        {
            int result = Math.Max(input1, input2);
            
            while(true)
            {
                if(result % input1 == 0 && result % input2 == 0)
                {
                    return result;
                }
                result++;
            }
        }
        public static int CalcLCM_Optimized(int input1, int input2)
        {
            int gcd;
            int a = input1;
            int b = input2;

            while(input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            gcd = input1;

            return a * b / gcd;
        }
    }
}