namespace hw5
{
    class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string City { get; set; }
        private string[] CoursesAttended { get; set; }

        public Student(string firstName, string lastName, int age, string city)
        {
            CoursesAttended = new string[10];
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public void Print()
        {
            Console.WriteLine($"\nStudent {FirstName} {LastName}, age {Age}, city {City}");
            var i = 0;
            foreach (var c in CoursesAttended)
            {
                if (c != null)
                    Console.WriteLine($"courses attended: {++i}. {c}");
            }
        }

        public void AddCourse(string course)
        {
            for (var i = 0; i < CoursesAttended.Length; i++)
                if (CoursesAttended[i] == null)
                {
                    CoursesAttended[i] = course;
                    break;
                }
        }

        public void DeleteCourse(string course)
        {
            var temp = new string[CoursesAttended.Length];
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
        }
    }
}