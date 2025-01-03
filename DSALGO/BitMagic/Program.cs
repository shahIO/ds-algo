namespace BitMagic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Bit_Operators.AndOperator(5, 3));
            Console.WriteLine(Bit_Operators.OrOperator(6, 7));
            Console.WriteLine(Bit_Operators.XorOperator(6, 7));
            Console.WriteLine(Bit_Operators.NotOperator(13));
            Console.WriteLine(Bit_Operators.LeftShiftOperator(13));
            Console.WriteLine(Bit_Operators.RightShiftOperator(13));
        }
    }
}