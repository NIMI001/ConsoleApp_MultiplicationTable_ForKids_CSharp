
using System.Text.RegularExpressions;
using Kid_Timetable.Logic;

namespace Kid_Timetable.InputValidation
{
    
    public class ValidationAge
    {
        public static void ValidAge()
        {
            do
            {
               
                Console.WriteLine("How old are you?");
                if (int.TryParse(Console.ReadLine(), out KidProfile.kidage))
                {

                    if (ValidationAge.ValidateAge())
                    {
                        Console.WriteLine(@" You've got Access! Learn to your satisfaction");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("This app is suitable for kids between Ages 3-10, please enter a valid input. ");
                        Console.ReadLine();
                         Console.Clear();

                    }



                }

                

            } while (true);
        }



        static bool ValidateAge()
        {  string agePattern= @"^[3-9]|10+$";

            return Regex.IsMatch(KidProfile.kidage.ToString(), agePattern,RegexOptions.IgnorePatternWhitespace);
        }
     
    }
}
