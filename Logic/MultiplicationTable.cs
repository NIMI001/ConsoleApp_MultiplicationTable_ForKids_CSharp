using Kid_Timetable.InputValidation;
using Kid_Timetable.Data;
using Kid_Timetable.Model;

namespace Kid_Timetable.Logic
{
    public  class MultiplicationTable
    {

        int multipleir;
        public void MultiplicationTableGenerator(int multiplicand)
        {
            
            
            Context.Timetable.Add(new Model.TimetableVariable
            {
                Multiplicand = multiplicand,
                Multiplier = multipleir
            });

            int result;
            for (multipleir=1; multipleir < 13; multipleir++)
            {
                result = multiplicand * multipleir;
                Console.WriteLine();
                Console.WriteLine("{0}*{1}={2}", multiplicand, multipleir, result);
            }
        }

        public static void TestKnowledge()
        {
           
            ValidationTestKnowledge.ValidTestKnowledge();
        }
    }
}
