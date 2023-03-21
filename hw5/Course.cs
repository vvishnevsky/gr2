namespace hw5
{
    class Course
    {
        private string CourseName { get; set; }
        private string TeacherName { get; set; }
        private int CourseDuration { get; set; }
        private int Students { get; set; }

        public Course(string courseName, string teacherName, int courseDuration)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            Students = courseDuration;
        }

        public void Print()
        {
            Console.WriteLine($"{CourseName} {TeacherName} {CourseDuration} {Students}");
        }

        public void AddStudent()
        {
            Students++;
        }
    }
}