using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sturct
{
    /*
     * Diff between Class and Struct 
     * Struct-- is value type
     * Class --is reference type
     * NO inheritance is allowed in Struct
     */
    internal class Struct_Ex
    {
        static void Main(string[] args)
        {
            //default ctor in struct is intiate struct to default value
            Mypoint mp = new Mypoint();
            Console.WriteLine(mp.y);
            Console.WriteLine(mp.x);
            Console.WriteLine(mp.j);
            Console.WriteLine(mp.str);
            mp.j = 43;

            //mens when we write
            int i = new int();//struct will call its default constructor and it will initiate variablt to default value
            Console.WriteLine(i);

            int a = 19;  //both line above line are work as same

        }
    }

    public struct Mypoint
    {
        private int i;
        public int j
        {
            get;set;
        }

        public int x, y;
        public String str;

        public Mypoint(int i,int j,int x,int y,String str)
        {
            this.i = i;
            this.j = j;
            this.x = x;
            this.y = y;
            this.str = str;
        }

        /*
         * public Mypoint()
        {
                                 error int structure parameteless constructor is not available
        }*/

     
    }
}
