using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using Xunit;
using CodeChallenge.CodeChallenge.Graphs;
namespace TestProject1
{
   public class GraphsTest
    {



        // class37 : graph-business-trip
        [Fact]
        // test resut 1

        public void Class37_test1()
        {
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("amman");
            GraphNode node2 = graphs.add("zarqa");
            GraphNode node3 = graphs.add("irbed");
            GraphNode node4 = graphs.add("aqaba");
            graphs.addEdge(node1, node2, 10);
            graphs.addEdge(node2, node2, 3);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node3, node4, 20);
            graphs.addEdge(node2, node3, 15);
            graphs.addEdge(node1, node3, 4);

            string[] trip = { "amman", "zarqa", "irbed", "aqaba" };

            Assert.Equal(45, Program. businesstrip(graphs, trip));


        }
        [Fact]
        // test resut 2

        public void Class37_test2()
        {
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("amman");
            GraphNode node2 = graphs.add("zarqa");
            GraphNode node3 = graphs.add("irbed");
            GraphNode node4 = graphs.add("aqaba");
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node2, node2, 3);
            graphs.addEdge(node2, node4, 100);
            graphs.addEdge(node4, node3, 150);
            graphs.addEdge(node1, node2, 4);

            string[] trip = { "amman", "zarqa", "aqaba" , "irbed" };

            Assert.Equal(254, Program.businesstrip(graphs, trip));


        }
        [Fact]
        // test if there is no way between to city

        public void Class37_test3()
        {
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("amman");
            GraphNode node2 = graphs.add("zarqa");
            GraphNode node3 = graphs.add("irbed");
            GraphNode node4 = graphs.add("aqaba");
            graphs.addEdge(node1, node2, 10);
            graphs.addEdge(node2, node2, 3);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node3, node4, 20);
            graphs.addEdge(node2, node3, 15);
            graphs.addEdge(node1, node3, 4);

            string[] trip = { "amman", "aqaba", "zarqa", "irbed"  };

            Assert.Null( Program.businesstrip(graphs, trip));


        }
       



        //// class36 : graph-breadth-first
        [Fact]
        // test breadthfirst graph from one node

        public void Class36_test1()
        {

            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode[] arrNodes = graphs.breadthfirst();
            Assert.Equal(new GraphNode[] { node1 }, arrNodes);

        }
        [Fact]
        // test can be successfully breadthfirst the graph

        public void Class36_test2()
        {
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            GraphNode node4 = graphs.add("20");
            graphs.addEdge(node1, node2, 5);
            graphs.addEdge(node2, node2, 3);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node3, node4, 8);
            graphs.addEdge(node1, node2, 5);
            graphs.addEdge(node2, node2, 3);
            graphs.addEdge(node1, node3, 4);
            graphs.addEdge(node3, node4, 8);

            GraphNode[] arrNodes = graphs.breadthfirst();
            Assert.Equal(new GraphNode[] { node1, node2, node3, node4 }, arrNodes);


        }

        [Fact]
        // test the order of breadthfirst result in the graph


        public void Class36_test3()
        {
            Graphs graphs = new Graphs();

            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            GraphNode node4 = graphs.add("20");
            graphs.addEdge(node1, node3, 5);
            graphs.addEdge(node3, node2, 3);
            graphs.addEdge(node2, node4, 4);


            GraphNode[] arrNodes = graphs.breadthfirst();
            Assert.Equal(new GraphNode[] { node1, node3, node2, node4 }, arrNodes);

        }


        ///Class 35: Graphs
        [Fact]
        // test  Node can be successfully added to the graph

        public void Class35_test1()
        {

            Graphs graphs = new Graphs();


            GraphNode node1= graphs.add("5");
            Assert.Equal("5",node1.value);

        }
        [Fact]
        // test  An edge can be successfully added to the graph

        public void Class35_test2()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            graphs.addEdge(node1,node2);
            Assert.Equal<GraphNode>(node2, node1.Edges[0].node2);

        }

        [Fact]
        // test  A collection of all nodes can be properly retrieved from the graph


        public void Class35_test3()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");

            List<GraphNode> listtest = new List<GraphNode>{ node1, node2, node3 };
            Assert.Equal<List<GraphNode>>(listtest, graphs.getNodes());

        }
        [Fact]
        // test  All appropriate neighbors can be retrieved from the graph

        public void Class35_test4()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            GraphNode node4 = graphs.add("20");
            graphs.addEdge(node1, node2);
            graphs.addEdge(node2, node2);
            graphs.addEdge(node1, node3);
            graphs.addEdge(node3, node4);

            List<GraphNode> listtest = new List<GraphNode> {  node2, node3 };
            Assert.Equal<List<GraphNode>>(listtest, graphs.getNeighbors(node1));

        }
        [Fact]
        // test  Neighbors are returned with the weight between nodes included

        public void Class35_test5()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            GraphNode node4 = graphs.add("20");
            graphs.addEdge(node1, node2,5);
            graphs.addEdge(node2, node2,3);
            graphs.addEdge(node1, node3,4);
            graphs.addEdge(node3, node4,8   );

            Assert.Equal(5, node1.Edges.FirstOrDefault(x=>x.node2 == node2).edgeWeight);


        }
        [Fact]
        // test  The proper size is returned, representing the number of nodes in the graph

        public void Class35_test6()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = graphs.add("10");
            GraphNode node3 = graphs.add("15");
            GraphNode node4 = graphs.add("20");
            graphs.addEdge(node1, node2);
            graphs.addEdge(node2, node2);
            graphs.addEdge(node1, node3);
            graphs.addEdge(node3, node4);

            Assert.Equal(4, graphs.size());

        }
        [Fact]
        // test  A graph with only one node and edge can be properly returned

        public void Class35_test7()
        {
            Graphs graphs = new Graphs();


            GraphNode node1 = graphs.add("5");
            GraphNode node2 = new GraphNode("4");
            graphs.addEdge(node1, node2);

            List<GraphNode> listtest = new List<GraphNode> { node1 };
            Assert.Equal<List<GraphNode>>(listtest, graphs.listNodes);

        }
        [Fact]
        // test  An empty graph properly returns null


        public void Class35_test8()
        {
            Graphs graphs = new Graphs();


            Assert.Null( graphs.getNodes());

        }
    }
}
