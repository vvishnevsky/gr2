namespace hw5
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public virtual void DescribeYourself()
        {
            Console.WriteLine("describe yourself method from the base class.");
        }

        public Person(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
    }
}