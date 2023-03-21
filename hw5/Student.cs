namespace hw5
{
    class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string City { get; set; }
        private Course[] CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city)
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
            var i = 0;
            foreach (var c in CoursesAttended)
            {
                if (c != null)
                    Console.WriteLine($"courses attended: {++i}. {c.CourseName}");
            }
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
    }
}