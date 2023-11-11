using Kid_Timetable.Model;
using System;
using System.Collections.Generic;



namespace Kid_Timetable.Data
{
    public class Context
    {
        public static IList<KidUser> User { get; set; } = new List<KidUser>();
        public static IList<TimetableVariable> Timetable { get; set; }= new List<TimetableVariable>();
    }
}
