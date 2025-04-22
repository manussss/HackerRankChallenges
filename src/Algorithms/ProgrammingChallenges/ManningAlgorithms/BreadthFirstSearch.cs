namespace ProgrammingChallenges.ManningAlgorithms;

/*
Breadth-First Search (BFS) explores all nodes at the current level before moving 
on to the next level. It’s useful for problems where you need to find the shortest 
path between two nodes.
*/
public class Graph
{
    // Dictionary to store the edges in the graph
    Dictionary<int, List<int>> edges = [];

    // Method to add an edge to the graph
    public void AddEdge(int u, int v)
    {
        if(!edges.ContainsKey(u))
            edges.Add(u, []);
        if(!edges.ContainsKey(v))
            edges.Add(v, []);
            
        edges[u].Add(v);
        edges[v].Add(u);
    }

    // Method to perform breadth-first search
    public List<int> BreadthFirstSearch(int start)
    {
        // List to store the visited nodes
        List<int> visited = [];

        // Queue to store the nodes to be visited
        Queue<int> queue = new();

        // Add the starting node to the queue
        queue.Enqueue(start);

        // Loop until the queue is empty
        while (queue.Count > 0)
        {
            // Dequeue a node from the queue
            int node = queue.Dequeue();

            // If the node has not been visited
            if (!visited.Contains(node))
            {
                // Mark the node as visited
                visited.Add(node);

                // Enqueue the neighbors of the node
                foreach (var neighbor in edges[node])
                    queue.Enqueue(neighbor);
            }
        }

        return visited;
    }
}