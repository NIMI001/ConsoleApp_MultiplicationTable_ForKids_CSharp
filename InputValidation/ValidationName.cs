
using System.Text.RegularExpressions;



namespace Kid_Timetable.InputValidation
{
    public class ValidationName
    {
        public static string reusename = "";
        public static string ValidName()
        {
            do
            {
                
                Console.Write(@"What is your name?

                 Note!,Your name must:
                 1. Have no spaces.
                 2. Have no digit.
                 3. Begin with a Capital letter.");
                Console.WriteLine();
                reusename = Console.ReadLine();
                if (ValidationName.ValidateName())
                {
                    Console.WriteLine("You have entered a Valid Name");
                     break;
                }
                else
                {
                    Console.WriteLine("Invalid name! Enter your name correctly.");
                    Console.WriteLine();
                    
                }
                

            } while (true);
            return reusename;
        }
        static bool ValidateName()
        {
            
            string pattern = @"^[A-Z][a-zA-Z]*$";

            // Use Regex.IsMatch to check if the name matches the pattern.
            return Regex.IsMatch(reusename, pattern);
        }
    }
}
