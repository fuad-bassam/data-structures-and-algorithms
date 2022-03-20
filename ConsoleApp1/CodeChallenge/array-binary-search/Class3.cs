using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.codeCha
{

    class Class3
    {

        // for calculate the equation for middle
        public static int EquationForMid(int start, int end)
        {
            int mid = (start + end) / 2;

            return mid;
        }
        public static int BinarySearch(int[] arr
         , int inputNum)
        {
            int start = 0, end = (arr.Length-1);
            int mid = EquationForMid(start, end);

            if (arr[start] > inputNum ||
             inputNum > arr[end])
                return -1;


            while (arr[mid] != inputNum)
            {
                if (arr[mid] > inputNum)
                {
                    end = mid;
                    mid = EquationForMid(start, end);
                }
                else if (start == mid || end == mid)
                    return -1;
                //this is the else (arr [mid] < inputNumber)
                else
                {
                    start = mid;
                    mid = EquationForMid(start, end);
                }
            }

            return mid;

        }

        ///////// sort function
        public static int[] SortArray(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = i; j < arr.Length; j++)
                    if (min> arr[j])
                    {
                        min = arr[j];
                        arr[j] = arr[i];
                        arr[i] = min;
                    }
               
              
                
            }



            foreach (int item in arr)
            {
                Console.Write(item);
            }

            return arr;
        }



    }
}
