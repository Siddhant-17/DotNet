using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape();
            sh.Display();
            sh.Add();
        }
    }


    public interface IDbFunction
    {
        //by default all method in interface are public and abstract //so dont need to write public abstract
         void Display();
         void Add();
    }

    public class Shape: IDbFunction
    {
       // must  override display and add method
        public void Display()
        {
            Console.WriteLine("inside shape class display method");
        }

        public void Add()
        {
            Console.WriteLine("inside shape class Add method");

        }
    }
}
