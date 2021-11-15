using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserrRegistrationProgram
{
    class FirstName
    {
        const string Regex_Name = "^[A-Z]{1}[A-Za-z]{2,}";
        public string GetFirstName()
        {
            Console.WriteLine("Enter the first name:");
            string FName = Console.ReadLine();
            if (string.IsNullOrEmpty(FName))
            {
                Console.WriteLine("Please enter a name!");
                GetFirstName();
            }
            bool output = TestFirstName(FName);
            if(output == true)
            {
                return FName;
            }
            else
            {
                Console.WriteLine("Invalid First Name entered!");
                GetFirstName();
            }
            return FName;
        }
        public static bool TestFirstName(string name) => (Regex.IsMatch(name, Regex_Name));
    }
}
