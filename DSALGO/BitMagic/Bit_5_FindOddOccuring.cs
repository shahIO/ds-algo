using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_2_BitMagic
{
    public class Bit_5_FindOddOccuring
    {
        public static int FindOddOccurring_Naive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                // Count the occurrences of arr[i]
                for (int j = 0; j < arr.Length; j++) 
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                // Check if the count is odd
                if (count % 2 != 0)
                {
                    return arr[i];
                }
            }
            //Return - 1 if no odd occurrence is found (should not happen if the problem guarantees one odd occurring number)
            return -1;
        }
    }
}
