using System;
using VisualStudioFeaturesDemo.Classes;

namespace VisualStudioFeaturesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter details of person 1.");
            var friend1 = Person.ReadPersonInput();

            Console.WriteLine(""); //New line
            Console.WriteLine("Please enter details of person 2.");
            var friend2 = Person.ReadPersonInput();

            Console.WriteLine(""); //New line
            Console.WriteLine(""); //New line

            if (friend1 == friend2)
            {
                Console.WriteLine("Both people are the same age.");
                return;
            }

            Person olderFriend = Person.EvalAge(friend1, friend2);
            Console.WriteLine(string.Format("{0} is older.", olderFriend.FullName));
        }
    }
}
