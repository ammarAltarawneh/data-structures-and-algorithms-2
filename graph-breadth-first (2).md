# Breadth-First Traversal of a Graph
In a breadth first traversal, you are starting at a specific vertex/node. This node must be specified when calling the BreadthFirst() method. Breadth first traversal is when you visit all the nodes that are closest to the root as possible. From there you traverse outwards, level by level, until you have visited all the vertices/nodes.

## Challenge
Implement a breadth-first traversal on a graph.
Arguments: Node
Return: A collection of nodes in the order they were visited.

## Approach & Efficiency
BreadthFirst method time complixity is O(n^2)

## Solution
Requirements
We need List, Queue and there methods(Enqueue, Dequeue and Add) and Graph.GetNeighbors().

## [Code](https://github.com/ammarAltarawneh/data-structures-and-algorithms-2/blob/master/data-structures-and-algorithms-2/Graph.cs)