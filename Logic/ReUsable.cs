
using System.Text;
using Kid_Timetable.InputValidation;

namespace Kid_Timetable.Logic
{
    public class ReUsable
    {  
        
        // Request user to eneter the multiplicand to learn.
        public static int ReusableMultiplier()
        {
         return ValidationMultiplicand.ValidMultiplicand();    
        }
        // Request user name.
        public static string ReusableName()
        {
                return ValidationName.ValidName();
        }
        // Test Knowledge: Number of questions request
        public static int Reusableloopnum()
        {
            int reusenum;
            Console.Write("How many question will you like to try? You have a maximum of 12 try.");
            Console.WriteLine();
            reusenum = Int32.Parse(Console.ReadLine());
            return reusenum;


        }
        // Test Knowledge Acces
        public static string reusetest;
        public static string Reusabletest()
        {
            
            Console.WriteLine("Type (ENTER) to test your knowledge");
            Console.WriteLine();
            reusetest= Console.ReadLine();
            return reusetest;


        }
       // Test Questions
        public static int Reusablerandomnumber()
        {
            Random random = new Random();
            int reuserandomnumber = random.Next(1, 13);
            return reuserandomnumber;

            
        }
        public static int answer;
        public static int testAnswers;
        public static int Reusabletestanswer()
        {
            int number = ReUsable.Reusableloopnum();
            
            for (int i = 0; i < number; i++)
            {
                int randomMultiplier = ReUsable.Reusablerandomnumber();
                int kidsMultiplicand = ValidationMultiplicand.reusemultiplicand;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{kidsMultiplicand} * {randomMultiplier} = ------- ?");
                Console.WriteLine();
                
                do
                {
                    if (int.TryParse(Console.ReadLine(), out testAnswers))
                    {
                        answer = kidsMultiplicand * randomMultiplier;

                        if (answer == testAnswers && ValidationTestAnswer.ValidateTestAnswer())
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(@$" You are Correct
                           {kidsMultiplicand} * {randomMultiplier}= {answer}");
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(@$"Incorrect answer, 
                            {kidsMultiplicand} * {randomMultiplier}= {answer}");
                            Console.ReadLine();
                        }
                        break;
                    }
                } while (true);
               
                
               
            }
            return answer;
            


        }
    }
}
