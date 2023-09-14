namespace mpt_lab_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int number1 = random.Next(1, 25);
            int number2 = random.Next(1, 25);

            int sum = Sum(number1, number2);
            int square = Square(sum);
        
            Console.WriteLine("\nThe square of the sum of {0} and {1} is {2}", number1, number2, square);
        }
        
        /// <summary>
        /// Method to calculate the square of a number.
        /// </summary>
        /// <param name="number">Input number.</param>
        /// <returns>The square of the input number.</returns>
        static int Square(int number)
        {
            return number * number;
        }
        
        /// <summary>
        /// Method to calculate the sum of two numbers.
        /// </summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The sum of the two input numbers.</returns>
        static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}