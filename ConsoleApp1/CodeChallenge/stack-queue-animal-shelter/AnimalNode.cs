using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class AnimalNode
    {
        public Animal animal { get; set; }

        public AnimalNode next { get; set; }

        public AnimalNode(Animal animal) {

            this.animal = animal;
        }
    }
}
