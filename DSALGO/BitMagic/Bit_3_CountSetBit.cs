// Count the number of set bits (1s) in the binary representation of a number
// For example:
// n = 8
// Binary representation of 8 is 1000 and has one set bit (1) => 1
// n = 5
// Binary representation of 5 is 101 and has two set bits (1s) => 2

// Naive approach
// To count the number of set bits, check each bit one by one
// Use the '&' operator to check if the least significant bit (LSB) is set (1)
// (n & 1) will be 1 if the LSB is set, otherwise 0
// Right shift 'n' to check the next bit in the next iteration
// Time complexity = O(number of bits in n)

//Optitmize
// Instead of checking each bit individually by left shifting,
// Brian Kernighan's Algorithm states to count the number of set bits (1s).
// The algorithm uses the expression 'n & (n - 1)' to turn off the rightmost set bit.

// For example, if n = 40 (101000 in binary):
// n - 1 = 39 (100111 in binary)
// => 101000 & 100111 = 100000 (32 in decimal)
// Repeatedly applying this will turn off each set bit, one by one, and the count of iterations gives the number of set bits.


namespace DS_2_BitMagic
{
    public class Bit_3_CountSetBit
    {
        public static int CountSetBit_Naive(int n)
        {
            int count = 0;

            while( n != 0)
            {
                if((n & 1) != 0)
                {
                    count++;
                }
                n = n >> 1;
            }
            return count;
        }

        public static int CountSetBit_Optimize(int n)
        {
            //Brain Kerningam's Algorithm
            int count = 0;
            
            while(n != 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;
        }
    }
}