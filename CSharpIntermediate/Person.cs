using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name { get; private set; }
        private DateTime _birthdate;

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - _birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }


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
