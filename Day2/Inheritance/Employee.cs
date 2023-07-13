using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class program
    {
        public static void Main()
        {
            Manager m = new Manager();         // create object of base class
            m.CalculateNetSal();// we can call method of baseclass as well as derived class
                                // m.CalculateNetSal(5);              //overloaded baseclass method in derived class
            Employee emp= new Employee();
            emp.CalculateNetSal();
            //hidding is early bound means at complie time we will known which method will be call  mean if object of baseClass will created then base class method will be call



            //--------------------------------------------------------------------------------------------


            Employee m2 = new Manager();
            m2.Overrideing_methd();  //here it will call method of derivedclass  i.e manager class

            Employee m3 = new Employee();
            m3.Overrideing_methd(); // here it will call method of base class i.e Employess class
            //late bound--- at runtime decide which method to be call if reference is pointing to baseclass then base class method will call 
            // ans if pointing to derived class object then derived class method is call



            //--------------------------------------------------------------------------------------------



            //now if we dont want to show base class method
            /*
             * overload -- same function name and different parameter
             * hide method-- deriver class can hide base class method (not in java)
             * override -- in derived class we can override base class method
             * 
             */
        }
    }

    public  class Employee
    {
       public int Money { get; set; }
         
       public int Month{ set; get; }

        public void CalculateNetSal()
        {
            int total = Money + Month;
            Console.WriteLine("in employee"+total);
        }


        //if we want to override base class method keyword virtual
        public virtual void Overrideing_methd()
        {
            int total = Money + Month;
            Console.WriteLine("in employee Overrideing_methd" + total);
        }
        public virtual void Display()
        {

            Console.WriteLine("in employee Display ");
        }


    }



    public class Manager : Employee
    {
        /*
        public new void CalculateNetSal(int i)
        {
            Console.WriteLine("inside manager CalculateNetSal method"+i);
        }
        */

        //hide method from base class
        public new void CalculateNetSal( )
        {
            Console.WriteLine("inside manager CalculateNetSal method" );
        }


        //override methdo from base class
        public override void Overrideing_methd()
        {
            Console.WriteLine("inside override method of derived class");
        }
        // overided method are also virtual  




        //and if we dont want to overide this method in another derived class then we decalred method as sealed
        public sealed override void Display()
        {

            Console.WriteLine("in manager override Display ");
        }




        public class DerivedClass : Manager
        {

            // error as this method is sealed in parents class

            //public  override void Display()
           // {

            //   Console.WriteLine("in manager override Display ");
            //}


        }

    }

}
