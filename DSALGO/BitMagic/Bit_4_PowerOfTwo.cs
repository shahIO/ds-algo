//Naive
// Doubling n each time, and checks if it equals the input.
// If n matches the input during the iteration, it returns true.
// If the loop completes without finding a match, it returns false.

namespace DS_2_BitMagic
{
    public class Bit_4_PowerOfTwo
    {
        public static bool Check_Naive(int input)
        {
            int n = 1;
            while ( n <= input)
            {
                if (n == input)
                {
                    return true;
                }
                n = n * 2;
            }
            return false;
        }
    }
}
