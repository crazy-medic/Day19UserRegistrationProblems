using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserrRegistrationProgram
{
    class Email
    {
        const string Regex_email = "^[a-z]{3,}[.]*[a-z0-9]*[@]{1}[a-z]{2,}[.]{1}[co]{2}[m]*[.]*[a-z]*$";
        public string GetEMailID()
        {
            Console.WriteLine("Enter the first name:");
            string eMailID = Console.ReadLine();
            if (string.IsNullOrEmpty(eMailID))
            {
                Console.WriteLine("Please enter an email!");
                GetEMailID();
            }
            bool output = TestEMail(eMailID);
            if (output == true)
            {
                return eMailID;
            }
            else
            {
                Console.WriteLine("Invalid email entered!");
                GetEMailID();
            }
            return eMailID;
        }
        public static bool TestEMail(string eMailID) => (Regex.IsMatch(eMailID, Regex_email));
    }
}
