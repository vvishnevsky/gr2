namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= HW2 ===========\n");

            //print the sum of two numbers
            int a = 2353 + 6852;
            Console.WriteLine($"2353 + 6852 = {a}\n");

            //print the result of dividing two numbers
            //float b = 6852f / 2353;
            Console.WriteLine("6852 / 2353 = {0}\n", 6852f / 2353);

            //print the result of the specified operations
            var c = -1 + 4 * 6;
            Console.WriteLine("-1 + 4 * 6 = " + c + "\n");

            var d = (35 + 5) % 7;
            Console.WriteLine($"(35 + 5) % 7 = {d}\n");

            double e = 14 + -4 * 6d / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {e}\n");

            var f = 2 + 15f / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {f}\n");

            //swap two numbers
            Console.WriteLine("== swap two numbers ==\n");
            var firstNumber = 0;
            var secondNumber = 0;
            var thirdNumber = 0;

            Console.Write("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());

            firstNumber += secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber -= secondNumber;
            LetMeThink(7);
            Console.WriteLine("\n\nfirst number = {0}", firstNumber);
            Console.WriteLine("second number = {0}", secondNumber);

            //print the output of multiplication of three numbers which will be entered by the user
            Console.WriteLine("\n== print the output of multiplication of three numbers which will be entered by the user ==\n");
            Console.Write("Enter the first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            thirdNumber = int.Parse(Console.ReadLine());
            long result = firstNumber * secondNumber * thirdNumber;
            LetMeThink(5);
            Console.WriteLine("\n{0} * {1} * {2} = {3}", firstNumber, secondNumber, thirdNumber, result);

            Console.WriteLine("\n============ End HW2 =============");
        }

        static void LetMeThink(int time = 10)
        {
            Console.Write("\nlet me think .");
            for (; time > 0; time--)
            {
                Thread.Sleep(500);
                Console.Write('.');
            }
        }
    }
}