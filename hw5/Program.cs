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
            var student2 = new Student("boris", "johnson", 50, "london");

            var course1 = new Course("course1", "teacher1", 100);
            var course2 = new Course("course2", "teacher2", 70);
            var course10 = new Course("course10", "teacher10", 90);

            student1.AddCourse(course1);
            student1.AddCourse(course2);
            student1.AddCourse(course10);
            student1.Print();
            student2.AddCourse(course2);
            student2.AddCourse(course10);
            student2.Print();
            course1.Print();
            course2.Print();
            course10.Print();

            student1.DeleteCourse(course2);
            student2.DeleteCourse(course10);
            student1.Print();
            student2.Print();
            course2.Print();
            course10.Print();
        }
    }
}