using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserrRegistrationProgram
{
    class LastName
    {
        const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";
        public string GetLastName()
        {
            Console.WriteLine("Enter the Last name:");
            string LName = Console.ReadLine();
            if (string.IsNullOrEmpty(LName))
            {
                Console.WriteLine("Please enter a name!");
                GetLastName();
            }
            bool output = TestFirstName(LName);
            if (output == true)
            {
                return LName;
            }
            else
            {
                Console.WriteLine("Invalid Last Name entered!");
                GetLastName();
            }
            return LName;
        }
        public static bool TestFirstName(string name) => (Regex.IsMatch(name, Regex_Name));
    }
}
