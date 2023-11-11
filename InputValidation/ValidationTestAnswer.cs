
using System.Text.RegularExpressions;
using Kid_Timetable.Logic;

namespace Kid_Timetable.InputValidation
{
    public class ValidationTestAnswer
    {
        public static bool ValidateTestAnswer()
        {
            string testanswerpattern = @"^[0-9]+$";

            // Use Regex.IsMatch to check if the name matches the pattern.
            return Regex.IsMatch(ReUsable.testAnswers.ToString(), testanswerpattern, RegexOptions.IgnorePatternWhitespace);
        }
    }
}
