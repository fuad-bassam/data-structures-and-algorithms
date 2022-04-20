using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class AnimalShelter
    {
        public AnimalNode front { get; set; }
        public AnimalNode rare { get; set; }
        public List<string> acceptedAnimal = new List<string>() { "cat", "dog" };
        public void enqueue(Animal animal)
        {
          
            if (!acceptedAnimal.Contains(animal.type))
            {
                return;
            }
            AnimalNode animalNode = new AnimalNode(animal);

           
           
            if (front == null)
            {
                front = animalNode;
                rare = front;
            }
            else
            {
                rare.next = animalNode;
                rare = animalNode;
            }
            Console.WriteLine($"added " + animalNode.animal.value);
        }

        public string dequeue(string pref)
        {
            string result = null;
           AnimalNode selectedNode = front;
          
            // if the queue is empty return null
            if (selectedNode == null)
            {
                return null;
            }
            //if the frirst element is the correct node deal with it as normal Queue
            if (selectedNode.animal.type == pref.ToLower())
            {
                result = selectedNode.animal.value;
                front = front.next;
                return result; 
            }
            //if the frist element is Not the correct node, loop over items and check if the NEXT value is the correct node
            
            
            while (selectedNode.next.animal.type != pref.ToLower())
            {


                selectedNode = selectedNode.next;
                // if the result is not found in the queue
                if (selectedNode.next == null)
                    return null;
            }

            // if the last element is the correct node
            if (selectedNode.next == rare)
            {
                rare = selectedNode;
            }
            //remove the node from the queue by making the previous node not point to the correct node but to the Next node from the correct node
            result = selectedNode.next.animal.value;
            selectedNode.next = selectedNode.next.next;
         
                return result;
          
        }
    }
}
