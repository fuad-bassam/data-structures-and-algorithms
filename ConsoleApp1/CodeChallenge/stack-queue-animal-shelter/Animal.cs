using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class AnimalNode
    {
        public string name { get; set; }

        public string type { get; set; }

        public AnimalNode next { get; set; }

        public AnimalNode(string name, string type) {

            this.name = name;
            this.type = type;
        
        }
    }
}
