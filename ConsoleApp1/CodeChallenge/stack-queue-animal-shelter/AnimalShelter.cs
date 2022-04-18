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

        public void enqueue(string name, string type)
        {

            if (type.ToLower() != "dog" && type.ToLower() != "cat")
            {
                Console.WriteLine($"can NOT added " + name);
                return;
            }


            AnimalNode animal = new AnimalNode(name,type);
            if (front == null)
            {
                front = animal;
                rare = front;
            }
            else
            {
                rare.next = animal;
            }
            Console.WriteLine($"added " + name);
        }

        public string dequeue()
        {
            if (front == null)
                return null;
            else
            {
                string result1= front.name;
                front = front.next;

                return result1;
            }
        }
    }
}
