using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.CodeChallenge.Graphs
{
    public class GraphNode 
    {
        public string  value{ get; set; }
        public List<GraphNodeEdges> Edges = new List<GraphNodeEdges>();

        public GraphNode(string val)
        {
            value = val;
        }

        public GraphNode(string val , GraphNode node1 , GraphNode node2)
        {
            value = val;
            Edges.Add(new GraphNodeEdges(node1, node2));
        }

        public void addEdge(GraphNode node1, GraphNode node2, int weight) { 
        
            
        }
        public void addEdge(GraphNode node1, GraphNode node2)
        {

        }
    }

   public class GraphNodeEdges
   {
        public GraphNode node1 { get; set; }
        public GraphNode node2 { get; set; }
        public int edgeWeight { get; set; }

        public GraphNodeEdges(GraphNode node11, GraphNode node22)
        {
            node1 = node11;
            node2 = node22;
        }
        public GraphNodeEdges(GraphNode node11, GraphNode node22 , int weight)
        {
            node1 = node11;
            node2 = node22;
            edgeWeight = weight;
        }

    }

}
