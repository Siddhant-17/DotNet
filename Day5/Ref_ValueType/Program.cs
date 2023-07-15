using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ref_ValueType
{
    internal class Program
    {
        //in this example we just pass values to swap function ;
        static void Main1(string[] args)
        {
            int i = 10;
            int j = 20;

            Swap(i, j);
            Console.WriteLine(i);
            Console.WriteLine(j);


            void Swap(int a,int b)
            {
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }

            /*
             * Here when we call swap function and pass 2 variables i,j  as  a,b
             * int swap function value are swap but 
             * after call they not swap actually
             */
        }


        //in this example we pass value type as reference by using keyword ref;
        static void Main2()
        {

            /*
             * now here if we assigning i and j inside Init method then why we are assigning here also
             * bcause here i and j are local variable and  local variable  does not get default value
             * only variable inside class will get defualt value
             * if we not assinged here then it will give complie error
             */
            int i = 10;
            int j = 20;
            Console.WriteLine("before initiate  i :"+ i);
            Console.WriteLine("before initiate  j :" + j);
            Console.WriteLine("--------------------------------------------------");
            //here we pass value type as reference type
            Init(ref i, ref j);
            
            Console.WriteLine("after initiate  i :" + i);
            Console.WriteLine("after initiate j :" + j);


            void Init(ref int a,ref int b)
            {
                a = 100;
                b = 101;

            }


            // so if we are using ref then value must be intiate first
        }



        //if we dont want to initiate first i and j in main function 
        static void Main3()
        {
            int i;
            int j;
            int k = 67;

            //Console.WriteLine("before Init method i:"+i); error use unassignd variable
            //Init(i, j);                                   error use unassignd variable
            /*
             * if we dont want to assigned value here and want to assigned in init method 
             * then use  out  
             */
            Init(out i, out j,out k);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);


            void Init(out int a,out int b ,out int c)
            {
                // if c is already intiate first but also if it is out then it is consider as intiate
               // Console.WriteLine(c);   //error becuase if it is out parameter then in this method it is not consider as initiate 
               
                
               //if we not initiated i and j  's value then it will gicve error
               //both  must be  assigned
                a = 17;
                b = 45;
                c = 77;
            }

        }



        // [ in ]  keyword is readonly means when int i it need to be intialized
        static void Main()
        {
            int i = 12;
            int j = 34;
            Init(in i, in j);

            void Init(in int a, in int b)
            {
                //.a = 43;   in int a  is readonly 
                //b = 44;

                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }

    }
}
