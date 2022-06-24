using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.CodeChallenge.Graphs
{
  public  class Graphs
    {
        public List<GraphNode> listNodes = new List<GraphNode>();
        public GraphNode add(string value) {

            GraphNode newGN = new GraphNode(value);

            listNodes
                .Add(newGN);
            return newGN;
        }


        public void addEdge(GraphNode node1, GraphNode node2, int weight) {

            node1.Edges.Add(new GraphNodeEdges(node1, node2,weight));
            node2.Edges.Add(new GraphNodeEdges(node1, node2,weight));

        }
        public void addEdge(GraphNode node1, GraphNode node2)
        {
            GraphNodeEdges nodeEdge = new GraphNodeEdges(node1, node2);
            node1.Edges.Add(nodeEdge);
            node2.Edges.Add(nodeEdge);

        }



        public List<GraphNode> getNodes() {

            if (listNodes.Count == 0)
            {
                return null;
            }

            return listNodes;
        }

        public List<GraphNode> getNeighbors(GraphNode node) {

            List<GraphNode> NeighborsNode = new List<GraphNode>();

            GraphNode selectedNode = listNodes.Find(nodes => nodes == node);
            if (selectedNode == null)
            {
                return null;
            }

            foreach (GraphNodeEdges edge in selectedNode.Edges)
            {
                NeighborsNode.Add(edge.node2);
            }

            return NeighborsNode;
        }


        public int size() {
           

            return listNodes.Count;
        }
    }
}
