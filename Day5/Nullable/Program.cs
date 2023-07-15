using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {

        // reference type we will make pointing to null
        String s = null;
        //but
        //int i = null;     we will not assigned null to value type 



        /*but somtime you want to stored null value into value type
        suppose we are reading value from database and in our database null coloumn is available 
        int i= GetDeptNo()  ----- and if this query return null  then  null pointer exception 
        */


        /*
         * NUllABLE  Type -- is type in which value type can also be accept null
         * 
         */
        static void Main(string[] args)
        {
            int j = 67;     //not be null
            int ? i = 98;    //Nullable int
            bool? status = null;

            //if we assigned normal int to nullable int 
            j = (int) i;  //need to typecase into int explicitly
            //and if we make i=null
            i = null;
           // j = (int)i;  //throw NUllPointer Exception at this point

            //Nullable int get some property
            if(i.HasValue)   // hasvalue property  return true is i is not null
            {
                Console.WriteLine(i);
                j = (int)i;
                //or
                j = i.Value;
            }

            //3rd option
            j = i.GetValueOrDefault();     // if i hasvalue then it will assigned to j else default value of int 
            j = i.GetValueOrDefault(32);     // if i hasvalue then it will assigned to j else default value of 34 
            Console.WriteLine(j);



            //4th option -----------null coalesing operator
            j = i ?? 10;          // if i hasvalue then it will assigned to j else default value of 0 
            Console.WriteLine(j);



        }



    }
}
