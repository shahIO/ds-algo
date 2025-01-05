//Check if Kth bit is set or not
// E.g n = 8, k = 2
// Second bit of binary representation of 8 is set or not i.e. 1 or not
// Binary representation of 8 is 1000 and second bit is zero which is not set.
// False

// E.g n = 5, k = 3
// 5 = 101; and 3 bit is set
// True

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