using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.codeCha
{
    class Class1
    {



        /////////array-reverse challenge
        //public static int[] reverseArray(int[] arr)
        //{
        //    int[] arr2 = new int[arr.Length];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr2[i] = arr[arr.Length - i - 1];
        //        Console.WriteLine(arr2[i]);
        //    }

        //    return arr2;

        //}

        //public static void showArray(int[] arr)
        //{

        //    Console.WriteLine("the result is :-");

        //    foreach (int item in arr)
        //    {

        //        Console.Write(item + " , ");
        //    }

        //}


        ////ReversArray
        public static String[] ReversArray(string[] arr)
        {
            string[] arr2 = new String [arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - i -1];
            }

            return arr2;

        }

        ////output array element to console
        public static void ShowArray(String[] arr)
        {
            Console.Write(" Result array =  { ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.Write(" } ");
        }


    }
}
