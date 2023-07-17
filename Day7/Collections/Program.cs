using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            list.Add("sid");        //now it accept String as parameter

            Stack<int> s = new Stack<int>();

            SortedList<int, String> st = new SortedList<int, string>();
            
            
            //forech loop
            foreach(KeyValuePair<int,String> item in st)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}
