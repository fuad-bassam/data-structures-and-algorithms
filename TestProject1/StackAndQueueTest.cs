using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using ConsoleApp1;


namespace TestProject1
{
    public class StackAndQueueTest
    {
        // Class 12: stack-queue-animal-shelter

        [Fact]
        //Can successfully enqueue to AnimalShelter
        public void Class12_EnqeueuAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Cat cat = new Cat("cat1");

            animalShelter.enqueue(cat);
            Assert.Equal("cat1", animalShelter.front.animal.value) ;
        }
        [Fact]
        //Can successfully enqueue to AnimalShelter
        public void Class12_WrongEnqeueuAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Cat cat = new Cat("cat1");
            Cat cat2 = new Cat("cat2");

            animalShelter.enqueue(cat);
            animalShelter.enqueue(cat2);

            Assert.Null(animalShelter.dequeue("lion"));
        }


        [Fact]
        //Can successfully many enqueue to AnimalShelter
        public void Class12_EnqeueuMultyAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            Cat cat = new Cat("cat1");
            Cat cat2 = new Cat("cat2");
            Cat cat3 = new Cat("cat3");
            Dog dog = new Dog("dog1");


            animalShelter.enqueue(cat);
            animalShelter.enqueue(cat2);
            animalShelter.enqueue(cat3);
            animalShelter.enqueue(dog);

            Assert.Equal("cat1", animalShelter.front.animal.value);
        }
        [Fact]
        //Can successfully dequeue from AnimalShelter
        public void Class12_DeqeueuAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            Cat cat = new Cat("cat1");
            Cat cat2 = new Cat("cat2");

            animalShelter.enqueue(cat);
            animalShelter.enqueue(cat2);

            Assert.Equal("cat1", animalShelter.dequeue("cat"));
        }
        [Fact]
        //Can successfully dequeue empty AnimalShelter
        public void Class12_DeqeueuEmptyAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();

          

            Assert.Null(animalShelter.dequeue("cat"));
        }

        [Fact]
        //Can successfully many dequeue from AnimalShelter
        public void Class12_DeqeueuMultyAnimalShelter()
        {
            AnimalShelter animalShelter = new AnimalShelter();

            Cat cat = new Cat("cat1");
            Cat cat2 = new Cat("cat2");

            Cat cat3 = new Cat("cat3");
            Dog dog = new Dog("dog1");
            Cat cat4 = new Cat("cat4");
            Dog dog2 = new Dog("dog2");

            animalShelter.enqueue(cat);
            animalShelter.enqueue(cat2);
            animalShelter.enqueue(cat3);
            animalShelter.enqueue(dog);
            animalShelter.enqueue(cat4);
            animalShelter.enqueue(dog2);

            animalShelter.dequeue("cat");
            animalShelter.dequeue("dog");
            animalShelter.dequeue("cat");
            Assert.Equal("dog2", animalShelter.dequeue("dog"));
        }



        ///////////////////////

        ///Class11-PseudoQueue


        [Fact]
        //Can successfully create empty stackQueue
        public void Class11_PseudoQueueTest1()
        {
            PseudoQueue stackQueue = new PseudoQueue();

            
            Assert.Equal("Stack is empty !!", stackQueue.peek());
        }
        [Fact]
        //Can successfully dequeue empty stackQueue
        public void Class11_PseudoQueueTest2()
        {
            PseudoQueue stackQueue = new PseudoQueue();


            Assert.Equal("Stack is empty !!", stackQueue.dequeue());
        }
        [Fact]
        //Can successfully work enqueue in stackQueue
        public void Class11_Enqueue_PseudoQueueTest()
        {
            PseudoQueue stackQueue = new PseudoQueue();
            stackQueue.enqueue("a");
            stackQueue.enqueue("b");
            stackQueue.enqueue("c");

            Assert.Equal("a", stackQueue.peek());
        }
        [Fact]
        //Can successfully work dequeue in stackQueue
        public void Class11_Dequeue_PseudoQueueTest()
        {
            PseudoQueue stackQueue = new PseudoQueue();
            stackQueue.enqueue("a");
            stackQueue.enqueue("b");
            stackQueue.enqueue("c");

            Assert.Equal("a", stackQueue.dequeue());
        }

        [Fact]
        //Can successfully work dequeue in stackQueue
        public void Class11_Dequeue_PseudoQueueTest2()
        {
            PseudoQueue stackQueue = new PseudoQueue();
            stackQueue.enqueue("a");
            stackQueue.enqueue("b");
            stackQueue.enqueue("c");
            stackQueue.dequeue();
            Assert.Equal("b", stackQueue.peek());
        }







        //Class 10: Stack And Queue

        [Fact]
        //Can successfully push onto a stack
        public void Class10_PushStackTest()
        {
            Stack stack = new Stack();

            stack.push("a");

            Assert.Equal("a", stack.peek());
        }

        [Fact]
        // Can successfully push multiple values onto a stack
        public void Class10_PushMultipleStackTest()
        {
            Stack stack = new Stack();

            string [] arr = new string[] {"a","b","c","d" };
            string result1=null;

            foreach (string x in arr)
            {
                stack.push(x);
               result1 += stack.peek();

            }

       

            Assert.Equal("abcd", result1);

        }


        [Fact]
        // Can successfully pop off the stack
        public void Class10_PopStackTest()
        {
            Stack stack = new Stack();

            stack.push("a");
            stack.push("b");

            Assert.Equal("b", stack.pop());

        }

        [Fact]
        // Can successfully empty a stack after multiple pops
        public void Class10_EmptyPopStackTest()
        {
            Stack stack = new Stack();

            stack.push("a");
            stack.pop();

            Assert.Equal("Stack is empty !!", stack.pop());

        }

        [Fact]
        // Can successfully peek the next item on the stack
        public void Class10_PeekStackTest()
        {
            Stack stack = new Stack();

            stack.push("a");
            stack.push("b");

            Assert.Equal("b", stack.peek());

        }
        [Fact]
        // Can successfully instantiate an empty stack
        public void Class10_EmptyStackTest()
        {
            Stack stack = new Stack();


            Assert.IsType<Stack>(stack);


        }
        [Fact]
        // Calling pop or peek on empty stack raises exception
        public void Class10_CallEmptyStackTest()
        {
            Stack stack = new Stack();



            Assert.Equal("Stack is empty !!", stack.pop());

        }

        [Fact]
        // Can successfully enqueue into a queue
        public void Class10_EnqueueQueueTest()
        {
            Queue queue = new Queue();
            queue.enqueue("a");
            Assert.Equal("a", queue.peek());

        }


        [Fact]       
        // Can successfully enqueue multiple values into a queue
        public void Class10_EnqueueMultipleQueueTest()
        {
            Queue queue = new Queue();

            string[] arr = new string[] { "a", "b", "c", "d" };
            string result1 = null;

            foreach (string x in arr)
            {
                queue.enqueue(x);
                result1 += queue.peek();

            }



            Assert.Equal("aaaa", result1);

        }

       

        [Fact]
        // Can successfully dequeue out of a queue the expected value
        public void Class10_DequeueQueueTest()
        {
            Queue queue = new Queue();
            queue.enqueue("a");
            queue.enqueue("b");
            queue.enqueue("c");

            Assert.Equal("a",queue.dequeue());
        }

        [Fact]
        // Can successfully peek into a queue, seeing the expected value
        public void Class10_PeekQueueTest()
        {
            Queue queue = new Queue();
            queue.enqueue("a");
            queue.enqueue("b");
            queue.enqueue("c");

            Assert.Equal("a", queue.peek());
        }

        [Fact]
        // Can successfully empty a queue after multiple dequeues
        public void Class10_EmptyQueueTest()
        {
            Queue queue = new Queue();
            queue.enqueue("a");
            queue.dequeue();


            Assert.Equal("Queue is empty !!", queue.peek());


        }

        [Fact]
        // Can successfully instantiate an empty queue
        public void Class10_InstantiateEmptyQueueTest()
        {
            Queue queue = new Queue();
           


            Assert.IsType<Queue>(queue);

        }

        [Fact]
        // Calling dequeue or peek on empty queue raises exception
        public void Class10_PeekEmptyQueueTest()
        {
            Queue queue = new Queue();

            Assert.Equal("Queue is empty !!", queue.peek());

        }

    }
}
