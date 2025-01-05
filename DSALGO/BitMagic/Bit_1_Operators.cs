namespace DS_2_BitMagic
{
    public class Bit_1_Operators
    {
        //If both bits are 1, result is 1. Otherwise, result bit is set to 0.
        public static int AndOperator(int a, int b)
        {
            return a & b;
        }

        // If either bit is 1, result is 1. Otherwise, result is set to 0.
        public static int OrOperator(int a, int b)
        {
            return a | b;
        }

        //If both bits are different, result is 1. If both bits are same, result is 0
        public static int XorOperator(int a, int b)
        {
            return a ^ b;
        }

        //The NOT operator inverts all the bits of its operand.
        // Steps 1 Invert all bits including sign bit
        // Step 2: Take 2's compliment of it considering sign bit
        // E.g. x = 13, ~x ?
        // Step 1: 0|1101 => 1|0010 (Inverted all the bits including sign bit)
        // Step 2: 0010 => 1101 (1's comp)
        //      => 1101 + 1 => 1110 (2's comp)
        //      => 1|1110
        // ~x = -14;
        public static int NotOperator(int a)
        {
            return ~a;
        }

        //Shifts the bits of its first operand to the left by the number of positions specified by its second operand. i.e. 13 << 1 => 1101 << 1 => 11010 => 36
        public static int LeftShiftOperator(int a)
        {
            return a << 1;
        }

        //Shifts the bits of its first operand to the left by the number of positions specified by its second operand. i.e. 13 >> 1 => 1101 >> 1 => 110 => 6
        public static int RightShiftOperator(int a)
        {
            return a >> 1;
        }

    }
}
