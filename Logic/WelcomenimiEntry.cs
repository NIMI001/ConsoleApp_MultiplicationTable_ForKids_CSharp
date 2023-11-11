using System;
using System.Security.Cryptography.X509Certificates;
using Kid_Timetable.Data;


namespace Kid_Timetable.Logic
{
    public class WelcomenimiEntry
    {
        public static string kidUserName;
        public static void Welcome()
        {
            Console.WriteLine("==========================================");

            Console.WriteLine("|| NIMI, TEACH ME TO RECITE MY TIMETABLE||");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{                      This App is suitable for kids between ages 3-10.                                  }");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            // Request user name
            kidUserName = ReUsable.ReusableName();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            // Request User Age for validity
            Console.WriteLine();
           
            
            KidProfile.Profile();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            // Multiplication table interface
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"||                   Welcome {kidUserName.ToUpper()}!, Learn your multiplication table with ease.                  ||");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" For your learning sessions! Press 1 to begin");
            var input= Console.ReadLine();
            if(input == "1")
            {
                StartkidLogic();
            }
            else
            {
                Console.Clear();
                Welcome();
            }

            
        }
        public static void StartkidLogic()
        {
            
       

            int kidMultiplicand = ReUsable.ReusableMultiplier();
            Console.Clear();
            Console.WriteLine($"Your {kidMultiplicand} times multiplication table is:");
            MultiplicationTable multiply = new MultiplicationTable();
            multiply.MultiplicationTableGenerator(kidMultiplicand);
            Console.WriteLine();

            //  Knowledge drill
            MultiplicationTable.TestKnowledge();
            ReUsable.Reusabletestanswer();
            Console.Clear();
         
            Console.WriteLine(@" 
            Enter 1 to go another round
            Enter 2 to close the window");
            string number=Console.ReadLine();

            if (number == "1")
            {
                StartkidLogic();
            }
            else if (number == "2")
            {
                Console.Clear();
                Console.WriteLine($" Good Job {kidUserName.ToUpper()}!. I hope you had a great time learning? ");
                Console.ReadLine();

                
            }
        }
                
            

}

    
}
