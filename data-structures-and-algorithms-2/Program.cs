namespace data_structures_and_algorithms_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            Node node1 = new Node("A");
            Node node2 = new Node("B");
            Node node3 = new Node("C");
            Node node4 = new Node("D");
            Node node5 = new Node("E");


            graph.AddNode(node1.value);
            graph.AddNode(node2.value);
            graph.AddNode(node3.value);
            graph.AddNode(node4.value);
            graph.AddNode(node5.value);

            graph.AddEdge(node3, node2, 5);
            graph.AddEdge(node4, node3, 7);
            graph.AddEdge(node5, node3, 9);
            graph.AddEdge(node1, node2, 2);

            foreach (var item in graph.GetNodes())
            {
                Console.WriteLine(item.value);
            }
            string s = "";
            foreach (var item in graph.GetNeighbors(node3))
            {
                s += item.Node.value + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine(graph.Size());
            foreach (var item in graph.BreadthFirst(node3))
            {
                Console.WriteLine(item.value);
            }

            Console.WriteLine(Graph.BusinessTrip(graph, new string[] { "A", "E" }));
        }
    }
}