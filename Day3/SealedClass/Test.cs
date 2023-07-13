using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass

{
    internal class Test
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(); // create object of sealed class but not override or change any method inside it
            e.Show();
        }
    }




    public sealed class Employee     // if we make class seales then we can create object of this class but we can not inherit this class
    {
        public void Show()
        {
            Console.WriteLine("inside show method employee");
        }
    }

    public class Salesman 
    {
       
    }

    public class Clerk 
    {

    }
    public class Officer   //: Employee    error as Empolyee class is sealed you cannot inherit it
    {
       

    }
}
