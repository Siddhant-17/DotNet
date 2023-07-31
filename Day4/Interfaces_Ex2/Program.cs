using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 cls = new Class1();
            cls.Insert();
            cls.Display();
            cls.Open();
            cls.Write();
            /*
             * cls.Delete();  here delete() method is in both interface and if we want 
             * to override both interface method then  we have to implement these member explicitly
            */

            //cls.Delete();   error does not contain Delete method
            Console.WriteLine();
            Console.WriteLine("-----------------------RUNTIME POLY---------------------------");
            Console.WriteLine();
            IDbFunction idb = new Class1();
            idb.Delete();

            IFileFunction ifl = new Class1();
            ifl.Delete();


        }
    }

    public interface IDbFunction                   //interface 1
    {

        //by default all methods in interface are abstract and public
        void Insert();
        void Display();
        void Delete();
    }

    public interface IFileFunction                //interface 2
    {
        //by default all methdos inside interface are public and abstract 
        void Open();
        void Write();
        void Delete();

    }


    public class Class1 : IDbFunction, IFileFunction
    {
        //we have to implement methods from interface

        public  void Insert()
        {
            Console.WriteLine("inside insert method");
        }

        public void Display()
        {
            Console.WriteLine("inside Display method");

        }

        public void Open()
        {
            Console.WriteLine("inside Open method");
        }

        public void Write()
        {
            Console.WriteLine("inside write method");

        }
        //public void IDbFunction.Delete()    but explicitly implemented methods are private and we cannot make it as public 
        void IDbFunction.Delete()     //IDbFunction interface
        {
            Console.WriteLine("inside delete method of IDbFunction interface");

        }

        void IFileFunction.Delete()   //IFileFunction interface
        {
            Console.WriteLine("inside delete method of IFileFunction interface");

        }

    }
}
