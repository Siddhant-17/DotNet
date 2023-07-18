using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//call fuction asychronously using delegate
//without parameter
namespace AsyncCodeUsingDelegates
{
    internal class Program
    {
        static void Main21(string[] args)
        {
            Console.WriteLine("Before Display called");
            Action a = Display;
            //a();   //Synchronous code
            /*
             * //when we call a()  directly Sync call then output will be
               //Before Display and wait 
               // 3 sec for Display
               //and after display
             */


            a.BeginInvoke(null, null);  //Async call
            /*
             * when we call this method
             * this function will be run on diff thread thread will not be created explicitly 
             * but thread is used from thread pool from CLR
             */

            /*output
             * Before Display called
             * After Display Called            not wait for 3 sec  Asyn call
             * Display Called            
             */


            Console.WriteLine("After Display Called");
        }

        static void Display()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called");
        }


        
    }
}

//call fuction asychronously using delegate
//pass parameter to function
namespace AsyncCodeUsingDelegates1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Display called");
            Action<String> a = Display;
           
            a.BeginInvoke("sid",null, null); 

            Console.WriteLine("After Display Called");
            Console.ReadLine();
        }

        static void Display(String  str)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called " + str);
        }



    }
}


