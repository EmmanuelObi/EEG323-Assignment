using System; 

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome Student,");
           Console.Write("Are you a Fulltime or Part-time student? :  ");

           string studentStatus = Console.ReadLine();
           studentStatus = studentStatus.ToLower();

           if (studentStatus == "fulltime")
           {
               Console.Write("What is your Course of Study? : ");
               string courseOfStudy = Console.ReadLine();
               Console.WriteLine($"{courseOfStudy} is a good course.");
           }
           else if (studentStatus == "part-time") {
               Console.Write("How many credits are you taking? : ");
               int amountOfCredits = Convert.ToInt32(Console.ReadLine());
               if (amountOfCredits > 6)
               {
                   Console.WriteLine("That's too much Units for a part-time student");
               }
               else
               {
                   Console.WriteLine("Proceed to Screen");
               }
           }else
           {
               Console.WriteLine("Error!! \nInvalid status");
           }
        }
    }
}
