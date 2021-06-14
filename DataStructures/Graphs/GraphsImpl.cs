using System.Collections.Generic;

public class GraphImplementation
{
    public static void GraphDriver()
    {
        List<List<int>> adj = new List<List<int>>();
        int V = 5;
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }
        AddEdge(adj, 0, 1);
        AddEdge(adj, 0, 4);
        AddEdge(adj, 1, 2);
        AddEdge(adj, 1, 3);
        AddEdge(adj, 1, 4);
        AddEdge(adj, 2, 3);
        AddEdge(adj, 3, 4);
        PrintGraph(adj);
    }

    static void AddEdge(List<List<int>> adj, int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }
    static void PrintGraph(List<List<int>> adj)
    {
        for (int i = 0; i < adj.Count; i++)
        {
            System.Console.WriteLine($"Adjacency List of vertext {i}");
            System.Console.Write("head");
            for (int j = 0; j < adj[i].Count; j++)
            {
                System.Console.Write($"-> {adj[i][j]}");
            }
            System.Console.WriteLine();
        }
    }
}