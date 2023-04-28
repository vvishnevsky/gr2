namespace hw3
{
    internal class Program
    {
        delegate void printString(string msg, ConsoleColor consoleColor);

        delegate void DlgtWriteGreeColourText(string text);
        delegate void DlgtWriteOrangeColourText(string text);

        static void WriteColourText(string text, ConsoleColor consoleColor)
        {
            var a = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ForegroundColor = a;
        }

        static void WriteGreenColourText(string text)
        {
            var a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = a;
        }

        static void WriteOrangeColourText(string text)
        {
            var a = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = a;
        }

        static void Main(string[] args)
        {
            var d1 = new printString(WriteColourText);
            printString d2 = WriteColourText;

            d1.Invoke("green colour text", ConsoleColor.Green);

            d2("orange colour text", ConsoleColor.Yellow);

            DlgtWriteGreeColourText d3 = WriteGreenColourText;
            d3("some else green colour text");

            DlgtWriteOrangeColourText d4 = (string text) => {
                var a = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(text);
                Console.ForegroundColor = a;
            };
            d4.Invoke("some else orange colour text");
        }
    }
}