using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o = new BaseClass();
            // o.I = 12;                             public anywhere
            //o.Name = 'sid';                error   private member accessible inside class only
            // o.salary = 213;                error   available inside same class and derived class
            // o.money = 23;                          available in same class, and same assembly
            // o.sirname = "kali";                     Protected + internal
            // i.e inside same class derived class and in same assembly
            //o.num = 67;                     error   avilable in same class in derived class of same assembly
            Console.WriteLine("hello2");
        }
    }
    public class BaseClass
        {
            // private int i;   //when we write property of this i .net will auto. write this line or private int i;

            public int Public;

            private string Private;

            protected double Protected;

            internal float Internal;

            protected internal String Protected_internal;

            private protected int private_Protected;
        }

        public class DerivedClass : BaseClass
        {
            public  void Display()
            {
                this.Public = 21; //public anywhere 
                //o2.Priavte;   private inside class only
                this.Protected = 323; //in same class and in derived class
                this.Internal = 33; // in same assembly(project)
                this.Protected_internal = "sid";//in same class ,derived class, in same assembly 
                this.private_Protected = 11;//in derived class which is in same assembl
            }
        }



        public class DerivedClass_for_diff_ass:AccesSpecifier2.BaseClass_in_diff_ass
        
        {
                public void Show()
                {
                    this.Public=1; //public anywhere 
                   //this.private private inside class only
                    this.Protected = 322;   //in same class and in derived class
                  // this.Internal = 23;    // in same assembly(project)
                    this.Protected_internal = "sid";//in same class ,derived class, in same assembly
                   // this.private_Protected = 11;//in derived class which is in same assembly
        }

    }
    }



