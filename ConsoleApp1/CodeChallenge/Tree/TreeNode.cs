using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// this class Node for Class 17: tree-breadth-first
    /// </summary>
    public class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> children = new List<TreeNode>();

        public TreeNode(int value)
        {
            this.Value = value;

        }
        //public void Addchildren(TreeNode treeNode) {
        //    children.Add(treeNode);
        //}
    }
}
