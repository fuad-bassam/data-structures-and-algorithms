using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public  class Code_Challenge_Class07
    {


        [Fact]
        // test Where k is greater than the length of the linked list
        public void Class07_Test_KIsGreater()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

             Assert.Equal("ERROR, the selected number is NOT ok", test3.kthFromEnd(12));

          
        }


        [Fact]
        // test Where k and the length of the list are the same
        public void Class07_Test_KEeualListLength()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");

            Assert.Equal("7", test3.kthFromEnd(5));


        }


        [Fact]
        // test Where k is not a positive integer
        public void Class07_Test_KNotpos()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("2");
            test3.insert("3");
            test3.insert("4");
            test3.insert("5");
            test3.insert("6");
            test3.insert("7");


            Assert.Equal("ERROR, the selected number is NOT ok", test3.kthFromEnd(-1));



        }

        [Fact]
        // test Where the linked list is of a size 1
        public void Class07_Test_listOf1node()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("a");
           


            Assert.Equal("a", test3.kthFromEnd(0));



        }


        [Fact]
        // test Happy Path where k is not at the end, but somewhere in the middle of the linked list
        public void Class07_Test_HappyPath()
        {
            LinkedList test3 = new LinkedList();
            test3.insert("a");
            test3.insert("b");
            test3.insert("c");
            test3.insert("d");
            test3.insert("e");
            test3.insert("f");


            Assert.Equal("d", test3.kthFromEnd(3));



        }




    }
}
