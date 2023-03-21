namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter age: ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Enter city: ");
            var city = Console.ReadLine();

            var student1 = new Student(firstName, lastName, age, city);
            
            student1.AddCourse("course1");
            student1.AddCourse("course2");
            student1.AddCourse("course10");
            student1.Print();

            student1.DeleteCourse("course2");
            student1.Print();
        }
    }
}