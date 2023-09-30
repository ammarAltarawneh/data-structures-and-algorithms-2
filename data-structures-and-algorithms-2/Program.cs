namespace data_structures_and_algorithms_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            graph.AddEdge(new Node("C"), new Node("G"));
            graph.AddEdge(new Node("D"), new Node("C"));
            graph.AddEdge(new Node("E"), new Node("C"));
            graph.AddEdge(new Node("A"), new Node("G"));

            foreach (var item in graph.GetNodes())
            {
                Console.WriteLine(item.value);
            }
            string s = "";
            foreach (var item in graph.GetNeighbors(new Node("C")))
            {
                s += item.value + ", ";
            }
            Console.WriteLine(s);
            Console.WriteLine(graph.Size());
        }
    }
}