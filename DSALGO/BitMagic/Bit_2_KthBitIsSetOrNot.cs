//Check if Kth bit is set or not
// E.g n = 8, k = 2
// Second bit of binary representation of 8 is set or not i.e. 1 or not
// Binary representation of 8 is 1000 and second bit is zero which is not set.
// False

// E.g n = 5, k = 3
// 5 = 101; and 3 bit is set
// True

//Naive
// TO check if a bit b is 1 or not, use & operator => 0 & 1 = 0; 1 & 1 = 1
// Now to check for n if kth bit is 1 or 0, use & oprator with number whose kth bit is 1 and reset is 0
// Eg. if k = 5, then perform '&' operation with number 1000 i.e. 8
// n = 18, k = 5 then (18 & 8)

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
    }
}