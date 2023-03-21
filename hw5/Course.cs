namespace hw5
{
    class Course
    {
        public string CourseName { get; private set; }
        public string TeacherName { get; private set; }
        public int CourseDuration { get; private set; }
        public int Students { get; private set; }

        public Course(string courseName, string teacherName, int courseDuration)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            CourseDuration = courseDuration;
        }

        public void Print()
        {
            Console.WriteLine($"Course: {CourseName}, Teacher: {TeacherName}, Course hours: {CourseDuration}, Students: {Students}");
        }

        public void AddStudent()
        {
            Students++;
        }

        public void DeleteStudent()
        {
            Students--;
        }
    }
}