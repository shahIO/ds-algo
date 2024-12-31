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
