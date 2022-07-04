using System;
using System.Collections.Generic;
using System.Text;

namespace Static__Extentions.Models
{
    public class Car
    {
        public static int Speed;
         
        static Car()
        {
            Speed = 500;
            Console.WriteLine(Speed);
        }
       

       //public static void ShowSpeed()
       // {
       //     Console.WriteLine(Speed);
       // }

        //public static int Run()
        //{
        //    return Speed;
        //}
    }
}
