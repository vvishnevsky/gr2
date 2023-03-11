namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //Write a C# program to check two given integers and return true if one is negative and one is positive.

            Console.Write("Input first integer: ");
            var firstValue = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            var secondValue = int.Parse(Console.ReadLine());

            if ((firstValue < 0 && secondValue >= 0) || (firstValue >= 0 && secondValue < 0))
            //or
            //if ((int.IsNegative(firstValue) && int.IsPositive(secondValue)) || (int.IsPositive(firstValue) && int.IsNegative(secondValue)))
                Console.WriteLine("\nTrue");
            else
                Console.WriteLine("\nFalse");

            Console.WriteLine("\n==================================================================================\n");

            //
            //Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.

            Console.Write("enter the first number: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("enter the second number: ");
            var b = int.Parse(Console.ReadLine());

            if (a == 20 || b == 20 || (a + b == 20))
                Console.WriteLine("\ntrue");
            else
                Console.WriteLine("\nfalse");

            Console.WriteLine("\n==================================================================================\n");

            //
            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

            Console.Write("Odd numbers from 1 to 99: ");
            for (var odd = 1; odd <= 99; odd += 2)
                Console.Write(odd + " ");

            //or

            //for (var i = 1; i <=99; i++)
            //{
            //    if (int.IsOddInteger(i))
            //        Console.Write(i + " ");
            //}

            Console.WriteLine("\n\n==================================================================================\n");

            //
            //Write a C# program to compute the sum of the first 500 prime numbers.

            var number = 2;
            var sum = 2;

            for (var i = 1; i < 500;)
            {
                number++;
                if (CheckPrimeNumber(number))
                {
                    sum += number;
                    i++;
                }
            }

            Console.WriteLine($"Sum of 500 prime numbers is: {sum}");

            Console.WriteLine("\n==================================================================================\n");

            //
            //Write a C# program and compute the sum of the digits of an integer.

            Console.Write("Enter a number: ");

            var number2 = Console.ReadLine();

            if (number2.Length > 1)
            {
                var sum2 = 0;

                for (var i = 0; i < number2.Length; i++)
                    sum2 += (int)char.GetNumericValue(number2[i]);

                Console.WriteLine($"sum of the digits: {sum2}");
            }
            else
                Console.WriteLine("try again");
        }

        public static bool CheckPrimeNumber(int number)
        {
            var limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}