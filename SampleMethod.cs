using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodPracitce
{
    public static class SampleMethod
    {
        //public static void SayHi()
        //{
        //    Console.WriteLine("Hello World!");

        //}

        //public static double Add(double x, double y) 
        //{
        //    double output = x + y;
        //    return output;
        //}

        //public static void AddAll(double[] values)
        //{
        //    double result = 0;

        //    foreach (double value in values)
        //    {
        //        result += value;
        //    }

        //    Console.WriteLine($"The total value is {result}");
        //}

        //public static string GetUsersName()
        //{
        //    Console.WriteLine("What is your name: ");
        //    string name = Console.ReadLine();

        //    return name;
        //}

        //public static (string firstName, string lastName) GetFullName()
        //{
        //    Console.WriteLine("What is your first name: ");
        //    string firstName = Console.ReadLine();

        //    Console.WriteLine("What is your last name: ");
        //    string lastName = Console.ReadLine();

        //    return (firstName, lastName);
        //}

        public static void WelcomeMessage()
        {
            Console.WriteLine("Hello and welcome to my page.");
        }

        public static string AskName()
        {
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void HelloUser(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
