using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colllection_Non_Generics_
{
    internal class Program
    {

        //In  Non-Generics Collection Boxing UnBoxing is done because all accept and return in term of Object  (and we add int)

        //ICollection --- IList  interface
        //ArrayList
        static void Main1(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);       //add object in list
            arr.Add("sid");
            arr.Add(2.3);
            arr.Add(true);

            Console.WriteLine(arr.Count); //return no of elements in arraylist

            arr.Remove(1);          //delete element from List 
            arr.RemoveAt(1);        //delete element from given index
            arr.RemoveRange(0, 2);  //deleting element from index to given index

            arr.Clear();            //delete all element from list
            arr.IndexOf("sid");       //return index of givrn object if present in list if not found return -1
            arr.Insert(2, "rutu");     //add object at particular index
            arr.Contains(2.3);        //if passed object is present in list it return true
            arr.GetRange(1, 5);         //return arraylist of elements from arr from index 1 to index 5
            arr.Reverse();               //reverse the list
            
            ArrayList brr = new ArrayList();
            arr.InsertRange(1, brr);        //insert range take two parameter one is index second collection which are implements ICollection interface

            arr.AddRange(brr);  //add elements from brr into arr and end of last element of arraylist arr 
            
            arr.LastIndexOf(2);    //return index of  given object from last means if 2 exist 2 times then 2nd time
            Object [] a=arr.ToArray();          //copies the object elements from arr and return object array
            Console.WriteLine(arr[0]);            //give element ot 0 index
            arr.Capacity = 10;                     //it first allocatate memory for 10 element extra
            arr.TrimToSize();           //if thoes 10 index not fill then we will trim extra index by this

            
        }


        //ICollection interface
        //Stack   class
        static void Main2()
        {
            Stack st = new Stack();

            st.Push("sid");     //add object into stack
            st.Push(2);
            st.Push(7.3);

            st.Pop();          //remove and return top element from stack
            
            st.Peek();             //only return top element from stack
            st.Contains(2);
            Console.WriteLine(st.Count);  //no of elements in stack
            st.ToArray();                    //copies the object elements from arr and return object array
            
        }


        //ICollection Interface 
        //Queue
        static void Main3()
        {
            Queue q = new Queue();
            q.Enqueue(12);  //insert given object
            q.Dequeue();     //Delete  element and return   FIFO
            q.Peek();    //return  bigining element
        }


        //ICollection --- IDictionary    interface
        //Hashtable 
        static void Main4()
        {
            Hashtable ht = new Hashtable();
            ht.Add(12,"sid"); //IDictonary implemented class stored elements in Key Value pair
            ht.Add(2, "sid");           //key cant be repeat
            ht.Add(11, "sid");           //value can be repeat


            ht[54] = "rutu";             //same like add [54] key  value      //IF key already present then override
            


           //display
           //each Key:valiue   pair in .. is called DictionaryEntry
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item);
            }


            ht.Remove(12);     //by giving key delete entry
            ArrayList a= (ArrayList) ht.Keys;          //return all keys
            ArrayList a1 = (ArrayList)ht.Values;          //return all values
            

        }


        //difference between SortedList and HashTable is only sortedList access element in sorted manner
        //SortedList
        static void Main5()
        {
            SortedList ht = new SortedList();

            ht.Add(12, "sid"); //IDictonary implemented class stored elements in Key Value pair
            ht.Add(2, "sid");           //key cant be repeat
            ht.Add(11, "sid");           //value can be repeat


            ht[54] = "rutu";             //same like add [54] key  value      //IF key already present then override



            //display
            //each Key:valiue   pair in .. is called DictionaryEntry
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item);
            }


            ht.Remove(12);     //by giving key delete entry
            ArrayList a = (ArrayList)ht.Keys;          //return all keys
            ArrayList a1 = (ArrayList)ht.Values;          //return all values

        }

    }


}
