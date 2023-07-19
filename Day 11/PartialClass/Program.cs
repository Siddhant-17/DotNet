using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * partical class
 * 
 * they must be in same namespace
 * they must be in  same Assembly (project)
 * and they have same class name
 * 
 */


namespace PartialClass
{

    /*
     * partical class
     * 
     * they must be in same namespace
     * they must be in  same Assembly (project)
     * and they have same class name
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.i);
            Console.WriteLine(obj1.j);
            Console.WriteLine(obj1.sid);

            //obj1.diff_namespace;   not avialable 
        }

    }
    public partial class Class1
    {
        public int i = 10;
    }

    public partial class Class1
    {
        public int j = 17;
    }

    public partial class Class1
    {
        public String sid;
    }

}
    



namespace PartialClass1
{


    //field inside in this namespace  not partial for above

    public partial class Class1
    {
        public int diff_namespace;
    }
}
