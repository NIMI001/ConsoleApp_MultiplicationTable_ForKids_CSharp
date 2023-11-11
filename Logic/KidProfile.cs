using Kid_Timetable.Data;
using Kid_Timetable.InputValidation;
using Kid_Timetable.Model;
using System;


namespace Kid_Timetable.Logic
{
    public class KidProfile
    {
        public static int kidage = 0;
        public static void Profile()

        {


            Context.User.Add(new Model.KidUser()
            {
                KidAge = kidage,


            });


            ValidationAge.ValidAge();
        }
    }
}

            
           
            




        
    

