using System;

using Xunit;
using ConsoleApp1;

namespace TestProject1
{
    public class UnitTest1
    {
        
        
        ///Class 05: Linked List Implementation
        [Fact]
        // test  if Can successfully instantiate an empty linked list and  if Can properly insert into the linked list
        public void Class05_test1_createAndInsert()
        {
            LinkedList test = new LinkedList();
            test.Insert(4);
            Assert.True(test.Indicates(4));

        }




        [Fact]
        // test Will return true when finding a value within the linked list that exists 
        public void Class05_test_IndicatesReturn1()
        {
            LinkedList test2 = new LinkedList(3);
            test2.Insert(4);
            test2.Insert(5);
            test2.Insert(6);
            test2.Insert(7);
            test2.Insert(8);

            Assert.True(test2.Indicates(4));

        }

        [Fact]
        // if Will return false when searching for a value in the linked list that does not exist
        public void Class05_test_IndicatesReturn2()
        {
            LinkedList test3 = new LinkedList(3);
            test3.Insert(4);


            Assert.True(!test3.Indicates(12));

        }


    }
}
