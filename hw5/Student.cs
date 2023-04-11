namespace hw5
{
    class Student : Person
    {
        //private Course[] CoursesAttended { get; set; }
        private List<Course> Courses { get; set; }

        public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            //CoursesAttended = new Course[10];
            Courses = new List<Course>();
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
            //for (var i = 0; i < CoursesAttended.Length; i++)
            //    if (CoursesAttended[i] == null)
            //    {
            //        CoursesAttended[i] = course;
            //        break;
            //    }
            Courses.Add(course);
            
            course.AddStudent(this);
        }

        public void DeleteCourse(Course course)
        {
            //var temp = new Course[CoursesAttended.Length];
            //var i = 0;
            //foreach (var c in CoursesAttended)
            //{
            //    if (course != c && c != null)
            //    {
            //        temp[i] = c;
            //        i++;
            //    }
            //}
            //CoursesAttended = temp;
            Courses.Remove(course);
            course.DeleteStudent(this);
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"Hey, dude, i'm a student i'm {Age} years old. Currently i'm attending {GetCoursesCount} courses:");
            PrintCourses();
        }

        private void PrintCourses()
        {
            var i = 0;
            //foreach (var c in CoursesAttended)
            //{
            //    if (c != null)
            //        Console.WriteLine($"courses attended: {++i}. {c.CourseName}");
            //}
            Courses.ForEach(course => { Console.WriteLine($"courses attended: {++i}. {course.CourseName}"); });
        }

        public int GetCoursesCount()
        {
            return Courses.Count;
        }
    }
}