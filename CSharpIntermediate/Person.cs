namespace CSharpIntermediate
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hello {0}, my name is {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }

        //public Person(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}
    }
}
