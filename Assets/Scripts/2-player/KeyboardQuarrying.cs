using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * In this class the player can destroy the mountains in order to cross them .
 */

public class KeyboardQuarrying : MonoBehaviour
{
    [SerializeField] TileBase TileToReplace = null;
    [SerializeField] TileBase ReplaceTo = null;
    [SerializeField] Tilemap tilemap = null;
 
    // Start is called before the first frame update
    void Start()
    {

    }


    IEnumerator replace(Vector3 place)
    {
        yield return new WaitForSeconds(2);
        Debug.Log("end time");
        Vector3Int nextNode = tilemap.WorldToCell(place);
        TileBase tb = tilemap.GetTile(nextNode);
        if (tb== TileToReplace)
        {
            tilemap.SetTile((nextNode), ReplaceTo);
        }
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X) && Input.GetKey("right"))
        {
            Vector3Int startNode = tilemap.WorldToCell(transform.position);
            Vector3 place = startNode + Vector3.right;
            StartCoroutine(replace( place));

        }
        if (Input.GetKeyUp(KeyCode.X) && Input.GetKey("left"))
        {
            Vector3Int startNode = tilemap.WorldToCell(transform.position);
            Vector3 place = startNode + Vector3.left;
            StartCoroutine(replace(place));

        }
        if (Input.GetKeyUp(KeyCode.X) && Input.GetKey("up"))
        {
            Vector3Int startNode = tilemap.WorldToCell(transform.position);
            Vector3 place = startNode + Vector3.up;
            StartCoroutine(replace(place));
        }
        if (Input.GetKeyUp(KeyCode.X) && Input.GetKey("down"))
        {
            Vector3Int startNode = tilemap.WorldToCell(transform.position);
            Vector3 place = startNode + Vector3.down;
            StartCoroutine(replace(place));
        }
    }
}
