//Intuition
// 1) Understanding Place Value: Each digit represents a different place value. For instance, in 12345, '5' is in the units place, '4' is in the tens place, and so on.
// 2) Removing Digits via Division: When we divide the number by 10, we effectively "move" one place value to the right, thereby reducing the number of digits by one. For example, dividing 12345 by 10 gives 1234.5, and converting it to an integer results in 1234.
// 3) Counting the Divisions: By repeatedly dividing the number by 10 until it becomes 0, we count the number of divisions required. Each division corresponds to the removal of one digit from the original number. Therefore, the total number of divisions (or iterations) is equal to the number of digits in the original number.

//Handle Negative Numbers:
// Number of digits remains the same regardless of the sign.
// Using the abs function

namespace Mathematics
{
    public class Math_1_CountDigits
    {
        public static int CountDigits(int x)
        {
            int count = 0;
            x = Math.Abs(x);

            while (x > 0)
            {
                x /= 10;
                count++;
            }
            return count;
        }

        public static int CountDigitsUsingString(int x)
        {
            x = Math.Abs(x);
            string str = x.ToString();
            return str.Length;
        }

    }
}
