using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtsractClass
{
    internal class Test
    {
        public static void Main() {
        // Employee e = new Employee();// error abstract class 
        Officer o = new Officer();
        o.Display();

        Employee o2 = new Salesman();
        o2.Display();    
        }
    }
    public  abstract class Employee     // if we make class abstract then we not create object of this class
    {
        public void Show()
        {
            Console.WriteLine("inside normal method employee");
        }

        public abstract void Display();
        // abstract method is pure virtual function ---  means in base class we just define abstract fun 
        // we cannot write body inside base class of abstract methdo
        //error
        /*{
            Console.WriteLine("inside abstract method employee");

        }*/

    }

    public class Salesman : Employee
    {
        public override void Display()
        {
            Console.WriteLine("inside abstract method Salesman");
        }
    }

    public class Clerk : Employee
    {

        public override void Display()
        {
            Console.WriteLine("inside abstract method Clerk");

        }

    }
    public class Officer : Employee
    {
        public override void Display()
        {
            Console.WriteLine("inside abstract method Officer");
        }

    }

}
