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
            if (n & Math.Pow(2, k - 1) == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}