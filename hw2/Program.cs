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
            float b = 6852f / 2353;
            Console.WriteLine("6852 / 2353 = {0}\n", b);

            //print the result of the specified operations
            var c = -1 + 4 * 6;
            Console.WriteLine("-1 + 4 * 6 = " + c + "\n");

            var d = (35 + 5) % 7;
            Console.WriteLine($"(35 + 5) % 7 = {d}\n");

            double e = 14 + -4 * 6d / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {e}\n");

            var f = 2 + 15f / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {f}\n");


        }
    }
}