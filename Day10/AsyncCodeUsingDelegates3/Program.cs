using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


//call a function asynchronously using delegates
//call a function  with return value
//call callback function
//move delegate object at class level  so it can accessed by callback function
namespace AsyncCodeUsingDelegates3
{
    
        internal class Program
        {
       
            static Func<String, String> a;                                  //this is one way we can declare delegate object func a as static in class level so available in class level
            static void Main1(string[] args)
            {
                Console.WriteLine("Before Display called");
               a = Display;

                a.BeginInvoke("sid", Callbackfuction, null);

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
                 String retraval;
                 retraval = a.EndInvoke(ar);
                //Callback will be called after Display is over
                //the return value of Display will be read here
                Console.WriteLine("Callback function");
                Console.WriteLine(retraval);
        }



        }
    
}





//call a function asynchronously using delegates
//call a function  with return value
//call callback function 
//use an annonymous method  (call back method)    to accesd delegate object declare in  Main()    //it is like local fuction all outer function variable will get to local function
namespace AsyncCodeUsingDelegates1
{

    internal class Program
    {

        static Func<String, String> a;                                  //this is one way we can declare delegate object func a as static in class level so available in class level
        static void Main1(string[] args)
        {
            Console.WriteLine("Before Display called");
            a = Display;

            a.BeginInvoke("sid", delegate (IAsyncResult ar)                           //we using annonymous fuction
        {
            String retraval;
            retraval = a.EndInvoke(ar);
            Console.WriteLine("Callback function");
            Console.WriteLine(retraval);
        }, null);

            Console.WriteLine("After Display Called");
            Console.ReadLine();
        }

        static String Display(String str)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Display Called " + str);
            return str.ToUpper();
        }

    }

}



//call a function asynchronously using delegates
//call a function  with return value
//call callback function 
//bypassing delegate object as 3rd parameter in BeginInvoke function  and ar.AncyncState in callback function
namespace AsyncCodeUsingDelegates2
{

    internal class Program
    {
                                 
        static void Main2(string[] args)
        {
            Console.WriteLine("Before Display called");
            Func<String, String>  o1 = Display;



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
           
            
            Func<String, String> o1=(Func<String,String>) ar.AsyncState;
            String retraval;
            retraval = o1.EndInvoke(ar);
            Console.WriteLine(retraval);

            

        }

    }

}



