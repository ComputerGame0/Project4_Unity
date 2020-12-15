using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component chases a given target object.
 * If the target object in on the TileToHide
 * The component cant chase after it.
 */

public class Chaser: TargetMover,IState {
    [Tooltip("The object that we try to chase")]
    [SerializeField] Transform targetObject = null;
    [SerializeField] TileBase TileToHide = null;
    private Change_the_world change;

    public Vector3 TargetObjectPosition() {
        return targetObject.position;
    }

    private void Update() {
        SetTarget(targetObject.position);
    }

    public void Enter()
    {
        Debug.Log("Enter chase");
        Vector3Int nextNode = tilemap.WorldToCell(targetObject.position);
        change = GetComponent<Change_the_world>();

        TileBase tbb = tilemap.GetTile(nextNode);
        if (tbb == TileToHide)
        {
            this.enabled = false;
            change.Enter();
        }
        else
        {
            this.enabled = true;
        }
        
    }
    public void Exit()
    {
        Debug.Log("Exit chase");
        this.enabled = false;
        Vector3Int nextNode = tilemap.WorldToCell(targetObject.position);
        change = GetComponent<Change_the_world>();
        TileBase tbb = tilemap.GetTile(nextNode);
        if (tbb == TileToHide)
        {
           
            change.Enter();
        }
      
    }
}
