using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Employee
{
    internal class Test
    {
        static void Main(string[] args)
        {

            Manager m = new Manager("sid", 10, "owner");
            Console.WriteLine(m.GetName);
        }
    }

    public abstract class Employee
    {
        private String name;
        public String Name {
            set
            {
                if (value.Equals(""))
                    Console.WriteLine("enter name");
                else
                    name = value;    
                }
        }
        public String GetName { get; }

        private static int empno;

        private short deptNo;
        public short DeptNo{ 
            set {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("enter > 0");

            }
        }

        public abstract decimal Basic { set; get; }   // here we need to create class as abstract class


        public Employee(string name, short deptNo)
        {
            Name = name;
            DeptNo = deptNo;
            
        }

        public abstract decimal CalculateNetSalary();
    }


    public class Manager : Employee
    {
       

        public override decimal Basic { set; get; }
        private String degignation;
        public String Degignation
        {
            set
            {
                if (value != "")
                    degignation = value;
            }
        }
        public Manager(string name, short deptNo,string deg) : base(name, deptNo)
        {
            Degignation = deg;

        }

       


        public override decimal CalculateNetSalary()
        {
                int i = 10;
                int j = 20;
            Console.WriteLine("inside Manager CalculateNetSalary method");
            return i + j;
        }


    }
}
