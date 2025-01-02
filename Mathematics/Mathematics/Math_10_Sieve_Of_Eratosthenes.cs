// Intuation

// Starts with a count variable set to 0.
// Checks if the input is less than 2, returns 0 if true.
// Creates a boolean array IsPrime with the size equal to the input.
// Set all Elements to True:
// Loops through the IsPrime array starting from 2, setting each element to true.

// Sieve Process:
// Loops from 2 to the square root of the input value.
// For each prime number i, marks all multiples of i starting from i * i as non-prime.

// Counting Primes:
// After the sieve process, loops through the IsPrime array.
// Increments count for each index still marked as prime.
// Return Result

namespace Mathematics
{
    public class Math_10_Sieve_Of_Eratosthenes()
    {
        public static int AllPrimes(int input)
        {
            int count = 0; 

            if (input < 2) { return 0; }
            bool[] IsPrime = new bool[input]; 

            //Set all element true
            for (int i = 2; i < input; i++) { 
                IsPrime[i] = true; 
            } 

            for (int i = 2; i * i < input; i++) { 
                if (IsPrime[i]) {  
                    for (int j = i * i; j < input; j += i) { 
                        IsPrime[j] = false; 
                    } 
                } 
            } 

            //count
            for (int i = 2; i < input; i++) { 
                if (IsPrime[i]) { 
                    count++;
                } 
            } 
            return count;
        }
    }
}
