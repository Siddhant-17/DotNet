using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 3];//row column rc   2D
            int[,,] arr1 = new int[4,3,2];//   3D

            //stored marks for 5 student ,3 subject marks
            int[,] arr2 = new int[5, 3];

            //property
            Console.WriteLine(arr2.Length); //15
            Console.WriteLine(arr2.Rank);  //no of dimention
            Console.WriteLine(arr2.GetLength(0));  //5
            Console.WriteLine(arr2.GetLength(1));  //3
            Console.WriteLine(arr2.GetUpperBound(0));  // first dimention 5  so return 5-1=4
            Console.WriteLine(arr2.GetUpperBound(1));  // second dimention 3  so return 3-1=2


            //accept element
            for(int i=0;i<arr2.GetLength(0);i++)
            {
                for(int j=0;j<arr2.GetLength(1);j++)
                {
                    Console.WriteLine("Enter element at index arr2[{0},{1}] ",i,j);
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //display
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine("arr[{0},{1}]:{2} ", i, j, arr2[i,j]);
                   
                }
            }

            //display by foreach loop
            foreach(int i in arr2)
            {
                Console.WriteLine(i);
            }




        }
    }
}
