using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
             C_Sort obj = new C_Sort(); //object creation
            obj.Sort();                // calling function of class C_Sort
        }
    }
    public class C_Sort    // class created to implement Cocktail Sort
    {
        public C_Sort()
        {
        }
        public void Sort()
        {
            Console.WriteLine("Enter num of elements to be stored in array");
            int n = int.Parse(Console.ReadLine()); // stores num of elements
            int[] a = new int[n];
            Console.WriteLine("Enter elements to store in array and sort");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());     // storing elements in array
            }

            bool swapped = true;
            int start = 0;
            int end = a.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)    // looping from left to right
                {
                    if (a[i] > a[i + 1])                //  checking if element at left is greater than element at right
                    {
                        int temp = a[i];           // if yes then swap
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end = end - 1;                 // reducing one index


                for (int i = end - 1; i >= start; i--)      /// looping form right to left
                {
                    if (a[i] > a[i + 1])           //  checking if element at right is greater than element at left
                    {
                        int temp = a[i];          // if yes then swap
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);                 // printing the sorted array

            }

        }
    }
}
