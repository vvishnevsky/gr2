namespace hw5
{
    class Student : Person
    {
        Course[] CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            CoursesAttended = new Course[10];
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public void Print()
        {
            Console.WriteLine($"Student {FirstName} {LastName}, age {Age}, city {City}");
            PrintCourses();
        }

        public void AddCourse(Course course)
        {
            for (var i = 0; i < CoursesAttended.Length; i++)
                if (CoursesAttended[i] == null)
                {
                    CoursesAttended[i] = course;
                    break;
                }
            course.AddStudent();
        }

        public void DeleteCourse(Course course)
        {
            var temp = new Course[CoursesAttended.Length];
            var i = 0;
            foreach (var c in CoursesAttended)
            {
                if (course != c && c != null)
                {
                    temp[i] = c;
                    i++;
                }
            }
            CoursesAttended = temp;
            course.DeleteStudent();
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"Hey, dude, i'm a student i'm {Age} years old. Currently i'm attending the following courses:");
            PrintCourses();
        }

        private void PrintCourses()
        {
            var i = 0;
            foreach (var c in CoursesAttended)
            {
                if (c != null)
                    Console.WriteLine($"courses attended: {++i}. {c.CourseName}");
            }
        }
    }
}