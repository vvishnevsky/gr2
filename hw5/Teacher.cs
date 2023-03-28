namespace hw5
{
    class Teacher : Person
    {
        private List<Student> Students { get; set; }
        private List<Course> Courses { get; set; }

        public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            Students = new List<Student>();
            Courses  = new List<Course>();
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"Hello, i'm a teacher. I was born in {City} and i'm {Age} years old.");
            if (GetCoursesCount() > 0)
            {
                Console.WriteLine($"I'm teaching {GetCoursesCount()} course(s):");
                Courses.ForEach(c => Console.WriteLine(c.CourseName));
            }
            else
                Console.WriteLine("Unfortunatly i'm not teaching any cources at the moment");

            if (GetStudentsCount() > 0)
            {
                Console.WriteLine($"Currently {GetStudentsCount()} student(s) are learning my courses:");
                Students.ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));
            }
            else
                Console.WriteLine("But, nobody wants studing");
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
        }

        public int GetStudentsCount()
        {
            return Students.Count;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public void DeleteCourse(Course course)
        {
            Courses.Remove(course);
        }

        public int GetCoursesCount()
        {
            return Courses.Count;
        }
    }
}