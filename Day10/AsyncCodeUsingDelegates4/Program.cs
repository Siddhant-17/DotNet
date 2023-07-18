using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;





//call a function asynchronously using delegates
//call a function  with return value
//call callback function 
//by using AsyncResult class
namespace AsyncCodeUsingDelegates4
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Before Display called");
            Func<String, String> o1 = Display;



            //a.BeginInvoke("sid", Callbackfuction, null);
            //a.BeginInvoke("sid", Callbackfuction, "hello");
            o1.BeginInvoke("sid", Callbackfuction, o1);


            Console.WriteLine("After Display Called");
            Console.ReadLine();
        }

        static String Display(String str)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called " + str);
            return str.ToUpper();
        }
        static void Callbackfuction(IAsyncResult ar)
        {

            //Callback will be called after Display is over
            //the return value of Display will be read here
            Console.WriteLine("Callback function");

            //whatever we will pass here it will get in callback function as AsyncState
            // string str = ar.AsyncState.ToString();
            //Console.WriteLine(str); 

            AsyncResult objar = (AsyncResult)ar;
            Func<String, String> o1 = (Func<String, String>)objar.AsyncDelegate;
            String retraval;
            retraval = o1.EndInvoke(ar);
            Console.WriteLine(retraval);



        }

    }

}

