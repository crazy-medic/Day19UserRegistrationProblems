using System;

namespace UserrRegistrationProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string FName, LName,eMailid;
            //FirstName fn = new FirstName();
            //FName = fn.GetFirstName();
            //LastName ln = new LastName();
            //LName = ln.GetLastName();
            //Console.WriteLine("\nYour name is " + FName + " "+LName);
            Email em = new Email();
            eMailid = em.GetEMailID();
            Console.WriteLine("Entered email is "+eMailid);
        }
    }
}
