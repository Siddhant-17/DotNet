using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class OneDArray
    {
        static void Main(string[] args)
        {
            //declaration of array
            int[] arr = new int[5];

            //property of array
            Console.WriteLine( "length fo arr:"+arr.Length);

            //accept array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter element at index {0} :",i);
                arr[i] = int.Parse(Console.ReadLine());
            }



            //Display array
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("element at index arr[{0}]:{1} ", i, arr[i]);
            }

            //reverse array
            arr.Reverse();


            //display by for each loop
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }

            int[]brr = new int[5];

            Console.WriteLine(Array.IndexOf(arr, 32));   //return index of 32 if present else return -1  and if  2 same element then rerturn index of 1st occured
            Console.WriteLine(Array.LastIndexOf(arr,2)); //return index of 2 from last element   4
            Array.BinarySearch(arr, 32);//  for this array should be sorted
            
            Array.Copy(arr, brr, 2);//copy element from source array to destintion array and no of element
                                    //in copy method suppose we copying 12 element from arr to brr and if problem occure at 10 element
                                    // then thoes 10 element are add but last two not add

            Array.ConstrainedCopy(arr, 0, brr, 0, 4);
            //if problem ocuurece at 4 th element then rollback like transaction in hibernate

            int[] arr1 = new int[0]; //in some language this is not allowed so next method is used
            //Array.CreateInstance();

            Array.Reverse(arr);//reverse array

            Array.Sort(arr);//sort arry by default accending if want to desc sort then reverse

            Array.Clear(arr, 0, 3);//delete element from inted to index

           
        }
    }
}
