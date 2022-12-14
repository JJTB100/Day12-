using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static List<Node> AStar(char[,] graph)
        {
            // Declare the visited list
            // Declare the unvisited list
            List<Node> Visited = new List<Node>();
            List<Node> Unvisited = new List<Node>();

            //    For each node in graph:
            for (int i =0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    //Add the node to the unvisited list with a g-score of infinity, an f-score of infinity and previous node of null
                    Unvisited.Add(new Node(graph[i,j], i, j, int.MaxValue, int.MaxValue, null));
                }
            }
            /*
        
    Set the start node's g-score to 0 in the unvisited list
    Set the start node's f-score to its h-score in the unvisited list
    
    While the unvisited list is not empty:
        Set current node to the node in the unvisited list with the lowest f-score
        If the current node is the target node:
           End the while loop
           Copy the values for the current node from the unvisited list to the visited list

        Else:   
            For each neighbour of current node:
                If neighbour node is not in the visited list:
                    Calculate new g-score = weight of edge + g-score of current node
                    If new g-score is less than neighbour's g-score in unvisited list:
                        Update the neighbour's g-score with the new g-score
                        Update the neighbour's f-score to new g-score + h_score
                        Update the neighbour's previous node to the current node
            Copy the values for the current node from the unvisited list to the visited list
            Remove the current node from the unvisited list

    Return the visited list*/
        }
    }
    class Node
    {
        Char value;
        int gscore;
        int fscore;
        int x;
        int y;
        public Node(char value, int x, int y, int gscore, int fscore, )
        {
            this.value = value;
            this.x = x;
            this.y = y;
        }
    }

    
}
