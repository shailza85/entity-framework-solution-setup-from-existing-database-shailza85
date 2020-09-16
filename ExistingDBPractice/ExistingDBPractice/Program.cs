using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ExistingDBPractice.Models;

namespace ExistingDBPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Take in a first name from the user
                Case insensitive
                Trimmed
                Then print the full name of that user from the database
                If the name is not in the database then output “Name not found.” and exit.

             */

            using (PersonContext context = new PersonContext())
            {
                string firstName;
                Console.Write("Please enter the First Name: ");
                firstName = Console.ReadLine().ToLower().Trim();

                string fname;
                if (context.Person.Any(x => x.FirstName == firstName))
                {
                  fname = context.Person.Where(x => x.FirstName == firstName).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault().ToString();

                    Console.WriteLine("The full name of person is:" + fname);
                }
                else                  
                {
                    Console.WriteLine("Name not found.");
                }  

            }
        }
    }
}
