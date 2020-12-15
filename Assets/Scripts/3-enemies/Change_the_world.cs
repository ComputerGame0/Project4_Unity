using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Change_the_world : MonoBehaviour,IState
{
    [SerializeField] Transform targetObject = null;  //the player
    [SerializeField] TileBase TileToreplace = null;   //In our case change to mountains
    [SerializeField] Tilemap tilemap = null;


    public void Enter()
    {
        
        Vector3 lfetTile=targetObject.position + Vector3.left;
        Vector3 rightTile = targetObject.position + Vector3.right;

        Vector3Int nextNode = tilemap.WorldToCell(lfetTile);
        //TileBase tb = tilemap.GetTile(nextNode);
        Vector3Int nextNode2 = tilemap.WorldToCell(rightTile);
        //TileBase tb2 = tilemap.GetTile(nextNode2);

        tilemap.SetTile((nextNode), TileToreplace);
        tilemap.SetTile((nextNode2), TileToreplace);

        Debug.Log("Enter Change_the_world");
       
    }
    public void Exit()
    {
        Debug.Log("Exit Change_the_world");
        //this.enabled = false;
    }
}
