namespace hw5
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public override void DescribeYourself()
        {
            Console.WriteLine($"Hello, i'm a teacher. I was born in {City} and i'm {Age} years old.");
        }
    }
}