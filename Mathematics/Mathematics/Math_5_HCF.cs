//1) Naive Approach

// The basic idea is to find the minimum of the two numbers and then, traverse from the min number to 1, to find the highest factor which is also a factor of the other number.

// Time Complexity: O(min(a,b)) 
// Auxiliary Space: O(1)


// 2) Euclidean Approach:

// Calculates the HCF of two numbers by repeatedly subtracting the smaller number from the larger one until they are equal.

// Time Complexity: O(min(a,b))
// Auxiliary Space: O(1)

// 3) Optimized Euclidean Approach:

// Calculates the HCF of two numbers using the modulo operation. Instead of subtracting the smaller number from the larger one repeatedly, it replaces the larger number with its remainder when divided by the smaller number. This significantly reduces the problem size in each iteration.

// Time Complexity: O(log(min(a,b)))
// Auxiliary Space: O(1)



namespace Mathematics
{
    public class Math_5_HCF()
    {
        public static int CalculateHCF_Naive(int input1, int input2)
        {
            int result = 1;
            if (input1 == input2) return input1;

            int min = Math.Min(input1, input2);
            while(min > 0){
                if (input1 % min == 0 && input2 % min ==0 ){
                    return min;
                }
                min--;
            }
            return result;
        }
        public static int CalculateHCF_EuclideanAlgo(int input1, int input2)
        {
            while( input1 != input2)
            {
                if (input1 > input2){
                    input1 = input1 - input2;
                }else {
                    input2 = input2 - input1;
                }
            }
            return input1;
        }
        public static int CalculateHCF_EuclideanAlgoOptimized(int input1, int input2)
        {
            while(input2 == 0){
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }
    }
}