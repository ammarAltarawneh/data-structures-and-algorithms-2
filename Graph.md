# Graphs
### Introduction
A graph is a non-linear data structure that can be looked at as a collection of vertices (or nodes) potentially connected by line segments named edges.

### Challenge
Implement a Graph Class with the following methods: {AddNode, AddEdge, GetNodes, GetNeighbors and size}

### Approach & Efficiency
* Time complexity for AddNode and Size methods are O(1).

* Time complexity for AddEdge , GetNodes and GetNeighbors methods are O(n).

### API
1- add node.
Arguments: value, Returns: The added node
Add a node to the graph

2- add edge.
Arguments: 2 nodes, Returns: nothing
Adds a new edge between two nodes in the graph
Both nodes should already be in the Graph

3- get nodes.
Returns all of the nodes in the graph as a List

4- get neighbors.
Arguments: node
Returns a List of edges(Nodes) connected to the given node

5- size.
Returns the total number of nodes in the graph (int)

## [Code](https://github.com/ammarAltarawneh/data-structures-and-algorithms-2/blob/master/data-structures-and-algorithms-2/Graph.cs)
## [Test](https://github.com/ammarAltarawneh/data-structures-and-algorithms-2/blob/master/data-structures-and-algorithms-Test/UnitTest1.cs)