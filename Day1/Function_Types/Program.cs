using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Types
{
    internal class Program
    {
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public int Add1(int a,int b,int c)
        {
            return a + b + c;   
        }

        public int Add2(int a=0, int b=0, int c=0)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add(1, 2, 3);  //Positional parameter

            program.Add1(a: 10, b: 30,40);     //named parameter

            program.Add1(a:2,43,54);

            Console.WriteLine(program.Add(12, b: 54, c: 65));

            program.Add1(89, c: 54, b:45);      //this will work 

            //program.Add1(89, c: 54, 45);        //this will give compile time error

            program.Add2();          //default parameter

            Console.WriteLine(program.Add2(23));
        }

    }
}
