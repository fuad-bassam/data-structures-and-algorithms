using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class K_aryTNode
    {
        public string Value { get; set; }

        
        public List<K_aryTNode> Children = new List<K_aryTNode>();

        public K_aryTNode()
        {

        }
        public K_aryTNode(string value)
        {
            this.Value = value;
        }

        public void addChildren(K_aryTNode child) {

            Children.Add(child);
        }
    }
}
