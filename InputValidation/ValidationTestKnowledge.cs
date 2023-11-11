using Kid_Timetable.Logic;
using System.Text.RegularExpressions;

namespace Kid_Timetable.InputValidation
{
    public class ValidationTestKnowledge
    {
        public static void ValidTestKnowledge() 
        {
            

            do
            {
                ReUsable.Reusabletest();
                if ( ValidationTestKnowledge.ValidateTestKnowledge())
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Write the correct input");
                }
                Console.Clear() ;
            } while (true);
        }

        static bool ValidateTestKnowledge()
        {
            string testValuePattern = @"^enter$";
            return Regex.IsMatch(ReUsable.reusetest , testValuePattern, RegexOptions.IgnoreCase);
        }
    }
}
