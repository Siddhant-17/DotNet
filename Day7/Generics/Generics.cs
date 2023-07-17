using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics
    {
        static void Main(string[] args)
        {
            IntClass ic = new IntClass();
            ic.Display(2,3);
            DecimalClass dc = new DecimalClass();
            dc.Display(3, 4);



            //Generics CommonClass<T>
            CommonClass<String> cc = new CommonClass<string>();
            cc.Display("sid", "rutu");

            /*
            public class MyStack<T> where T : class             // T must be reference type
            public class MyStack<T> where T : struct           //T must be value type
            public class MyStack<T> where T : CommonClass<T>  //T must be give class or its derived class    public class MyStack<T> where T:IDbConnection //interface T must be class that implements given interface
            public class MyStack<T> where T:IDbConnection    //interface T must be class that implements given interface
            public class MyStack<T> where T : new()         // T must have no parameter constructor
            */
            }
    }


    //suppose if we have 2 3 class with same functionality but differnce only data type 
    //then we can write only one class Generics

    //suppose first class
    public class IntClass
    {
        private int i = 18;
        private int j = 30;

        public void  Display(int i,int j)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
        
    }

    //suppose second class
    public class DecimalClass
    {
        private Decimal i = 18;
        private Decimal j = 30;

        public void Display(Decimal i, Decimal j)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }

    }


    //by using genrics we can create class 
    public class CommonClass<T>
    {
        public T i { get; set; }
        public T j { get; set; }

        public void Display(T i, T j)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }

    }

   



}
