using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_Ex
{
    internal class Program
    {
        //problem if we not use enum
        static void Main1(string[] args)
        {

            //problem if we not use enum
            Display(1);
            // how do you know that 1==monday,2==tuesday
            //we have to remember these value
            //or if we change value form Display function
            //if outer person call Display method he don't know assigned value so difficult to use ,maintain
        }
        static void Display(int t)
        {
            if (t == 1)
                Console.WriteLine("monday");
            else if (t == 1)
                Console.WriteLine("tuesday");
            else if (t == 3)
                Console.WriteLine("wednesday");
            else if (t == 4)
                Console.WriteLine("friday");

        }




        //enum
        static void Main()
        {
            Display(TimeDay.morning);
        }
        public enum TimeDay
        {
            morning,                  // by default first element is zero
            afternoon,
            evening ,          //we can assigned value
            night                // if we do evening =10   then night=11
        }
        //advantage if we assigned value in enum then also code will not change
        static void Display(TimeDay t)
        {
            if (t == TimeDay.morning)
                Console.WriteLine("Good morning");
            else if (t == TimeDay.afternoon)
                Console.WriteLine("Good afternoon");
            else if (t == TimeDay.evening)
                Console.WriteLine("Good evening");
            else if (t == TimeDay.night)
                Console.WriteLine("Good night");

        }
    

        //by default enum id integer type
        //if we want to change datatype
        public enum Time : long
        {
            a,b,c,d

        }
    }
}
