using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main1(string[] args)
        {

            //if i did this 
            int i = 8;
            //and  when we do i.  then we will show some method 
            //i.

            //Extension Method
            int j = 10;
            string str = "sid";

            //in Extension Method we will write our method and when we do 
            // j.
            //str.      our method also be suggest


            //suppose if someone write class and 2 method inside it  
            //now how can we add another method withod writing method code in that class
        }


        //Extension Method
        static void Main2(string[] args)
        {
            int i = 12;
            //i.         now here will suggest our Display function
            i.Display();         //and this i will go as first parameter of Display()

            String s = "siddhant";
            s.Show(i);




            /*
             * what actually happens
             * 
             * class is static  and method is static
             * 
             * int a=10;
             * Class1.Display(a);            //static method call on class name
             * 
             * when we write
             * 
             * int i=10;
             * i.Dispaly();              //compiler internally convert it into  Class1.Display(a); 
             * s.Show(i);
             * Class1.show(str,a);      //compiler and vs code fooling us
             * 
             */
        }

    }


    //step1    ---  create static class
    public static class Class1
    {
        //step2    ---  write static method

        //step3    ---  first parameter of this method should be for which you are writing extension method  and preced int with this  // int i=12;
        public static void Display(this int i)
        {
            Console.WriteLine("inside display " + i);
        }


        public static void Show(this string str,int i)
        {
            Console.WriteLine("String str :"+str+"int :" +i);
        }
    }


    //this Object i      if we write Extension Method for base class then avilable for everywhere at all its derived class          this int i  for --- int  i
    //this Object i  for all who is base of Object
    public static class BaseClass
    {
        public static void add(this Object i)                             
        {
            Console.WriteLine("inside display " + i);

        }

        public static void Subsract(this Iinterface i,int j)
        {
            Console.WriteLine("inside add " + i +" "+j);
        }
        static void Main()
        {
            int i = 19;
            i.Display();

            shape sh = new shape();
            sh.Subsract(i);
        }
    }
    public interface Iinterface
    {
        void Add(int i);
    }

    public class shape : Iinterface
    {
        public void Add(int i)
        {
            Console.WriteLine("add");
        }
    }




}
