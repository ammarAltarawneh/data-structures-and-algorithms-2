using data_structures_and_algorithms_2;

namespace data_structures_and_algorithms_Test
{
    public class UnitTest1
    {
        //[Fact]
        //public void TestGraphAddNode()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("45");

        //    Assert.NotNull(graph.GetNodes());
        //}

        //[Fact]
        //public void TestGraphAddEdge()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("45");
        //    graph.AddNode("22");

        //    Node node1 = new Node("45");
        //    Node node2 = new Node("22");
        //    graph.AddEdge(node1, node2);

        //    Assert.NotNull(graph.GetNeighbors(node1));
        //}

        //[Fact]
        //public void TestGraphGetNodes()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("45");
        //    graph.AddNode("22");

        //    List<string> test = new List<string>();
        //    test.Add("45");
        //    test.Add("22");

        //    List<string> nodesValues = new List<string>();
        //    foreach (var item in graph.GetNodes())
        //        nodesValues.Add(item.value);

        //    Assert.Equal(test, nodesValues);
        //}

        //[Fact]
        //public void TestGraphGetNeighbors()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("A");
        //    graph.AddNode("B");
        //    graph.AddNode("C");
        //    graph.AddNode("D");
        //    graph.AddNode("E");

        //    Node node1 = new Node("A");
        //    Node node2 = new Node("E");
        //    Node node3 = new Node("C");
        //    Node node4 = new Node("D");


        //    graph.AddEdge(node1, node2);
        //    graph.AddEdge(node3, node1);
        //    graph.AddEdge(node4, node1);

        //    List<Node> result = new List<Node>();
        //    result.Add(node2);
        //    result.Add(node3);
        //    result.Add(node4);

        //    Assert.Equal(result, graph.GetNeighbors(node1));
        //}

        //[Fact]
        //public void TestGraphSize()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("45");
        //    graph.AddNode("22");
        //    graph.AddNode("7");

        //    Assert.Equal(3, graph.Size());
        //}

        //[Fact]
        //public void TestGraphNodeEdge()
        //{
        //    Graph graph = new Graph();
        //    graph.AddNode("A");

        //    Node node = new Node("A");
        //    graph.AddEdge(node, node);

        //    Assert.NotNull(graph.GetNodes());
        //    Assert.Null(graph.GetNeighbors(node));
        //}

        //[Fact]
        //public void TestGraphNull()
        //{
        //    Graph graph = new Graph();

        //    Assert.Null(graph.GetNodes());
        //}
        [Fact]
        public void AddNode_ShouldAddNodeToGraph()
        {
            // Arrange
            Graph graph = new Graph();

            // Act
            Node node = graph.AddNode("A");

            // Assert
            Assert.NotNull(node);
            Assert.Equal("A", node.value);
            Assert.Contains(node, graph.GetNodes());
        }

        [Fact]
        public void AddEdge_ShouldAddEdgeBetweenNodes()
        {
            // Arrange
            Graph graph = new Graph();
            Node nodeA = graph.AddNode("A");
            Node nodeB = graph.AddNode("B");

            // Act
            graph.AddEdge(nodeA, nodeB, 1);

            // Assert
            var neighborsA = graph.GetNeighbors(nodeA);
            var neighborsB = graph.GetNeighbors(nodeB);

            Assert.Contains(neighborsB, edge => edge.Node == nodeA && edge.Weight == 1);
            Assert.Contains(neighborsA, edge => edge.Node == nodeB && edge.Weight == 1);
        }

        [Fact]
        public void DepthFirst_ShouldReturnCorrectTraversalOrder()
        {
            // Arrange
            Graph graph = new Graph();
            Node nodeA = graph.AddNode("A");
            Node nodeB = graph.AddNode("B");
            Node nodeC = graph.AddNode("C");
            Node nodeD = graph.AddNode("D");

            graph.AddEdge(nodeA, nodeB, 1);
            graph.AddEdge(nodeB, nodeC, 1);
            graph.AddEdge(nodeC, nodeD, 1);

            // Act
            var dfsResult = graph.DepthFirst(nodeA);

            // Assert
            Assert.Collection(dfsResult,
                node => Assert.Equal("A", node.value),
                node => Assert.Equal("B", node.value),
                node => Assert.Equal("C", node.value),
                node => Assert.Equal("D", node.value));
        }
    }
}