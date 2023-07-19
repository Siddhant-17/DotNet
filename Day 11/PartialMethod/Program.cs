using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{


    /*
     * partial method
     * 
     * partial method can only be define in partial class
     * partial method must be return void
     * can be static or instance level
     * cannot have out parameter
     * are always implicitly private   we can not make theme public or write private
     * 
     */




    internal class Program
    {
        // partial method not coded
        static void Main1(string[] args)
        {



            Shape sh = new Shape();                 //now here if partial method not be coded then complier remove all traces of partial method
            sh.Display();
            Console.ReadLine();
        }


        //coded partial method
        static void Main(string[] args)
        {
            Shape1 sh1 = new Shape1();
            sh1.Display();
            Console.ReadLine();
        }
    }

    // partial method not coded
    public partial class Shape
    {
        private int area = 100;

         partial  void Display_area();
        //now here if partial method not be coded then complier remove all traces of partial method

        public void Display()
        {
            Display_area();
            Console.WriteLine("inside display area="+area);                                  //now show in ildasm 
        }

    
    }


    //coded partial method
    public partial class Shape1
    {

        private int area = 100;
        partial void Display_Area();          //here if class is not partial then give error    //partial method by default private not change accesses specifire

        public void Display()
        {
            Display_Area(); 
            Console.WriteLine("inside display area="+area);
        }
    }

    public partial class Shape1
    {
        partial void Display_Area()
        {
            area = 1717;                               //change area value in partial shape by partial method
        }
    }
}
