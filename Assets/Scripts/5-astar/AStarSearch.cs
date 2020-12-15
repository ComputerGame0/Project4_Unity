using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class AStarSearch
{

    static public float Heuristic(Vector3Int a, Vector3Int b)
    {
       
        return Mathf.Abs(a.x - b.x) + Mathf.Abs(a.y - b.y);
    }
   
    // Conduct the A* search
    public static void FindPath(IGraph<Vector3Int> graph, Vector3Int start, Vector3Int goal, List<Vector3Int> path, Tilemap tilemap)
    {
        Debug.Log("Find path=");
        var cameFrom = new Dictionary<Vector3Int, Vector3Int>();
        var costSoFar = new Dictionary<Vector3Int, float>();

        var frontier = new PriorityQueue<Vector3Int>();
        frontier.Enqueue(start, 0f);

        cameFrom.Add(start, start); // is set to start, None in example
        costSoFar.Add(start, 0f);

        while (frontier.Count > 0f)
        {
            Vector3Int current = frontier.Dequeue();
            if (current.Equals(goal))
                break;
            foreach (var neighbor in graph.Neighbors(current))
            {
                // Vector3Int currentplace=tilemap.WorldToCell(current);
                // Vector3Int neighborplace = tilemap.WorldToCell(neighbor);
                float newCost = costSoFar[current] + Heuristic(current, neighbor);
                Debug.Log("new cost=" + newCost);
                if (!costSoFar.ContainsKey(neighbor) || newCost < costSoFar[neighbor])
                {
                    if (costSoFar.ContainsKey(neighbor))
                    {
                        costSoFar.Remove(neighbor);
                        cameFrom.Remove(neighbor);
                    }

                    costSoFar.Add(neighbor, newCost);
                    cameFrom.Add(neighbor, current);

                   // Vector3Int neighborplace = tilemap.WorldToCell(current);
                   // Vector3Int goalplace = tilemap.WorldToCell(neighbor);
                    float priority = newCost + Heuristic(neighbor, goal);
                    frontier.Enqueue(neighbor, priority);
                }
            }
         }

        foreach (KeyValuePair<Vector3Int, Vector3Int>  kvp in cameFrom)
        {

            Debug.Log("Key = {0}"+ kvp.Key);
            Debug.Log("Key = {1}" + kvp.Value);
           
        }



        // List<Vector3Int> path = new List<Vector3Int>();
        Vector3Int current2 = goal;
           while (!current2.Equals(start))
           {
             if (!cameFrom.ContainsKey(current2))
                 {
                    MonoBehaviour.print("cameFrom does not contain current.");
                    path= new List<Vector3Int>();
                 }
                path.Add(current2);
                Debug.Log("path=" + path[0]);
           
                current2 = cameFrom[current2];
                Debug.Log("current2=" + current2);
           


        }
           path.Reverse();
           //return path;
     }

  public static List<Vector3Int> GetPath(IGraph<Vector3Int> graph, Vector3Int startNode, Vector3Int endNode, Tilemap tilemap)
  {
        Debug.Log("GetPath");
        List<Vector3Int> path = new List<Vector3Int>();
    FindPath(graph, startNode, endNode, path, tilemap);
    return path;
   }
}








