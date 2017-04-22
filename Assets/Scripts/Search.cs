using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search
{

    public Graph graph;
    public List<Node> reachable;
    public List<Node> explored;
    public List<Node> path;
    public Node goalNode;
    public int iterations;
    public bool finished;

    public Search(Graph graph)
    {
        this.graph = graph;
    }

    public void Start(Node start, Node goal)
    {
        reachable = new List<Node>();
        reachable.Add(start);

        goalNode = goal;

        explored = new List<Node>();
        path = new List<Node>();
        iterations = 0;

        for (var i = 0; i < graph.nodes.Length; i++)
        {
            graph.nodes[i].Clear();
        }
    }

    public void Step()  //allows us to test a node and its neighbors for next possible move
    {
        if (path.Count > 0) //ensures that Step is no longer callled if path to destination has been reached
        {
            return;  //return out of method so none of the following code is executed
        }
        if (reachable.Count == 0) //if it has run out of options to move and there's no solution i.e., search is done
        {
            finished = true;
            return;
        }

        iterations++;

        var node = ChooseNode();
        if (node == goalNode)
        {
            while (node != null) //tests if current node is the goal node
            {
                path.Insert(0, node); //node that's being currently looped through
                node = node.previous; //keeps track of previous node visited
            }
            finished = true;
            return;
        }
        reachable.Remove(node);
        explored.Add(node);

        for(var i = 0; i<node.adjacent.Count; i++)
        {
            AddAdjacent(node, node.adjacent[i]);
        }
    }

    public void AddAdjacent(Node node, Node adjacent)
    {
        if(FindNode(adjacent, explored) || FindNode(adjacent, reachable))
        {
            return;
        }
        adjacent.previous = node;
        reachable.Add(adjacent);
    }

   public bool FindNode(Node node, List<Node> list)
    {
        return GetNodeIndex(node, list) >=0;
    }

    public int GetNodeIndex(Node node, List<Node> list)
    {
        for(var i = 0; i< list.Count; i++)
        {
            if(node == list[i])
            {
                return 1;
            }
        }
        return -1;
    }

    public Node ChooseNode()
    {
        return reachable[Random.Range(0, reachable.Count)];
    }
}
