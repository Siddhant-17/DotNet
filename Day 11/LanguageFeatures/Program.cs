using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;

            var b = "abs";  //implicit variable
                            //var c=(long) 100;  //implicit variable
                            //b = 45;// error
                            //var a; //error

            //use only for local variable
            //cant be used for class level variables, function parameters and return tyep


            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());

            Console.WriteLine(b);

        }
    }
}
