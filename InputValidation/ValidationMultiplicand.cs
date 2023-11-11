
using Kid_Timetable.Logic;
using System.Text.RegularExpressions; 


namespace Kid_Timetable.InputValidation
{
    public class ValidationMultiplicand
    {  public static int reusemultiplicand;
        public static int ValidMultiplicand()
        {
            do
            {
                
                Console.WriteLine("Enter the multiplicand you want to learn.");
               Console.WriteLine();

                if (int.TryParse(Console.ReadLine(), out reusemultiplicand))
                {

                    if (ValidationMultiplicand.ValidateMultiplicand())
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid number! ");
                        Console.WriteLine();

                    }
                }

               
                Console.Clear();
            }while(true);
            
            return reusemultiplicand;
        }

        public static bool ValidateMultiplicand()
        {
            string multiplicandpattern = @"^[0-9]+$";

            // Use Regex.IsMatch to check if the name matches the pattern.
            return Regex.IsMatch(reusemultiplicand.ToString(), multiplicandpattern, RegexOptions.IgnorePatternWhitespace);
        }
    }
}
