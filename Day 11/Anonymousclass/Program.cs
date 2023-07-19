using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousclass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //first 
            //Class1 o1 = new Class1();
            //Class1 o1 = new Class1{a=10,b="abc",c=23};


            var obj1 = new { a = 10, b = "sid", c = 90 };
            var obj2=new { a = 1, b = "sss", c = 9 };                           //we can't use var as class level

            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.c);
            Console.WriteLine(obj1.b);
            Console.WriteLine(obj1.GetType());           //here compiler will give some name
            Console.WriteLine(obj2.GetType());            //<>f__AnonymousType0`3[System.Int32,System.String,System.Int32]
                                                         //<> f__AnonymousType0`3[System.Int32, System.String, System.Int32]
                                                         //same name 
        }
    }
}
