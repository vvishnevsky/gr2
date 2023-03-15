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


            //Write a C# method to compute the sum of all the elements of an array of integers
            Console.Write("enter some numbers: ");
            var inputString = Console.ReadLine();
            var sumArray = 0;
            var arr = new int[inputString.Length];

            for (var i = 0; i < inputString.Length; i++)
                arr[i] = int.Parse(inputString[i].ToString());

            foreach (var i in arr)
                sumArray += i;

            Console.WriteLine($"sum of entered numbers {inputString} is {sumArray}");

            //Write a C# method to get the larger value from array
            Console.Write("enter some numbers: ");
            inputString = Console.ReadLine();

            arr = new int[inputString.Length];

            for (var i = 0; i < inputString.Length; i++)
                arr[i] = int.Parse(inputString[i].ToString());

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