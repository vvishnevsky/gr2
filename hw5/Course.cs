namespace hw5
{
    class Course
    {
        public string CourseName { get; private set; }
        public string TeacherName { get; private set; }
        public int CourseDuration { get; private set; }
        //public int Students { get; private set; }
        private List<Student> Students { get; set; }

        public Course(string courseName, string teacherName, int courseDuration)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
            Students = new List<Student>();
        }

        public void Print()
        {
            Console.WriteLine($"Course: {CourseName}, Teacher: {TeacherName}, Course hours: {CourseDuration}," +
                $" Students: {GetStudentsCount()}");
        }

        public void AddStudent(Student student)
        {
            //Students++;
            Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            //Students--;
            Students.Remove(student);
        }

        public int GetStudentsCount()
        {
            return Students.Count;
        }
    }
}