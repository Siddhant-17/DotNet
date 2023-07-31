using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    internal class Program
    { 

        public  void Printtable()
        {
            lock (this)                              //this will not work with static method static variable
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread t = Thread.CurrentThread;
                    Thread.Sleep(100);
                    Console.WriteLine(t.Name + " = " + i);
                }
            }
        }

        static void Main(string[] args)
        {
            //Thread t1 = new Thread(Printtable);
            //t1.Name = "t1";
            //Thread t2 = new Thread(Printtable);
            //t2.Name = "t2";
            //t1.Start();
            //t2.Start();
            //t1.Abort();

            //Console.WriteLine("in main");
            Program program = new Program();    

            Thread t1 = new Thread(new ThreadStart(program.Printtable));
            Thread t2 = new Thread(new ThreadStart(program.Printtable));
            t1.Start();
            t2.Start(); 
        }
    }
}
