using System;

namespace VisualStudioFeaturesDemo.Classes
{
    public class Person
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public int Age { get; set; }
        #endregion

        #region Constructors
        public Person()
        {
            FirstName = null;
            LastName = null;
            Age = 0;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        #endregion

        #region Functions
        public static Person ReadPersonInput()
        {
            Console.WriteLine("First Name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Age:");
            var age = Int32.Parse(Console.ReadLine());

            return new Person(firstName, lastName, age);
        }

        public static Person EvalAge(Person friend1, Person friend2)
        {
            return (friend1.Age > friend2.Age) ? friend1 : friend2;
        }
        #endregion

        #region Overloads

        public static bool operator ==(Person a, Person b)
        {
            return a.Age == b.Age;
        }

        public static bool operator !=(Person a, Person b)
        {
            return a.Age != b.Age;
        }

        #endregion
    }
}
