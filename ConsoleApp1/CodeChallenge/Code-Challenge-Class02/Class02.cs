using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class02
    {


        ///// find middle of array function
        public static int findMiddleOfArray(int[] arr)
        {
            int mid = 0;


            //// find the middle of the the given array.
            // we can use   Math.Round for this step.
            if (arr.Length % 2 == 0)
            {
                mid = arr.Length / 2;
            }
            else
            {

                mid = (arr.Length / 2) + 1;

            }


            return mid;
        }

        ///// insert in the middle of Array function
        public static int[] insertShiftArray(int[] arr, int addNumber)
        {

            int[] arr2 = new int[arr.Length + 1];




            int mid = findMiddleOfArray(arr);

            //// fill the data from the first array and the number that e want to add in the middle into second array.

            int j = 0;

            for (int i = 0; i < arr2.Length; i++)
            {



                if (i == mid)
                {
                    arr2[i] = addNumber;

                }
                else
                {
                    arr2[i] = arr[j];

                    j++;

                }


            }
            return arr2;
        }

        ///// delete  in the middle of Array function
        public static int[] deleteShiftArray(int[] arr)
        {


            int[] arr2 = new int[arr.Length - 1];

            int mid = findMiddleOfArray(arr2);

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (i != mid)
                {
                    arr2[j] = arr[i];

                    j++;

                }

            }

            return arr2;

        }
    }

}

