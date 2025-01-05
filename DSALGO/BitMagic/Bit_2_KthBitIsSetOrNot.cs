// Check if the k-th bit is set or not in the binary representation of a number
// For example:
// n = 8, k = 2
// Binary representation of 8 is 1000 and the 2nd bit is 0 (not set) => False
// n = 5, k = 3
// Binary representation of 5 is 101 and the 3rd bit is 1 (set) => True

// Naive approach
// To check if a bit is 1 or 0, use the '&' operator
// 0 & 1 = 0; 1 & 1 = 1
// To check if the k-th bit in 'n' is 1 or 0, use the '&' operator with a number where only the k-th bit is 1
// Example: if k = 3, use the number 100 (which is 4 in decimal)
// n = 18, k = 3, (18 & 4)
// Time complexity = O(k)

// Optimized approach 
// Instead of looping k-1 times to create a number with only the k-th bit set to 1, 
// use the left shift operator: 1 << (k - 1) 
// Example: 1 << 2 == 4, 1 << 3 == 8, 1 << 4 == 16 
// Then use the '&' operator

namespace DS_2_BitMagic
{
    public class Bit_2_KthBitIsSetOrNot()
    {
        public static bool IsKthBitIsSet_Naive(int n, int k)
        {
            int x = 1; ;
            for(int i = 1; i<= k-1; i++)
            {
                x = x * 2;
            }

            if ((n & x) == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static bool IsKthBitIsSet_Optimize(int n, int k)
        {
            int x = 1 << k - 1;
            if ((n & x) == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}