using System;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class ProgramTest
    {

        /// class26: Merge Sort

        [Fact]
        /// test it in happy case 1
        public void Class27_test1()
        {

            int[] arr = { 2, 4, 3, 6, 1, 5 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 2
        public void Class27_test2()
        {

            int[] arr = { 2, 4, 3, -1, 6, 1, 3, 5 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { -1, 1, 2, 3, 3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 3
        public void Class27_test3()
        {

            int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 4
        public void Class27_test4()
        {

            int[] arr = { -2, 50, -30, 1, 14, 1, 35, -14 };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { -30, -14, -2, 1, 1, 14, 35, 50 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test if the array is empty
        public void Class27_ifNullarr()
        {

            int[] arr = { };

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test have one value
        public void Class27_OneValue()
        {

            int[] arr = { 1};

            int[] arr2 = Program.MergeSort(arr);
            int[] test = { 1 };
            Assert.Equal(test, arr2);
        }






        /// class26: InsertionSort

        [Fact]
        /// test it in happy case 1
        public void Class26_test1()
        {

            int[] arr = { 2, 4, 3, 6, 1, 5 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(test,arr2);
        }
        [Fact]
        /// test it in happy case 2
        public void Class26_test2()
        {

            int[] arr = { 2, 4, 3,-1, 6, 1,3, 5 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = {-1, 1, 2, 3,3, 4, 5, 6 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 3
        public void Class26_test3()
        {

            int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 4
        public void Class26_test4()
        {

            int[] arr = { -2, 50, -30, 1, 14, 1, 35, -14 };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { -30, -14, -2, 1, 1, 14, 35, 50 };
            Assert.Equal(test, arr2);
        }
        [Fact]
        /// test it in happy case 1
        public void Class26_ifNullarr()
        {

            int[] arr = { };

            int[] arr2 = Program.InsertionSort(arr);
            int[] test = { };
            Assert.Equal(test, arr2);
        }


        ///Class 13: stack-queue-brackets
        [Fact]

        public void Class13_test1()
        {
            String x = "[x]";

            Assert.True(Program.validateBrackets(x));
        }
        [Fact]
     
        public void Class13_test2()
        {

            String x = "[][]{}";

            Assert.True(Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test3()
        {

            String x = "{s]";

            Assert.True(!Program.validateBrackets(x));

        }

        [Fact]
        public void Class13_test4()
        {


            String x = "{[(z)]}";

            Assert.True(Program.validateBrackets(x));

        }
        /////////

    }
}