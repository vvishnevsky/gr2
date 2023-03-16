namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hw4\n");

            //Write a C# method to find the largest value from three integer values.
            Console.Write("enter first value: ");
            var firstInt = int.Parse(Console.ReadLine());
            Console.Write("enter second value: ");
            var secondInt = int.Parse(Console.ReadLine());
            Console.Write("enter third value: ");
            var thirdInt = int.Parse(Console.ReadLine());
            var largest = GetLargestOfThree(firstInt, secondInt, thirdInt);
            Console.WriteLine($"the largest is {largest}\n");

            //Write a C# method to find the lowest value from three integer values.
            Console.Write("enter first value: ");
            firstInt = int.Parse(Console.ReadLine());
            Console.Write("enter second value: ");
            secondInt = int.Parse(Console.ReadLine());
            Console.Write("enter third value: ");
            thirdInt = int.Parse(Console.ReadLine());
            var lowest = GetLowestOfThree(firstInt, secondInt, thirdInt);
            Console.WriteLine($"the largest is {lowest}\n");

            //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same
            Console.Write("enter first number: ");
            firstInt = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            secondInt = int.Parse(Console.ReadLine());

            if (firstInt == secondInt)
                Console.WriteLine("0");
            else
            {
                if (int.Abs(20 - firstInt) < int.Abs(20 - secondInt))
                    Console.WriteLine(firstInt);
                else if (int.Abs(20 - firstInt) > int.Abs(20 - secondInt))
                    Console.WriteLine(secondInt);
                else
                    Console.WriteLine("both numbers are close to 20");
            }

            //Write a C# method to compute the sum of all the elements of an array of integers
            Console.Write("\nenter some numbers by space, e.g. 34 46 23: ");
            var inputString = Console.ReadLine();
            var arrString = inputString.Split(" ");
            var sumArray = 0;
            var arr = new int[arrString.Length];

            for (var i = 0; i < arrString.Length; i++)
                arr[i] = int.Parse(arrString[i]);

            foreach (var i in arr)
                sumArray += i;

            Console.WriteLine($"sum of entered numbers: {sumArray}\n");

            //Write a C# method to get the larger value from array
            Console.Write("\nenter some numbers by space, e.g. 34 46 23: ");
            inputString = Console.ReadLine();
            arrString = inputString.Split(" ");
            arr = new int[arrString.Length];
            var max = 0;

            for (var i = 0; i < arrString.Length; i++)
                arr[i] = int.Parse(arrString[i]);

            foreach (var i in arr)
            {
                if (i > max)
                    max = i;
            }

            Console.WriteLine($"array max value is {max}");
        }

        static int GetLargestOfThree(int a, int b, int c)
        {
            var largest = 0;
            if ((a > b) && (a > c))
                largest = a;
            else if ((b > c) && (b > a))
                largest = b;
            else if ((c > a) && (c > b))
                largest = c;

            return largest;
        }

        static int GetLowestOfThree(int a, int b, int c)
        {
            var lowest = 0;
            if ((a < b) && (a < c))
                lowest = a;
            else if ((b < c) && (b < a))
                lowest = b;
            else if ((c < a) && (c < b))
                lowest = c;
            return lowest;
        }
    }
}