namespace BitMagic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Bit_1_Operators.AndOperator(5, 3));
            Console.WriteLine(Bit_1_Operators.OrOperator(6, 7));
            Console.WriteLine(Bit_1_Operators.XorOperator(6, 7));
            Console.WriteLine(Bit_1_Operators.NotOperator(13));
            Console.WriteLine(Bit_1_Operators.LeftShiftOperator(13));
            Console.WriteLine(Bit_1_Operators.RightShiftOperator(13));
        }
    }
}