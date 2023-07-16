using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 4 student  each student have array of marks diff  no  of subject
           //if we want to store marks of min max subject diff diff for seperate student
            int[][] arr = new int[4][];
            arr[0] = new int[3];
            arr[1] = new int[2];
            arr[2] = new int[1];
            arr[3] = new int[5];

            Console.WriteLine(arr.Length);//4
            Console.WriteLine(arr[2].GetLength(0));

            //accept array elements
            for(int i=0;i<arr.Length;i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.WriteLine("enter element of index arr[{0},{1}]:",i,j);
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }



            //display array
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("enter element of index arr[{0},{1}]:{2}", i, j, arr[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
